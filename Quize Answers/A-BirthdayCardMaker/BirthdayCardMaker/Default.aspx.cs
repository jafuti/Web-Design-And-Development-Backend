using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BirthdayCardMaker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)//same as Page.IsPostBack
            {
                // Set color options.
                lstBackColor.Items.Add("White");
                lstBackColor.Items.Add("Red");
                lstBackColor.Items.Add("Green");
                lstBackColor.Items.Add("Blue");
                lstBackColor.Items.Add("Yellow");
                
                // Set font options.
                lstFontName.Items.Add("Times New Roman");
                lstFontName.Items.Add("Arial");
                lstFontName.Items.Add("Verdana");
                lstFontName.Items.Add("Tahoma");
                                                
                // Set the picture but don't show it initially.
                imgDefault.ImageUrl = "images/birthdaycake.png";
                imgDefault.Visible = false;
            }
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            // Update the color.
            pnlCard.BackColor = Color.FromName(lstBackColor.Text);
            
            // Update the font.
            lblGreeting.Font.Name = lstFontName.Text;
            if (int.Parse(txtFontSize.Text) > 0)
            {
                lblGreeting.Font.Size =
                FontUnit.Point(int.Parse(txtFontSize.Text));
            }
            
            // Update the picture.
            if (chkPicture.Checked)
            {
                imgDefault.Visible = true;
            }
            else
            {
                imgDefault.Visible = false;
            }
            // Set the text.
            lblGreeting.Text = txtGreeting.Text;
        }
    }
}