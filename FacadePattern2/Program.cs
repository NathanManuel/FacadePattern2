using System;

namespace FacadePattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelKeeper hotelKeeper = new HotelKeeper();

            hotelKeeper.getVegMenu();
            hotelKeeper.getNonVegMenu();
            hotelKeeper.getBothMenu();
        }
    }
}
