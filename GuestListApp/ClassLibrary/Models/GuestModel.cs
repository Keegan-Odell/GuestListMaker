using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Enums;

namespace ClassLibrary.Models
{
    public class GuestModel
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public SteakOrChicken Meal { get; set; }
    }
}
