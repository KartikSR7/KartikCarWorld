using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsYear
/// </summary>
public class clsYear
{
    private int mYearNo;
    //public property for YearNo
    public Int32 YearNo
    {
        get
        {
            return mYearNo;
         }
        set
        {
            mYearNo = value;
        }

    }
    //private member variable for Year
    private string mYear;
    //public propery for county
    public string Year
    {
        get
        {
            return mYear;
        }
        set
        {
            mYear = value;
        }
    }
}