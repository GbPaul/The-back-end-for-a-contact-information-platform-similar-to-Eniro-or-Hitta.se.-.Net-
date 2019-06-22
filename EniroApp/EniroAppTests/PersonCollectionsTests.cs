using Microsoft.VisualStudio.TestTools.UnitTesting;
using EniroApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EniroApp.Tests
{
    [TestClass()]
    public class PersonCollectionsTests
    {
        [TestMethod()]
        public void CreateUserTest()
        {
            PersonCollections adressBk = new PersonCollections();
            Person person = new Person("1", "Ade", "oven", "uppsala", "33456");
            adressBk.CreateUser(person);
        }


        [TestMethod]
        public void CannotCreateNullNamedEntry()
        {
            PersonCollections adressBk = new PersonCollections();
            Person person = new Person(null, "Tolani", "oven ", "uppsala", "33456");
            Assert.ThrowsException<ArgumentNullException>(() => adressBk.CreateUser(person));
        }

        [TestMethod()]
        public void RetrieveByPersonalIdTest()
        {
            PersonCollections adressBk = new PersonCollections();
            Person person = new Person("1", "Ade", "oven", "uppsala", "33456");
            
            adressBk.RetrieveByPersonalId("1");
        }

        [TestMethod]
        public void CannotRetrieveNullNamedEntry()
        {
            PersonCollections adressBk = new PersonCollections();
            Person person = new Person(null, "Tolani", "oven ", "uppsala", "33456");
            Assert.ThrowsException<ArgumentNullException>(() => adressBk.RetrieveByPersonalId("100"));
        }

        [TestMethod()]
        public void RetrieveAllUserTest()
        {
            PersonCollections contactList = new PersonCollections();
            Person person1 = new Person("1", "Ade", "oven", "uppsala", "33456");
            contactList.RetrieveAllPerson();
        }
        

        [TestMethod()]
        public void DeleteUserTest()
        {
            PersonCollections contactList = new PersonCollections();
            Person person = new Person("1", "Ade", "oven", "uppsala", "33456");
            contactList.DeleteUser(person);
        }

        [TestMethod]
        public void AddedEntryMaintainsValue()
        {
            PersonCollections contactList = new PersonCollections();
            Person person1 = new Person("1", "Ade", "oven", "uppsala", "33456");
            contactList.CreateUser(person1);
            
        }


        [TestMethod]
        public void RemoveUser_FirstName()
        {
            PersonCollections adressBook = new PersonCollections();
            Person firstName = new Person(1, "Vilma", "michael", "uppsala", "0754563254");
            adressBook.DeleteUser(firstName);
        }

        [TestMethod]
        public void ReturnNumberofEntries()
        {
            PersonCollections adressBook = new PersonCollections();
            Assert.IsNotNull(!(adressBook.GetNumberOfEntries() == 0), "values exist in the address book");
        }

        [TestMethod]
        public void AddressBookHasNoEntriesAtStart()
        {
            PersonCollections phoneBook = new PersonCollections();
            Assert.AreEqual(0, phoneBook.GetNumberOfEntries(), "No entries to start with.");
        }

        [TestMethod]
        public void Update_LastName()
        {
            PersonCollections phoneBook = new PersonCollections();
           Person lastName = new Person("1", "Ali", "tobi", "uppsala", "03254");
            phoneBook.UpdateUser(lastName);


        }

       
        //[TestMethod]
        //public void Update_Adress()
        //{
        //    PersonCollections phoneBook = new PersonCollections();
        //    Person adress = new Person("1", "dad", "temi", "Sun", "0754563254");
        //    phoneBook.UpdateUser(adress);

        //}
       




    }
}