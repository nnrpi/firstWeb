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
            var collection = db.GetCollection<User>("users");
            List<User> users = new List<User>();
            users = collection.FindSync(FilterDefinition<User>.Empty).ToList();
            int c = users.Count();
            int a = 9;
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2] {
                new DataColumn("Name", typeof(string)),
                new DataColumn("Surname", typeof(string)) }
            );
            foreach (User user in users)
            {
                dt.Rows.Add(user.name, user.surname);
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("<table>");
            sb.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                sb.Append("<th>" + column.ColumnName + "</th>");
            }
            sb.Append("</tr>");
            foreach (DataRow row in dt.Rows)
            {
                sb.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    sb.Append("<td>" + row[column.ColumnName].ToString() + "</td>");
                }
                sb.Append("</tr>");
            }
            sb.Append("</table");
            dbTable.Text = sb.ToString();
        }
    }
}