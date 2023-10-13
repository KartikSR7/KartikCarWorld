using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first apperance of the form
        if (IsPostBack == false)
        {
            //display all cars
            DisplayCars("");
        }
    }

  

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("CarCollection.aspx?CarNo=-1");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to stroe the primary key
        Int32 CarNo;
        //check the list has been clicked first
        if(lstCars.SelectedIndex != -1)
        {
            //get the primary key value from the list box
            CarNo = Convert.ToInt32(lstCars.SelectedValue);
            //redirect to the edtiing car detals page
            Response.Redirect("CarCollection.aspx?CarNo=" +CarNo);
        }
        else
        {
            //display an error
            lblError.Text = "Please select a car to edit its details";
        }
    }

    protected void btnlookfor_Click(object sender, EventArgs e)
    {
        // declare var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayCars(txtBrandName.Text);
        //display the number of records found
        lblError.Text = RecordCount + " records found";
        
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        DisplayCars("");
       


    }
    Int32 DisplayCars(string BrandNameFilter)
    {
        //declare the variable

        Int32 CarNo;//var to store the PK
        string BrandName;
        string ModelNAme;
        //create an instance of the Brand Name
        clsCarCollection CarCollection = new clsCarCollection();

       CarCollection.FilterByBrandName(BrandNameFilter);

        Int32 RecordCount; // var to otre the count of records
        Int32 Index = 0; // var to store index for the loop
        RecordCount = CarCollection.Count;

        lstCars.Items.Clear();
        while (Index < RecordCount)// while there are records to process
        {
            CarNo = CarCollection.BrandNameList[Index].CarNo;
            BrandName = CarCollection.BrandNameList[Index].BrandName;
            ModelNAme = CarCollection.BrandNameList[Index].ModelNAme;
            //create an entry for the list box
            ListItem NewEntry = new ListItem(BrandName + " " + ModelNAme, CarNo.ToString());
            lstCars.Items.Add(NewEntry); // add address to the List
            Index++; // move the index to next record
        }
        return RecordCount;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        Int32 CarNo;

        //check the list has been clicked first
        if(lstCars.SelectedIndex != -1)
            {
            //get the PK value from the listbox
            CarNo = Convert.ToInt32(lstCars.SelectedIndex);
            //redirect  to the edditting page
            Response.Redirect("Delete.aspx?CarNo=" + CarNo);
        }
        else{
            //display a error to theuser
            lblError.Text = "You must select Car to edit it's details";

        }
    }

    protected void lstCars_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
    