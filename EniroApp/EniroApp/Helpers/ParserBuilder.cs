using System;
using System.Collections;
using System.Collections.Generic;


namespace EniroApp
{
    /// <summary>
    /// Design Pattern : Builder
    /// will be used to Build Parser which will create objects from strings
    /// </summary>
    interface IParserBuilder
    {
        void BuildCSVReader(CSVReaderCreator cSVReaderCreator);
        void BuildCSVValidator(ValidationStrategy validationStrategy);
        void BuildPersonParser(PersonParser personParser);
        IPersonCollections GetPerson(string csv);
    }
    public class ParserBuilder : IParserBuilder
    {
        //Factory Design Pattern used inside class
        public CSVReaderCreator cSVReaderCreator;
        //Strategy Design Pattern used inside class
        public ValidationStrategy validationStrategy;
        //Singleton Design Pattern used inside class
        public PersonParser personParser;

        public void BuildCSVReader(CSVReaderCreator cSVReaderCreator)
        {
            this.cSVReaderCreator = cSVReaderCreator;
        }

        public void BuildCSVValidator(ValidationStrategy validationStrategy)
        {
            this.validationStrategy = validationStrategy;
        }

        public void BuildPersonParser(PersonParser personParser)
        {
            this.personParser = personParser;
        }

        public IPersonCollections GetPerson(string csv)
        {
            try
            {
                CSVData cSVData = cSVReaderCreator.FactoryMethod(csv);

                if (validationStrategy.Validate(cSVData))
                {
                    return personParser.ParsePersonFromString(cSVData);
                }
                else
                    return null;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
