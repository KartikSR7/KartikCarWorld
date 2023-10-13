using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    Int32 CarNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //copy the data from the query string to the variable
        CarNo = Convert.ToInt32(Request.QueryString["CarNo"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCarCollection MyKartikCarWorld = new clsCarCollection();
        //find the record to be deleted

        //declare a boolean variable found
        Boolean Found;
        //try and find the record to delete 
        Found = MyKartikCarWorld.ThisCars.Find(CarNo);
        //if the record was found
        if (Found)
        {
            //innvoke the delete method of the object
            MyKartikCarWorld.Delete();
        }
        Response.Redirect("Default.aspx");
    
      
    }
    // else //display an error message
    // {
    //display a messagew concatenating the text an d data in the variable 
    // lblError.Text = "There was a problem deleting the record.";

    // MyKartikCarWorld.Delete(CarNo);



    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}
