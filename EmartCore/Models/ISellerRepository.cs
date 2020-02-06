using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartCore.Models
{
   public  interface ISellerRepository
    {
        Seller GetSeller(int id);
        List<Seller> DisplayDetails();
    }
}
