using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using loom.webapi.models;
using System.Configuration;

namespace loom.webapi.Controllers
{
    public class ProjecElementController : ApiController
    {
        static LoomDB _db = new LoomDB(ConfigurationManager.AppSettings["LoomConnectionString"]);
        
        public IEnumerable<ProjectElement> GetProjectElements()
        {
            /*
             * sCommand = "SELECT ProjektElementNr, ProjektNummer, ProjektElement.Beschreibung AS PEBeschreibung, Personal.Vorname, Personal.Nachname, Land.Beschreibung AS LandBeschreibung FROM TODB.ProjektElement " & _
"INNER JOIN TODB.Personal ON ProjektElement.ProjektElementVerantwortlich = Personal.PersonalNr " & _
"INNER JOIN TODB.Land ON ProjektElement.AusfuehrungsLand = Land.LandNr " & _
"INNER JOIN TODB.Vorgang ON ProjektElement.ProjektelementNr = Vorgang.ProjektElement " & _
"INNER JOIN TODB.ProzessElement ON Vorgang.ProzessElement = ProzessElement.ProzessElementNr " & _
"WHERE ProzessElement.Prozessphase = " & lngProzessPhase & " AND ProzessElement.Abteilung = " & lngAbteilungsNr & " AND ProzessElement.ProzessElementTyp = 1 " & _
"AND ProjektElementNr NOT IN(SELECT ProjektElementNr FROM TODB.ProjektElement " & _
"INNER JOIN TODB.Vorgang ON ProjektElement.ProjektelementNr = Vorgang.ProjektElement " & _
"INNER JOIN TODB.ProzessElement ON Vorgang.ProzessElement = ProzessElement.ProzessElementNr " & _
"WHERE ProzessElement.Prozessphase = " & lngProzessPhase & " AND ProzessElement.Abteilung = " & lngAbteilungsNr & " AND ProzessElement.ProzessElementTyp = 3);"

    */
            return _db.ProjectElement;
        }      
    }
}