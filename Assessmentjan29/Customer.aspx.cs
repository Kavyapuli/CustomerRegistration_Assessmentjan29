using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assessmentjan29
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            LblMsg.Visible = false;
            Page.UnobtrusiveValidationMode=UnobtrusiveValidationMode.None;
        }

        protected void BtnReg_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                LblMsg.Visible=true;
                LblMsg.Text = "Customer Name: " + TxtName.Text;
                LblMsg.Text+="<br/> Moile Number: "+TxtMobile.Text;
                LblMsg.Text += "<br/>Email: " + TxtEmail.Text;
                LblMsg.Text += "<br/>Password: " + TxtPassword.Text;
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string name = args.Value.Trim();
            args.IsValid = (name.Length >= 6);
        }

        protected void TxtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}