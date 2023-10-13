using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsYearCollection
/// </summary>
public class clsYearCollection
{

    // create a connection too the databse with class levl scope
    clsDataConnection Years = new clsDataConnection();
    //constructor
    public clsYearCollection()
    {
        //execute the select all query
        Years.Execute("sproc_tblYearManufactured_SelectAll"); 
    }

    //this read only functon gives us the count property

    public Int32 Count
    {
        get
        {
            //returnthe count of the data from the datbase
            return Years.Count;
        }
        
    }
    //this randomly function exposes the query result collection
    public List<clsYear> AllYears
    {
        get
        {
            //create a instance of alist called mAllYears
            List<clsYear> mAllYears = new List<clsYear>();
            //var to store the index for the loop
            Int32 Index = 0;
            //while the index is less that the no ofrecords to process
            while(Index < Years.Count)
            {
                //set up the new entry to be added to the list
                clsYear NewYear = new clsYear();
                //get the county n from the database
                NewYear.YearNo = Convert.ToInt32(Years.DataTable.Rows[Index]["YearNo"]);
                //gett the year from the database
                NewYear.Year = Convert.ToString(Years.DataTable.Rows[Index]["YearManufactured"]);
                //add the new entry to the list
                mAllYears.Add(NewYear);
                //incrememt the inde to the next record
                Index++;
            }
            //return the query result from the database
            return mAllYears;
        }
    }
}