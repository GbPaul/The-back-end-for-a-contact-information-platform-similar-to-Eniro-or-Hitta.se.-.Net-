using System;
using System.Collections;
using System.Collections.Generic;


namespace EniroApp
{
    /// <summary>
    /// Design Pattern : Singleton
    /// </summary>
    public class PersonParser
    {
        //Singleton Design Patter
        private static PersonParser personParser;

        public static PersonParser GetInstance()
        {
                if (personParser == null)
                    personParser = new PersonParser();
                return personParser;
        }
        PersonCollections personCollections;
        public PersonCollections ParsePersonFromString(CSVData csv)
        {
            try
            {  
                string[] personArray = csv.getCSVData().Split(',');
                if(personCollections == null)
                    personCollections = new PersonCollections(); //Iterator Design Patter used inside class

                for (int i = 0; i < personArray.Length; i += 5)
                {
                    personCollections.CreateUser(new Person(
                        personArray[i],
                        personArray[i + 1],
                        personArray[i + 2],
                        personArray[i + 3],
                        personArray[i + 4]
                        ));
                }
                return personCollections;
               
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
