using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SQLite;

namespace loom.time
{
    public class LocalLoomDB : SQLiteConnection
    {

        static object locker = new object();

        public static string DatabaseFilePath
        {
            get
            {
                var sqliteFilename = "local_loom.db3";
                    
                #if NETFX_CORE
                var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, sqliteFilename);
                #else

                #if SILVERLIGHT
                // Windows Phone expects a local path, not absolut
                var path = sqliteFilename;
                #else

                #if __ANDROID__
                // Just use whatever directory SpecialFolder.Personal returns
                string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                #else

                #if __IOS__
                // we need to put in /Library/ on iOS5.1 to meet Apple's iCloud terms
                // (they don't want non-user-generated data in Documents)
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
                string libraryPath = Path.Combine(documentsPath, "../Library/"); // Library folder
                #else

                // UNIX
                // for now we place the DB in the main users folder so that we don't have to
                // create a sub folder here. Should be added later if a desktop app is designed.
                string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // main user folder
#endif

#endif

                var path = Path.Combine(libraryPath, sqliteFilename);

                #endif

                #endif

                return path;
            }
        }

        public LocalLoomDB(string path) : base(path)
        {
            // create the tables
            CreateTable<Leistung>();
            CreateTable<Vorgang>();
            CreateTable<Stammdaten>();
        }


        public IEnumerable<Leistung> GetLeistungen()
        {
            lock (locker)
            {
                return (from i in Table<Leistung>() select i).ToList();
            }
        }

        public Leistung GetLeistung(int id)
        {
            lock (locker)
            {
                return Table<Leistung>().FirstOrDefault(x => x.LocalLeistungsNr == id);
            }
        }

        public int SaveLeistung(Leistung item)
        {
            lock (locker)
            {
                if (item.LocalLeistungsNr != 0)
                {
                    Update(item);
                    return item.LocalLeistungsNr;
                }
                else
                {
                    return Insert(item);
                }
            }
        }

        public int DeleteLeistung(int id) 
        {
            lock (locker) {
                return Delete<Leistung> (new Leistung () { LocalLeistungsNr = id });
            }
        }

        public int DeleteLeistung(Leistung item)
        {
            lock (locker)
            {
                return Delete<Leistung>(item.LocalLeistungsNr);
            }
        }

        public IEnumerable<Vorgang> GetVorgaenge()
        {
            lock (locker)
            {
                return (from i in Table<Vorgang>() select i).ToList();
            }
        }

        public Leistung GetVorgang(int id)
        {
            lock (locker)
            {
                return Table<Vorgang>().FirstOrDefault(x => x.VorgangNr == id);
            }
        }

        public int SaveVorgang(Vorgang item)
        {
            lock (locker)
            {
                if (item.VorgangNr != 0)
                {
                    Update(item);
                    return item.VorgangNr;
                }
                else
                {
                    return Insert(item);
                }
            }
        }

        public int DeleteVorgang(int id)
        {
            lock (locker)
            {
                return Delete<Vorgang>(new Vorgang() { VorgangNr = id });
            }
        }

        public int DeleteVorgang(Vorgang item)
        {
            lock (locker)
            {
                return Delete<Vorgang>(item.VorgangNr);
            }
        }

        public Stammdaten GetStammdaten()
        {
            lock (locker)
            {
                return Table<Stammdaten>().First();
            }
        }

        public int SaveStammdaten(Stammdaten item)
        {
            lock (locker)
            {
                if (item.PersonalNr != 0)
                {
                    Update(item);
                    return item.PersonalNr;
                }
                else
                {
                    return Insert(item);
                }
            }
        }

        public int sync_to_remote_server()
        {
            // code to be added
            // will return the number of modified lines
        }
    }

}
