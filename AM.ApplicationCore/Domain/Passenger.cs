using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public String PassportNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string TelNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public IList<Flight> flights { get; set; }

     
        public bool CheckProfile(string firstname, string lastename, string email=null )
        {

                return firstname == FirstName && lastename == LastName && (email == EmailAddress|| email==null);
        }
        public virtual void PassengerType() { Console.WriteLine("I m a ppassener"); }
        public Passenger(String id, string nom, string prenom, string email, string num, DateTime dateNaissance)
        {
            PassportNumber = id;
            FirstName = nom;
            LastName = prenom;
            EmailAddress = email;
            TelNumber = num;
            BirthDate = dateNaissance;
        }

        public Passenger() { }
        public override string ToString()
        {
            return $"BirthDate: {BirthDate}, PassportNumber: {PassportNumber}, EmailAddress: {EmailAddress}, FirstName: {FirstName}, LastName: {LastName}, TelNumber: {TelNumber}";
        }
    }
}