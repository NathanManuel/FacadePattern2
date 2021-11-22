using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern2
{
    class HotelKeeper
    {
        private IHotel vegMenu;
        private IHotel nonVegMenu;
        private IHotel bothMenu;

        public HotelKeeper()
        {
            vegMenu = new VegRestaurant();
            nonVegMenu = new NonVegRestaurant();
            bothMenu = new BothRestaurant();
        }
        public void getVegMenu()
        {
            vegMenu.getMenus();
        }

        public void getNonVegMenu()
        {
            nonVegMenu.getMenus();
        }

        public void getBothMenu()
        {
            bothMenu.getMenus();
        }
    }
}
