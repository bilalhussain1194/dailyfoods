using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dailyfoods.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int qty { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public int special_price { get; set; }
        public DateTime date_from { get; set; }
        public DateTime date_to { get; set; }
        public DateTime created_date { get; set; }
        public string sku { get; set; }
        public category Category { get; set; }
        public int Categoryid { get; set; }
        public virtual ICollection<Images> images { get; set; }

    }
}