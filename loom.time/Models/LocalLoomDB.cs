using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SQLite;

using System.Data;
using System.Data.SqlClient;


namespace loom.time.Models
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
            CreateTable<Department>();
            CreateTable<Activity>();
            CreateTable<ProcessElement>();
            CreateTable<ProcessPhase>();
            CreateTable<ProjectElement>();
            CreateTable<Staff>();
        }
        
        public IEnumerable<Performance> GetPerformances()
        {
            lock (locker)
            {
                return (from i in Table<Performance>() select i).ToList();
            }
        }

        public Performance GetPerformance(int id)
        {
            lock (locker)
            {
                return Table<Performance>().FirstOrDefault(x => x.PerformanceID == id);
            }
        }

        public int SavePerformance(Performance item)
        {
            lock (locker)
            {
                if (item.PerformanceID != 0)
                {
                    Update(item);
                    return item.PerformanceID;
                }
                else
                {
                    return Insert(item);
                }
            }
        }

        public int DeletePerformance(int id)
        {
            lock (locker)
            {
                return Delete<Performance>(new Performance() { PerformanceID = id });
            }
        }

        public int DeletePerformance(Performance item)
        {
            lock (locker)
            {
                return Delete<Performance>(item.PerformanceID);
            }
        }


        public IEnumerable<Activity> GetActivities()
        {
            lock (locker)
            {
                return (from i in Table<Activity>() select i).ToList();
            }
        }

        public Activity GetActivity(int id)
        {
            lock (locker)
            {
                return Table<Activity>().FirstOrDefault(x => x.ActivityID == id);
            }
        }

        public Staff GetStaff(int id)
        {
            lock (locker)
            {
                // FirstOrDefault will return 0 if not Stamdaten is set
                return Table<Staff>().FirstOrDefault(x => x.StaffID == id);

            }
        }

        
    }
}
