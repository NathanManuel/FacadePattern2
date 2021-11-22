using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern2
{
    class NonVegRestaurant : IHotel
    {
        public void getMenus()
        {
            Console.WriteLine("These are the non vegetarian menues!!");
        }
    }
}
