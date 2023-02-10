using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller : Passenger
    {
        public Traveller()
        {
        }

        public Traveller(string id, string nom, string prenom, string email, string num, DateTime dateNaissance) : base(id, nom, prenom, email, num, dateNaissance)
        {
        }

        public string HealthInformation { get; set; }
        public string Nationality { get; set; }

        public override void PassengerType() { base.PassengerType(); Console.WriteLine("I am a traveller "); }

        public override string ToString()
        {
            return $"HealthInformation: {HealthInformation}, Nationality: {Nationality}";
        }

    }
   

}
