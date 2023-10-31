using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class Solution : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize the DropDownList
                ddlCars.SelectedIndex = 0;
            }
        }

        protected void ddlCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load the corresponding image when a car is selected
            string selectedCar = ddlCars.SelectedValue;
            switch (selectedCar)
            {
                case "sedan":
                    imgCar.ImageUrl = "Images/sedan/BMW 5 Series.jpg"; // Relative path to the image
                    break;
                case "suv":
                    imgCar.ImageUrl = "Images/SUV/Mahindra Thar.jpg"; // Relative path to the image
                    break;
                case "sports":
                    imgCar.ImageUrl = "Images/Sports Car/Mustang.jpg"; // Relative path to the image
                    break;
                default:
                    imgCar.ImageUrl = ""; // Clear the image
                    break;
            }
        }

        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            // Display the cost of the selected car
            string selectedCar = ddlCars.SelectedValue;
            string cost = "";
            switch (selectedCar)
            {
                case "sedan":
                    cost = "5000000.";
                    break;
                case "suv":
                    cost = "2500000.";
                    break;
                case "sports":
                    cost = "10000000.";
                    break;
                default:
                    cost = "0.";
                    break;
            }
            lblCost.Text = "Cost: " + cost;
        }
    }
}
