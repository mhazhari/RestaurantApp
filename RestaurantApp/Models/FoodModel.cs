using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class FoodModel
    {
        public string FoodName { get; set; }
        public decimal FoodPrice { get; set; }
        public string FoodDescription { get; set;}
        public string ImagePath { get; set;}
        public bool IsFavorite { get; set; } = false;
    }
}
