using System;
using System;
using System.Collections;
using System.Collections.Generic;


namespace EniroApp
{
    /// <summary>
    /// Design Pattern : Factory Method
    /// The 'Creator' abstract class
    /// Can be used to read CSV data from multiple modes i.e. String, File, Database, RestAPI
    /// </summary>
    public abstract class CSVReaderCreator
    {
        public abstract CSVData FactoryMethod();
        public abstract CSVData FactoryMethod(string csv);
    }
    /// <summary>
    /// Concrete CSVStringReader class
    /// </summary>
    public class CSVStringReader : CSVReaderCreator
    {
        public override CSVData FactoryMethod(string CSV)
        {
            return new CSVFromString(CSV.Trim());
        }

        public override CSVData FactoryMethod()
        {
            return new CSVFromString();
        }
    }


    /// <summary>
    /// CSV Data abstract class
    /// </summary>
    public abstract class CSVData
    {
        protected string CSV;
        public abstract string getCSVData();
    }
    /// <summary>
    /// Concrete CSVData class
    /// </summary>
    public class CSVFromString : CSVData
    {
        public CSVFromString(String csv)
        {
            //check for csv string like :  "2003", "Anneli", "Temi", "Stock", "899",
            if (csv.LastIndexOf(',') == csv.Length - 1)
                csv = csv.TrimEnd(',');
            this.CSV = csv.Trim();
        }
        public CSVFromString()
        {
        }
        public override string getCSVData()
        {
            return this.CSV;
        }
    }
    public class CSVFromFile : CSVData
    {
        public override string getCSVData()
        {
            throw new NotImplementedException();
        }
    }
}
