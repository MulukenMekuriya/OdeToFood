using OdToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdToFood.Data.Services
{
    public interface IRestuarantData
    {
        IEnumerable<Restuarant> GetAll();
    }
}
