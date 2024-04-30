using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public class CategoryModel
    {
        public string CategoryName { get; set; }
        public List<FoodModel> Foods { get; set; }=new List<FoodModel>();
    }
}
