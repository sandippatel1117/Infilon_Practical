using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical.Models
{
    public class User
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}