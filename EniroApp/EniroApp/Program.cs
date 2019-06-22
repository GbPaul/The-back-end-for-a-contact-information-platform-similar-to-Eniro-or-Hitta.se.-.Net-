using EniroApp.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EniroApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable ht = new Hashtable();


            Person person1 = new Person("56686", "Paul", "Ay", "Lagos", "078");
            Person person2 = new Person("56685", "Pr", "Ay", "Lagos", "078");
            Person person3 = new Person("1999", "Anneli", "Temi", "Stock", "899");

            PersonCollections contactList = new PersonCollections();

            contactList.CreateUser(person3);
            contactList.CreateUser(person1);
            contactList.CreateUser(person2);


            contactList.RetrieveAllPerson();
            Person person4 = new NewPerson("1999", "Anneli", "Temi", "Stock", "899");



            Console.WriteLine("Retrieving a person with id 1999");

            contactList.RetrieveByPersonalId("1999");

            //sigleton pattern of random person

            RandomPerson per = RandomPerson.GetInstance();

            //foreach (DictionaryEntry item in ht)
            //    Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);

            //Block 3 Code
            Console.WriteLine("-----------------------------Block 3-------------------------------");
            Console.WriteLine("Design Patterns Used \n1. Factory Design Pattern for getting CSV Data\n2. Strategy Design Patter for Data Validation");
            Console.WriteLine("3. Singleton Design Pattern for Parsing CSV \n4. Builder Design Pattern is used to build them all together\n5. Iterator Design Pattern for Printing Added Person");
            Console.WriteLine("For Bulk person insertion of person from csv string, please press Y and for exit press N");
            while (true)
            {

                String input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Please Enter CSV formatted string for bulk user insertion");
                    Console.WriteLine("Please use following format : ");
                    Console.WriteLine("\"PersonalId\",\"firstName\",\"lastName\",\"adress\",\"phoneNumber\",\"PersonalId\",\"firstName\",\"lastName\",\"adress\",\"phoneNumber\"");
                    Console.WriteLine("------------------------------------------------------------");

                    //Design pattern : Builder
                    ParserBuilder parserBuilder = new ParserBuilder();

                    //For getting CSV data  (inside class Factory Design Pattern Used)
                    CSVStringReader cSVStringReader = new CSVStringReader();
                    parserBuilder.BuildCSVReader(cSVStringReader);

                    //for validating csv data (inside class Strategy Design Pattern used)
                    ConcreteValidator concreteValidator = new ConcreteValidator();
                    parserBuilder.BuildCSVValidator(concreteValidator);

                    //for parsing object from csv data (inside class Singleton Design Pattern used)
                    parserBuilder.BuildPersonParser(PersonParser.GetInstance());

                    while (true)
                    {
                        
                        string csv = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(csv) || csv == "y" || csv == "n")
                        {
                            break;
                        }
                        else
                        {
                            IPersonCollections personCollections = parserBuilder.GetPerson(csv);
                            if (personCollections == null)
                            {
                                Console.WriteLine("Error : Invalid CSV String!");
                                break;
                            }
                        }
                    }
                }
                else if (input == "n")
                {
                    break;
                    Console.WriteLine("------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Invalid Input, please enter Y to enter person or N for exit");
                    Console.WriteLine("------------------------------------------------------------");
                }
            }




            // contactList.RetrieveAllPerson();
            // Console.WriteLine(contactList);
            //Console.ReadLine();

        }

    }
}
