using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaStore
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnPurchase_Click(object sender, EventArgs e)
        {
            double total = 0;
            double size = 0;
            double type = 0;
            double toppings=0;

            if (RdoBaby.Checked==true)
            {
                size += 10.00;
            }
            else if (RdoMama.Checked==true)
            {
                size += 13.00;
            }
            else if (RdoPapa.Checked==true)
            {
                size += 16.00;
            }

            if (RdoThin.Checked==true)
            {
                type += 0;
            }
            else if (RdoDeep.Checked==true)
            {
                type += 2.00;
            }

            if (ChkPepperoni.Checked==true)
            {
                toppings += 1.50;
            }
            if (ChkOnions.Checked == true)
            {
                toppings += 0.75;
            }
            if (ChkGreen.Checked == true)
            {
                toppings += 0.50;
            }
            if (ChkRed.Checked == true)
            {
                toppings += 0.75;
            }
            if (ChkAnchovies.Checked == true)
            {
                toppings += 2.00;
            }

            total = size + type + toppings;

            if ((ChkPepperoni.Checked==true && ChkGreen.Checked==true && ChkAnchovies.Checked==true)
                || (ChkPepperoni.Checked==true && ChkRed.Checked==true && ChkOnions.Checked==true))
            {
                total -= 2.00;
            }

            LblTotal.Text = total.ToString("c");
        }
    }
}