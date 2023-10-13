using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCars
/// </summary>
public class clsCars
{
   
    public clsCars()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    private Int32 mCarNo;
    public Int32 CarNo
    {
        get
        {
            //this line of code send dataout of the property
            return mCarNo;
        }
        set
        {
            //this line of code allows data into propeerty
            mCarNo = value;
        }
    }
    private string mBrandName;
    public string BrandName
    {
        get
        {
            //this line of code send dataout of the property
            return mBrandName;
        }
        set
        {
            //this line of code allows data into propeerty
           mBrandName = value;
        }
    }
    // BarndName private member variable
    private string mModelNAme;
    //Brand Name public property
    public string ModelNAme
    {
        get
        {
            return mModelNAme;
        }
        set
        {
            mModelNAme = value;
        }
    }

    // BarndName private member variable
    private string mColour;
    //Brand Name public operty
    public string Colour
    {
        get
        {
            return mColour;
        }
        set
        {
            mColour = value;
        }
    }

    // BarndName private member variable
    private string mCondition;
    //Brand Name public property
    public string Condition
    {
        get
        {
            return mCondition;
        }
        set
        {
            mCondition = value;
        }
    }

    // BarndName private member variable
    private string mPreviousOwners;
    //Brand Name public property
    public string PreviousOwners
    {
        get
        {
            return mPreviousOwners;
        }
        set
        {
            mPreviousOwners = value;
        }
    }

    // BarndName private member variable
    private string mRegNo;
    //Brand Name public property
    public string RegNo
    {
        get
        {
            return mRegNo;
        }
        set
        {
            mRegNo = value;
        }
    }

    // BarndName private member variable
    private string mMIilesDriven;
    //Brand Name public property
    public string MIilesDriven
    {
        get
        {
            return mMIilesDriven;
        }
        set
        {
            mMIilesDriven = value;
        }
    }

    // BarndName private member variable
    private string mFuelType;
    //Brand Name public property
    public string FuelType
    {
        get
        {
            return mFuelType;
        }
        set
        {
            mFuelType = value;
        }
    }

    // BarndName private member variable
    private string mPrice;
    //Brand Name public property
    public string Price
    {
        get
        {
            return mPrice;
        }
        set
        {
            mPrice = value;
        }
    }

    // BarndName private member variable
    private Boolean mActive;
    //Brand Name public property
    public Boolean Active
    {
        get
        {
            return mActive;
        }
        set
        {
            mActive = value;
        }
    }
    private Int32 mYearCode;
    //Year ode public property
    public Int32 YearCode
    {
        get
        {
            return mYearCode;
        }
        set
        {
            mYearCode = value;
        }
    }

    // BarndName private member variable
    private DateTime mDateAdded;
    //Brand Name public property
    public DateTime DateAdded
    {
        get
        {
            return mDateAdded;
        }
        set
        {
            mDateAdded = value;
        }
    }

    //data member for data connection
    private clsDataConnection dBConnection = new clsDataConnection();


    public string CarValid(
        string BrandName,

       string ModelNAme,
       string Colour,
       string Condition,
      string PreviousOwners,
       string RegNo,
      string MIilesDriven,
       string FuelType,
       string Price,
       string Active)

    { string ErrorMsg;
        ErrorMsg = "";

        if (BrandName.Length < 1 | BrandName.Length > 50)

        {
            //record an error
            ErrorMsg = ErrorMsg + "The BrandName should be between 1 and  50 characters";

        }
        //var to store the error message 
        string ErrMsg = "";
        //check  the min length ofBramd Name
        if (BrandName.Length == 0)
        {
            //set the error message
            ErrMsg = ErrMsg + "BrandName is blank. ";
        }
        //check the max length of the BrandName
        if (BrandName.Length > 50)
        {
            //set the error message
            ErrMsg = ErrMsg + "BrandName must be less than 50 characters";
        }
        //check the min length of ModelNAme
        if (ModelNAme.Length == 0)
        {
            //set the error message
            ErrMsg = ErrMsg + " ModelName is blank";

        }
        //check the max lenth of ModelName
        if (ModelNAme.Length > 50)
        {
            ErrMsg = ErrMsg + " Model Name should be less than 19 chracters";
        }
        //check the min length of Colour
        if (Colour.Length == 0)

        {
            ErrMsg = ErrMsg + " Colour column is blank";

        }
        //check the max length of modelNAme
        if (Colour.Length > 50)
        {
            ErrMsg = ErrMsg + " Colour should be less than 20 characters";
        }
        if (Condition.Length == 0)
        {
            ErrMsg = ErrMsg + "Condition column is blank";
        }
        if (Condition.Length > 50)
        {
            ErrMsg = ErrMsg + " Condition of car should be less than 20 chararacters";

        }
        if (PreviousOwners.Length == 0)
        {
            ErrMsg = ErrMsg + " Previous Owner's column is blank";
        }
        if (PreviousOwners.Length > 100)
        {
            ErrMsg = ErrMsg + "Previous owners cant be that many";

        }
        if (RegNo.Length == 0)
        {
            ErrMsg = ErrMsg + "Reg No is blank";
        }
        if (RegNo.Length > 50)
        {
            ErrMsg = ErrMsg + " Reg No should be less than 10 characters";
        }
        if (MIilesDriven.Length == 0)
        {
            ErrMsg = ErrMsg + "MIiles Driven is blank";
        }
        if (MIilesDriven.Length > 100000)
        {
            ErrMsg = ErrMsg + "MIiles driven cant be that much";
        }
        if (FuelType.Length == 0)
        {
            ErrMsg = ErrMsg + " Fuel Type is empty";
        }
        if (FuelType.Length > 50)
        {
            ErrMsg = ErrMsg + " Fuel Type should be less than 10 characters";
        }
        if (Price.Length == 0)
        {
            ErrMsg = ErrMsg + " Price is empty";
        }
        if (Price.Length > 10000000)
        {
            ErrMsg = ErrMsg + "Price is to big to be entered";
        }
        //test if the datat is valid
        try //try the operation
        {
            //var to store the date
            DateTime Temp;
            Temp = Convert.ToDateTime(DateAdded);
        }
        catch //if it failed report  an aerror
        {
            //set the error message
            ErrMsg = ErrMsg + " Date added is not valid";
        }

        //if there were o errors 
        if(ErrMsg =="")
        {
            //return a blank string
            return "";
        }
        else//otherwise
        {
            //return the errors string value
            return "There were the following errors : " + ErrMsg;
        }


    }

    //function for find public method
    public Boolean Find(Int32 CarNo)
    {

        //initialize th DBConection
        clsDataConnection dBConnection = new clsDataConnection();
        //add the carno parameter
        dBConnection.AddParameter("@CarNo", CarNo);
        //execute the query
        dBConnection.Execute("sproc_tblAvailability_FilterByCarNo");
        //if record was found
        if(dBConnection.Count ==1)
        {
            //get theCarNo
            CarNo = Convert.ToInt32(dBConnection.DataTable.Rows[0]["CarNo"]);
            BrandName = Convert.ToString(dBConnection.DataTable.Rows[0]["BrandName"]);
            ModelNAme = Convert.ToString(dBConnection.DataTable.Rows[0]["ModelName"]);
            Colour = Convert.ToString(dBConnection.DataTable.Rows[0]["Colour"]);
            Condition = Convert.ToString(dBConnection.DataTable.Rows[0]["Condition"]);
            PreviousOwners = Convert.ToString(dBConnection.DataTable.Rows[0]["PreviousOwners"]);
            RegNo = Convert.ToString(dBConnection.DataTable.Rows[0]["RegNo"]);
            MIilesDriven = Convert.ToString(dBConnection.DataTable.Rows[0]["MIilesDriven"]);
            FuelType = Convert.ToString(dBConnection.DataTable.Rows[0]["FuelType"]);
          Price = Convert.ToString(dBConnection.DataTable.Rows[0]["Price"]);
            YearCode = Convert.ToInt32(dBConnection.DataTable.Rows[0]["YearCode"]);
            DateAdded = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["DateAdded"]);
            try
            {
                mActive = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["Active"]);
            }
            catch
            {
                mActive = true;
            }
            //return success
            return true;


        }
        else
        {
            //return failure
            return false;
        }
       


    }
   
}
