using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Models;

namespace ClassLibrary.Methods
{
    public class WriteTxtFileMethod
    {
        public static void exportPartyList(List<GuestModel> partyList)
        {
            string filePath =
                @"C:\Users\odellkc\OneDrive - Daikin Applied Americas\Documents\TimCoreyC#\TestTXTExport\party.txt";
            string content = "";

            foreach (GuestModel guest in partyList)
            {
                string contentAdd = $"{guest.Name} is {guest.Age} years old and for dinner they want {guest.Meal}.\n";
                content += contentAdd;
            }

            try
            {
                File.WriteAllText(filePath, content);
                Console.WriteLine("File successfully created!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
