using OdToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdToFood.Data.Services
{
    public class InMemoryRestuarantData : IRestuarantData
    {
        List<Restuarant> restuarants;
        public InMemoryRestuarantData(){
           
            restuarants = new List<Restuarant>()
            {
                new Restuarant{Id=1, Name="Muluken Shiro", Cuisine=CusineType.Ethiopian},
                new Restuarant{Id=2, Name="Royal Indian", Cuisine=CusineType.Indian},
                new Restuarant{Id=3, Name="Milan Cafe", Cuisine=CusineType.Italian},
            };
        }
        
        
        public IEnumerable<Restuarant> GetAll()
        {
            return restuarants.OrderBy(r => r.Name);
        }
    }
}
