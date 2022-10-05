using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdToFood.Data.Models
{
    public class Restuarant
    {   
        public int Id { get; set; }
        public string Name { get; set; }

        public CusineType Cuisine { get; set; }
    }
}
