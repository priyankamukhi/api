using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class marksheet
    {
        public int id { get; set; }
        public string name { get; set; }
        public int rollno { get; set;}
        public int maths { get; set; }
        public int english { get; set; }
        public int hindi { get; set; }
        public int science { get; set; }
        public int computer { get; set; }
        public int marks { get; set; }
        public int totalmarks { get; set; }



    }
}