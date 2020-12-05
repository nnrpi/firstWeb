using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using MongoDB.Bson;

namespace firstWeb
{
    public class User
    {
        public ObjectId _id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
    }
}