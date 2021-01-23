using System;
using System.Configuration;
using System.Data;
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
            string connectionString = "mongodb://admin:5TJpSE@contester.ddns.is74.ru:27017/test?authSource=admin&readPreference=primary&appname=MongoDB%20Compass&ssl=false";
            MongoClient client = new MongoClient(connectionString);
            db = client.GetDatabase("newYear");
        }

        protected void buttonSignInOnClick(object sender, EventArgs e)
        {
            var collection = db.GetCollection<User>("users");
            string Name = textName.Text;
            string Surname = textSurname.Text;
            Session["userName"] = Name;
            Session["userSurname"] = Surname;
            User user = new User { name = Name, surname = Surname };
            collection.InsertOne(user);
            signInLabel.Visible = true;
            buttonNext.Visible = true;
            buttonSignIn.Visible = false;
        }

        protected void buttonNextOnClick(object sender, EventArgs e)
        {
            Response.Redirect("Webform2.aspx");
        }
    }
}