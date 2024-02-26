using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Methods
{
    public class ListGuestMethod
    {
        public static void ListGuests(List<GuestModel> partyList)
        {
            foreach (GuestModel guest in partyList)
            {
                Console.WriteLine($"{guest.Name} is {guest.Age} years old and for dinner they want {guest.Meal}");
            }
        }
    }
}
