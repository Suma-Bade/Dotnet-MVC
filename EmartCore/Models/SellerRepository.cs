using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartCore.Models
{
    public class SellerRepository:ISellerRepository
    {
        public List<Seller> sellerlist;
        public SellerRepository()
        {
            sellerlist = new List<Seller>() { new Seller(1,"josh","1234","js123@gmail.com",9122334455,"cts","good","chennai","cts.com",234556),
                                           new Seller(2,"rama","123456","rama123@gmail.com",9122334875,"tcs","excellent","Hyde","tcs.com",298556),
            new Seller(3,"sita","45234","sita123@gmail.com",9234558455,"infosys","super","Bangalore","infy.com",2987556)
            };
        }
        public Seller GetSeller(int id)
        {
            Seller s = sellerlist.FirstOrDefault(s => s.id == id);
            return s;
        }
    }
}
