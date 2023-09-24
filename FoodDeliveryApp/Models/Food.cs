using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Models
{
    public class Food
    {
        public string Title { get; set; }
        public string Cover { get; set; }
        public double Rating { get; set; }
        public string Summary { get; set; }
        public IEnumerable<string> Categories { get; set; }
        public IEnumerable<Ingridients> Ingridients { get; set; }
    }
}
