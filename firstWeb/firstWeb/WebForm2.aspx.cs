using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;

namespace firstWeb
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        IMongoDatabase db;
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "mongodb://admin:5TJpSE@contester.ddns.is74.ru:27017/test?authSource=admin&readPreference=primary&appname=MongoDB%20Compass&ssl=false";
            MongoClient client = new MongoClient(connectionString);
            db = client.GetDatabase("newYear");


            var colUsers = db.GetCollection<User>("users");
            List<User> users = new List<User>();
            users = colUsers.FindSync(FilterDefinition<User>.Empty).ToList();
            TableHeaderRow thr = new TableHeaderRow();
            TableHeaderCell thcName = new TableHeaderCell();
            TableHeaderCell thcSurname = new TableHeaderCell();
            thcName.Text = "Name";
            thcSurname.Text = "Surname";
            thr.Cells.Add(thcName);
            thr.Cells.Add(thcSurname);
            tableUsers.Rows.Add(thr);
            foreach(User user in users)
            {
                TableCell tcName = new TableCell();
                TableCell tcSurname = new TableCell();
                tcName.Text = user.name;
                tcSurname.Text = user.surname;
                TableRow tr = new TableRow();
                tr.Cells.Add(tcName);
                tr.Cells.Add(tcSurname);
                tableUsers.Rows.Add(tr);
            }


            var colFood = db.GetCollection<Food>("food");
            List<Food> food = new List<Food>();
            food = colFood.FindSync(FilterDefinition<Food>.Empty).ToList();
            TableHeaderRow thrFood = new TableHeaderRow();
            TableHeaderCell thcDish = new TableHeaderCell();
            TableHeaderCell thcOwner = new TableHeaderCell();
            thcDish.Text = "Dish";
            thcOwner.Text = "Owner";
            thrFood.Cells.Add(thcDish);
            thrFood.Cells.Add(thcOwner);
            tableFood.Rows.Add(thrFood);
            foreach (Food f in food)
            {
                TableCell tcDish = new TableCell();
                TableCell tcOwner = new TableCell();
                tcDish.Text = f.dish;
                tcOwner.Text = f.owner;
                TableRow tr = new TableRow();
                tr.Cells.Add(tcDish);
                tr.Cells.Add(tcOwner);
                tableFood.Rows.Add(tr);
            }
        }

        protected void leaveButtonOnClick(object sender, EventArgs e)
        {
            var colUsers = db.GetCollection<User>("users");
            var colFood = db.GetCollection<Food>("food");
            string Name = Session["userName"].ToString();
            string Surname = Session["userSurname"].ToString();
            string Owner = Name + " " + Surname;
            var deleteFilterUsers = Builders<User>.Filter.Eq("name", Name) & Builders<User>.Filter.Eq("surname", Surname);
            var deleteFilterFood = Builders<Food>.Filter.Eq("owner", Owner);
            colUsers.FindOneAndDelete(deleteFilterUsers);
            colFood.DeleteMany(deleteFilterFood);
            Response.Redirect("Webform1.aspx");
        }

        protected void addFoodButtonOnClick(object sender, EventArgs e)
        {
            var collection = db.GetCollection<Food>("food");
            string Name = Session["userName"].ToString();
            string Surname = Session["userSurname"].ToString();
            string Owner = Name + " " + Surname;
            string Dish = textAddFood.Text;
            Food newFood = new Food { dish = Dish, owner = Owner };
            collection.InsertOne(newFood);
            TableRow tr = new TableRow();
            TableCell tc1 = new TableCell();
            TableCell tc2 = new TableCell();
            tc1.Text = Dish;
            tc2.Text = Owner;
            tr.Cells.Add(tc1);
            tr.Cells.Add(tc2);
            tableFood.Rows.Add(tr);
        }
    }
}