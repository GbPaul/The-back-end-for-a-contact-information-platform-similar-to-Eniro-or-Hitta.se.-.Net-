using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EniroApp
{
    public class Person
    {

        private string personal_Id;
        private string first_name;
        private string last_name;
        private string adress;
        private string phoneNumber;

        public Person(string PersonalId, string firstName, string lastName, string adress, string phoneNumber)


        {
            this.personal_Id = PersonalId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
        }

        public Person()
        {
        }

       

        public string Personal_Id
        {
            get { return personal_Id; }
            set { personal_Id = value; }
        }

        public string FirstName

        {
            get { return first_name; }
            set { first_name = value; }
        }
        public string LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public override string ToString()

        {
            return "PersonalId : " + this.Personal_Id + " " + this.FirstName + " " + this.LastName + " " + this.Adress + " " + this.PhoneNumber;
        }

    }
}



