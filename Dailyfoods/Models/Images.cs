using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dailyfoods.Models
{
    public class Images
    {
       
        public Guid id { get; set; }
     
        public string filename { get; set; }
        public string extension { get; set; }
        public Product product { get; set; }

        public virtual int ProductID { get; set; }

    }
}