using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDelivery.Data
{
    public class DishType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // 1:M
        public ICollection<Dish> Dishes { get; set; }

    }
}
