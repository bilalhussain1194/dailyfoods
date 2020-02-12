using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dailyfoods.Models
{
    public class Images
    {
        public int id { get; set; }
     
        public string img_path { get; set; }
        public Product product { get; set; }
        public int productid { get; set; }

    }
}