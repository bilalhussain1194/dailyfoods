using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dailyfoods.Models;

namespace Dailyfoods.Viewmodel
{
    public class AddProductViewmodel
    {
        public Product products { get; set; }
        public IEnumerable<category> category_list { get; set; }
        public Images images { get; set; }
        public category category { get; set; }
    }
}