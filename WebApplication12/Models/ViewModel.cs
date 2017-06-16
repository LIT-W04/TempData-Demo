using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication12.Models
{
    public class ViewModel
    {
        public int ViewCount { get; set; }
        public MyClass MyClass { get; set; }
    }

    public class MyClass
    {
        public int RandomNumber { get; set; }
    }
}