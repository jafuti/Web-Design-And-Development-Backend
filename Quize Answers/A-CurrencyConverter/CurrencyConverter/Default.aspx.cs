using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurrencyConverter
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack==false)
            {
                //Gentle Version
                DropDownCurrency.Items.Add("US");
                DropDownCurrency.Items.Add("Euro");
                DropDownCurrency.Items.Add("Yen");

                //Slightly more advance version
                //usually just use DropDownCurrency.Items.Add()
                //... BUT  to set the VALUE attribute you need to 
                // create a ListItem ojbect for every item
                //DropDownCurrency.Items.Add(new ListItem("US",".77"));
                //DropDownCurrency.Items.Add(new ListItem("Euro",".63"));
                //DropDownCurrency.Items.Add(new ListItem("Yen","81.52"));

                ImgGraph.Visible = false; //will hold a Canada vs Country graph of curreny trend
            }
        }

        protected void BtnOK_Click(object sender, EventArgs e)
        {
            decimal CanadaAmount; //slightly different than the "double" format

            
            //attempt conversion
            bool success = Decimal.TryParse(TxtCanada.Text, out CanadaAmount);

            //Check if it succeeded .. we only want positive decimals
            if ( (CanadaAmount <=0) || (!success))
            {

                //conversion failed

                //Controls have access to the CSS attributes through its
                //Style collection. 

                LblResult.Style["color"] = "Red";
                LblResult.Text = "The number you typed in was not in the correct format. Use only numbers";
                
            }
            else
            {
                LblResult.Style["color"] = "Black";

                //Gentle Version
                if (DropDownCurrency.Text=="US")
                {
                    decimal USAmount = CanadaAmount * .77M;
                    LblResult.Text = CanadaAmount.ToString("c") + " Canadian Dollars equals " +
                        USAmount.ToString() + " " + DropDownCurrency.Text;
                }
                else if (DropDownCurrency.Text=="Euro")
                {
                    decimal EuroAmount = CanadaAmount * .63M;
                    LblResult.Text = CanadaAmount.ToString("c") + " Canadian Dollars equals " +
                        EuroAmount.ToString() + " " + DropDownCurrency.Text;
                }
                else if (DropDownCurrency.Text=="Yen")
                {
                    decimal YenAmount = CanadaAmount * 81.52M;
                    LblResult.Text = CanadaAmount.ToString("c") + " Canadian Dollars equals " +
                        YenAmount.ToString() + " " + DropDownCurrency.Text;
                }


                //Slightly more advanced version

                //ListItem item = DropDownCurrency.Items[DropDownCurrency.SelectedIndex];

                //Simple calculation if only converting Canada to US
                //... But once DropDown introduced ... program becomes more
                //useful but obviously more complex.. BUT now it will work with basically
                //the same amount of SMALL code for any situation.
                             
                
                //decimal ConvertedAmount = CanadaAmount * Decimal.Parse(item.Value);

                //LblResult.Text = CanadaAmount.ToString("c") + " Canadian Dollars equals " + ConvertedAmount.ToString() + " " + item.Text;
                
            }
        }

        protected void BtnGraph_Click(object sender, EventArgs e)
        {
            //made sure each graph was called "chart" + number
            ImgGraph.ImageUrl = "/images/" + "chart" + DropDownCurrency.SelectedIndex.ToString() + ".gif";
            ImgGraph.Visible = true;
        }
    }
}