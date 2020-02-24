using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dailyfoods.Models;
using Dailyfoods.Controllers;

namespace Dailyfoods.Viewmodel
{
    public class AddProductViewmodel
    {
        public Product products { get; set; }
        public IEnumerable<category> category_list { get; set; }
        public ICollection<Images> images { get; set; }
      
        public category category { get; set; }
        
    }

}