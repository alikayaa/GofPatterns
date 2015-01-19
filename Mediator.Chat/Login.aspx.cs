using Mediator.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mediator.Chat
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Contact mySelf = new Contact(txtLogin.Text);
            MediatorHelper.Instance().ChatRoom.Register(mySelf);
            Session["User"] = mySelf;
            Response.Redirect("ChatRoom.aspx");

        }
    }
}