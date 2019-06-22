using System;
using System.Collections;
using System.Collections.Generic;


namespace EniroApp
{
   public class PersonCollections : Person, IPersonCollections
    {

        public Hashtable contactList = new Hashtable();
        //private int Personal_Id = 0;

        public  ICustomIterator CreateIterator()
        {
            return new PersonCollectionIterator(contactList);
        }

        public PersonCollections(Hashtable contactList)
        {
            this.contactList = contactList;
        }
         
        public PersonCollections()
        {}
       

        public virtual void CreateUser(Person user)
        {
            if (!contactList.Contains(user.Personal_Id))
                contactList.Add(user.Personal_Id, user);
            Console.WriteLine("per {1} has been added succesfully: " + user);

            foreach (var item in contactList.Values)
            {
                Console.WriteLine(item);
            }
        }

        // method to retrieve all person
        public void RetrieveAllPerson()
        {
            var i = contactList.GetEnumerator();

            if (!(contactList == null))
            { while (i.MoveNext()){
                    DictionaryEntry contact= (DictionaryEntry)i.Current;
                    Console.WriteLine(contact.Value);
                }
            } else {
                Console.WriteLine("contact list is empty!");
            }}

        public Person RetrieveByPersonalId(string personal_Id)
        {
            if (!contactList.Contains(personal_Id))
                throw new Exception("This user does not exist!");
            Console.WriteLine(" person {0} is retrieved " , contactList[personal_Id]);
            return (Person)contactList[personal_Id];
        }



// method to update the list of person
        public virtual void UpdateUser(Person per)
        {
            if (!contactList.Contains(per.Personal_Id))
                throw new Exception("This person is already in the list!");
            Console.WriteLine(per);
            Console.WriteLine(" the person list is now updated");
        }


        public virtual void DeleteUser(Person per)
        {
            if (!contactList.Contains(per.Personal_Id))
                Console.WriteLine("This person does not exist!");
            contactList.Remove(per.Personal_Id);
            Console.WriteLine("person {1} has been deleted" + per.Personal_Id);
        }

       

        public override string ToString()
        {
            string result = "";

            foreach (Person user in contactList.Values)
            {
                result += user.ToString() + "\n";
            }

            return result + "";
        }

        public int GetNumberOfEntries()
        {
            return contactList.Count;
        }
    }

    public interface ICustomIterator
    {
        object Current { get; }
        bool IsDone();
        object MoveNext();
    }
}
