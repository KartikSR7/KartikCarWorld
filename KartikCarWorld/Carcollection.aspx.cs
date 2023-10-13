using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Carcollection : System.Web.UI.Page
{
    Int32 CarNo;
    protected void Page_Load(object sender, EventArgs e)
    {


        //get the cars from the session object
        CarNo = Convert.ToInt32(Request.QueryString["CarNo"]);
        if (IsPostBack == true)
        {

            //populate the YearManufactured drop down
            DisplayYears();
            //if we are not adding new year
            if (CarNo != -1)

            {
                //update the fields on the page with the dat from the record
                DisplayCars(CarNo);
            }

        }
    }

    void DisplayCars(Int32 CarNo)
    {
        //create an instance of the car class
        clsCars MyKartikCarWorld = new clsCars();
        //find the rcord to display
        MyKartikCarWorld.Find(CarNo);
        //dispalythe BrandName
        txtBrandName.Text = MyKartikCarWorld.BrandName;
        txtModelNAme.Text = MyKartikCarWorld.ModelNAme;
        txtColour.Text = MyKartikCarWorld.Colour;
        txtCondition.Text = MyKartikCarWorld.Condition;
        txtPreviousOwners.Text = MyKartikCarWorld.PreviousOwners;
        txtRegNo.Text = MyKartikCarWorld.RegNo;
        txtMIilesDriven.Text = MyKartikCarWorld.MIilesDriven;
        txtFuelType.Text = MyKartikCarWorld.FuelType;
        txtPrice.Text = MyKartikCarWorld.Price;
        chkActive.Checked = MyKartikCarWorld.Active;
        ddlYearManufactured.SelectedValue = Convert.ToString(MyKartikCarWorld.YearCode);
        txtDateAdded.Text = MyKartikCarWorld.DateAdded.ToString("dd/MM/yyyy");

    }





    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create an instance of  the address page class
        clsCars ThisCars = new clsCars();
        //var to store the error message 
        string ErrorMessage;
        //test the daT on the web form
        ErrorMessage = ThisCars.CarValid(txtBrandName.Text,
            txtModelNAme.Text,
            txtColour.Text,
            txtCondition.Text,
            txtPreviousOwners.Text,
            txtRegNo.Text,
            txtMIilesDriven.Text,
            txtFuelType.Text,
            txtPrice.Text,
            txtDateAdded.Text
            );
        if (ErrorMessage == "")
        {
            //create a new instance of the address book class 
            clsCarCollection AddressBook = new clsCarCollection();
            //do something with the data --insert or update
            //
            //if the Address Number is -1
            if (CarNo == -1)
            {
                //copy the data from the inteference to the object
                ThisCars.BrandName = txtBrandName.Text;
                ThisCars.ModelNAme = txtModelNAme.Text;
                ThisCars.Colour = txtColour.Text;
                ThisCars.Condition = txtCondition.Text;
                ThisCars.PreviousOwners = txtPreviousOwners.Text;
                ThisCars.RegNo = txtRegNo.Text;
                ThisCars.MIilesDriven = txtMIilesDriven.Text;
                ThisCars.FuelType = txtFuelType.Text;
                ThisCars.Price = txtPrice.Text;

                ThisCars.YearCode = Convert.ToInt32(ddlYearManufactured.SelectedValue);
                ThisCars.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                //add the new record
                AddressBook.Add();
            }
            else
            {
                //this is an existing record
                //copy the data from the interface to the object
                ThisCars.CarNo = Convert.ToInt32(CarNo);
                ThisCars.BrandName = txtBrandName.Text;
                ThisCars.ModelNAme = txtModelNAme.Text;
                ThisCars.Colour = txtColour.Text;
                ThisCars.Condition = txtCondition.Text;
                ThisCars.PreviousOwners = txtPreviousOwners.Text;
                ThisCars.RegNo = txtRegNo.Text;
                ThisCars.MIilesDriven = txtMIilesDriven.Text;
                ThisCars.FuelType = txtFuelType.Text;
                ThisCars.Price = txtPrice.Text;
                ThisCars.YearCode = Convert.ToInt32(ddlYearManufactured.SelectedValue);
                ThisCars.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                //update the existing record
                AddressBook.Update();


            }

            //Do something with  data(innsert or update)
            Response.Redirect("Default.aspx");


        }
        else
        {
            //display the error message
            lblError.Text = ErrorMessage;
        }

        

    }


    Int32 DisplayYears()
    {
        //create an instance of the county class
        clsYearCollection Years = new clsYearCollection();
        //var to store the county number primary key
        String YearNo;
        //var to store the name of the county
        String Year;
        //var to store the index for the loop
        Int32 Index = 0;
        //while the index is less that the number of records to process
        while (Index < Years.Count)
        {
            //get the county number from the database
            YearNo = Convert.ToString(Years.AllYears[Index].YearNo);
            //get teh county name from the database
            Year = Years.AllYears[Index].Year;
            //set up the new row to be added to the list
            ListItem NewYear = new ListItem(Year, YearNo);
            //add the new row to the list
            ddlYearManufactured.Items.Add(NewYear);
            //increment the index to the next record
            Index++;
        }
        //return the number of records found
        return Years.Count;
    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
