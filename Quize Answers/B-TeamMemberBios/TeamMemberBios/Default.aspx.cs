using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeamMemberBios
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 1)
            {
                ImgPlayers.ImageUrl= "/images/jonas.png";
                LblName.Text = "Jonas Valanciunas";
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                ImgPlayers.ImageUrl = "/images/og.png";
                LblName.Text = "OG Anunoby";
            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                ImgPlayers.ImageUrl = "/images/kyle.png";
                LblName.Text = "Kyle Lowry";
            }
            else if (DropDownList1.SelectedIndex==4)
            {
                ImgPlayers.ImageUrl = "/images/serge.png";
                LblName.Text = "Serge Ibaka";
            }
        }
    }
}