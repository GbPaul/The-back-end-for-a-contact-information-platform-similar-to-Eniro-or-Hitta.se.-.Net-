namespace EniroApp
{
    public class NewPerson: PersonCollections ,IPersonCollections
    {


        private string personal_Id;
        private string first_name;
        private string last_name;
        private string adress;
        private string phoneNumber;

        public NewPerson()
        {
        }

        public NewPerson(string PersonalId, string firstName, string lastName, string adress, string phoneNumber)
        {
            this.personal_Id = PersonalId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
        }











    }
}