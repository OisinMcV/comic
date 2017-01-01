using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTest.Models
{
    public class Photo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string caption { get; set; }
        public string imageFileName
        {
            get
            {
                return "banner" + id + ".svg";
            }
        }
    }
}
