using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCarCollection
/// </summary>
public class clsCarCollection
{

    //private data members
    //create a null instance of the class clsDataConnection with class level scope
    clsDataConnection dBConnection = new clsDataConnection();
    //private data member for the current address
    clsCars mThisCar = new clsCars();


    public clsCars ThisCars
    {
        get
        {
            return mThisCar;
        }
        set
        {
            mThisCar = value;
        }
    }

    public clsCarCollection()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public Boolean Delete(Int32 CarNo)
    {
        try
        {


            clsDataConnection MyDatabase = new clsDataConnection();
            MyDatabase.AddParameter("@CarNo", CarNo);
            MyDatabase.Execute("sproc_tblAvailability_Delete");
            return true;
        }
        catch
        {
            return false;
        }
    }

    public List<clsCars> BrandNameList
    {
        get
        {
            //crat an array lis of type clsCar
            List<clsCars> mBrandNameList = new List<clsCars>();

            //var to store the count of records
            Int32 RecordCount;
            //var to the index of the loop
            Int32 Index = 0;
            //create a connection too thee database
             dBConnection = new clsDataConnection();
            //send a brand name filter to the query
            dBConnection.AddParameter("@BrandName", "");
            //EXECUTE THE QUERY
            dBConnection.Execute("sproc_tblAvailability_FilterByBrandName");


            //get the count of records
            RecordCount = dBConnection.Count;
         
            // keep looping till all records are proceesed
            while (Index < RecordCount)
            {
                clsCars NewCars = new clsCars();
                //copy the data from table to RAM

                NewCars.CarNo = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["CarNo"]);
                NewCars.BrandName = Convert.ToString(dBConnection.DataTable.Rows[Index]["BrandName"]);
                NewCars.ModelNAme = Convert.ToString(dBConnection.DataTable.Rows[Index]["ModelNAme"]);

                NewCars.Colour = Convert.ToString(dBConnection.DataTable.Rows[Index]["Colour"]);
                NewCars.Condition = Convert.ToString(dBConnection.DataTable.Rows[Index]["Condition"]);
                NewCars.PreviousOwners = Convert.ToString(dBConnection.DataTable.Rows[Index]["PreviousOwners"]);
                NewCars.RegNo = Convert.ToString(dBConnection.DataTable.Rows[Index]["RegNo"]);
                NewCars.MIilesDriven = Convert.ToString(dBConnection.DataTable.Rows[Index]["MIilesDriven"]);

                NewCars.FuelType = Convert.ToString(dBConnection.DataTable.Rows[Index]["FuelType"]);
                NewCars.Price = Convert.ToString(dBConnection.DataTable.Rows[Index]["Price"]);
                NewCars.Active = Convert.ToBoolean(dBConnection.DataTable.Rows[Index]["Active"]);
                NewCars.DateAdded = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["DateAdded"]);
                //add the blank page to array list
                mBrandNameList.Add(NewCars);
                //Increase th Index
                Index++;
            }
            return mBrandNameList;
        }
    }
    public Int32 Count
    //public read only property for the count of records found
    {
        get
        {
            //create an connection to te databse
            clsDataConnection dBConnection = new clsDataConnection();
            //send a post code filter to the query
            dBConnection.AddParameter("@BrandName", "");
            //executr the query
            dBConnection.Execute("sproc_tblAvailability_FilterByBrandName");
            //return the count of records
            return dBConnection.Count;
        }
    }
    public Int32 Add()
    /// this function will add a new  address to the databse
    /// it accepts a single paramter an object of type clscars
    /// once the record is added the function returns the primary key value of the new record
    ///    ///
    ///    INSERT Into tblAddress

    // connect to the database
    {
        clsDataConnection NewdBCars = new clsDataConnection();
        //add the parameters
        NewdBCars.AddParameter("@BrandName", mThisCar.BrandName);
        NewdBCars.AddParameter("@ModelName", mThisCar.ModelNAme);
        NewdBCars.AddParameter("@Colour", mThisCar.Colour);
        NewdBCars.AddParameter("@Condition", mThisCar.Condition);
        NewdBCars.AddParameter("@PreviousOwners", mThisCar.PreviousOwners);
        NewdBCars.AddParameter("@RegNo", mThisCar.RegNo);
        NewdBCars.AddParameter("@MilesDriven", mThisCar.MIilesDriven);
        NewdBCars.AddParameter("@FuelType", mThisCar.FuelType);
        NewdBCars.AddParameter("@Price", mThisCar.Price);
        NewdBCars.AddParameter("@Active", mThisCar.Active);
        NewdBCars.AddParameter("@YearCode", mThisCar.YearCode);


        //execute the stored procedure returning primary key value of the new record
        return NewdBCars.Execute("sproc_tblAvailability_Insert");
    }
    public void Update()
    {
        clsDataConnection ExistingdBCars = new clsDataConnection();
        //add the parameters
        ExistingdBCars.AddParameter("@CarNo", mThisCar.CarNo);
        ExistingdBCars.AddParameter("@BrandName", mThisCar.BrandName);
        ExistingdBCars.AddParameter("@ModelName", mThisCar.ModelNAme);
        ExistingdBCars.AddParameter("@Colour", mThisCar.Colour);
        ExistingdBCars.AddParameter("@Condition", mThisCar.Condition);
        ExistingdBCars.AddParameter("@PreviousOwners", mThisCar.PreviousOwners);
        ExistingdBCars.AddParameter("@RegNo", mThisCar.RegNo);
        ExistingdBCars.AddParameter("@MIilesDriven", mThisCar.MIilesDriven);
        ExistingdBCars.AddParameter("@FuelType", mThisCar.FuelType);
        ExistingdBCars.AddParameter("@Price", mThisCar.Price);
        ExistingdBCars.AddParameter("@Active", mThisCar.Active);
        ExistingdBCars.AddParameter("@YearCode", mThisCar.YearCode );
        ExistingdBCars.AddParameter("@DateAdded", mThisCar.DateAdded);

        //execute the query
        ExistingdBCars.Execute("sproc_tblAvailability_Update");
    }
    public void Delete()
    ///it is a void function and returns no value
    {
        //initialise the DBConnection
        dBConnection = new clsDataConnection();
        //add the parameter data used by the stored procedure
        dBConnection.AddParameter("@CarNo", mThisCar.CarNo);
        //execute the stored procedure to solds
        dBConnection.Execute("sproc_tblAvailability_Sold");
       
    }

    public void FilterByBrandName(string BrandName)
    {
        dBConnection = new clsDataConnection();
        dBConnection.AddParameter("@BrandName", BrandName);
        dBConnection.Execute("sproc_tblAvailability_FilterByBrandName");
    }
}


    
    
