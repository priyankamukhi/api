using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{

    public class marksheetController : ApiController
    {
        

        marksheet[] marksheets = new marksheet[]
        {
new marksheet{id=1,name="priya",rollno=1,maths=10,english=9,hindi=9,science=8,computer=10,marks=46,totalmarks=50},
new marksheet{id=2,name="sumit",rollno=2,maths=10,english=10,hindi=9,science=8,computer=10,marks=47,totalmarks=50}
        };

        public IEnumerable<marksheet> Getallmarksheets()
        {
            return marksheets;
            
        }
    }
}
