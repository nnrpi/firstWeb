using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Driver;
using MongoDB.Bson;

namespace firstWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        IMongoDatabase db;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void buttonSignInOnClick(object sender, EventArgs e)
        {
            SignInLabel.Visible = true;
            ButtonNext.Visible = true;
        }
    }
}