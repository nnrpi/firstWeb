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
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            db = client.GetDatabase("newYear");
        }

        protected void buttonSignInOnClick(object sender, EventArgs e)
        {
            var collection = db.GetCollection<User>("users");
            string Name = textName.Text;
            string Surname = textSurname.Text;
            User user = new User { name = Name, surname = Surname };
            collection.InsertOne(user);
            signInLabel.Visible = true;
            buttonNext.Visible = true;
            buttonSignIn.Visible = false;
        }
    }
}