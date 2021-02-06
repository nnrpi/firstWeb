using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace firstWeb
{
    public class Food
    {
        public ObjectId _id { get; set; }
        public string dish { get; set; }
        public string owner { get; set; }
    }
}