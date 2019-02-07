using System;
namespace loom.time.ViewModels
{
    public class VM_Login

    { 
    
    
        public int LoginNr { get; set; }
        public string StaffName { get; set; }

        public bool SetLogin(double NEWLoginNr)
        {
            //Checked ob Double = Integer
            bool isInt = NEWLoginNr == (int)NEWLoginNr;

            if (isInt)
            {
                // Konvertiert in int wenn isInt = true
                LoginNr = Convert.ToInt32(NEWLoginNr) + 1;

                //Hier checken Stammdaten bekommen, dann rückgabe True

                Models.Stammdaten stammdaten = new Models.Stammdaten();

                //hier if statement stammdaten.PersonalNr is nothing then, else return false

                stammdaten.PersonalNr = LoginNr;
                StaffName = stammdaten.Name + ", " + stammdaten.Vorname;


                return true;
            }
            else
            {   
                //Rückgabe False, wenn NewLoginNr = Kommazahl
                return false;
            }

        }
    }
}
