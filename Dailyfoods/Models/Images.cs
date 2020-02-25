using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Dailyfoods.Models
{
    public class Images
    {


        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid id { get; set; }
        public string filename { get; set; }
        public string extension { get; set; }
        public Product product { get; set; }

        public virtual int ProductID { get; set; }

    }
}