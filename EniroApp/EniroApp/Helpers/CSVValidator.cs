using System;
using System;
using System.Collections;
using System.Collections.Generic;


namespace EniroApp
{
    /// <summary>
    /// Design Pattern : Strategy
    /// Used for validating CSV Data
    /// </summary>
    public interface ValidationStrategy
    {
        bool Validate(CSVData r);
    }
    public class ConcreteValidator : ValidationStrategy
    {
        public bool Validate(CSVData cSVData)
        {
            return cSVData.getCSVData().Split(',').Length / 5 > 0 && cSVData.getCSVData().Split(',').Length % 5 == 0;
        }
    }
    //public class CSVValidator
    //{
    //    private ValidationStrategy _strategy;

    //    // Constructor

    //    public CSVValidator(ValidationStrategy strategy)
    //    {
    //        this._strategy = strategy;
    //    }

    //    public bool Validate(CSVData cSVData)
    //    {
    //        return _strategy.Validate(cSVData);
    //    }
    //}

}
