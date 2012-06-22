using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SGFoodSnap
{
    class Food
    {
        public String Name { get; set; }
        public String Image { get; set; }

        public Food(String name, String image)
        {
            this.Name = name;
            this.Image = image;
        }
    }
}
