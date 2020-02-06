using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartCore
{
    public class Seller
    {
        public string name, password, emailid, companyname, briefabtcmpy, address, website;
        public long mobileno;
        public int GST;
        public int id;
        public Seller(int id,string name, string password, string emailid, long mobileno, string companyname, string briefabtcmpy, string address, string website, int GST)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.emailid = emailid;
            this.mobileno = mobileno;
            this.companyname = companyname;
            this.briefabtcmpy = briefabtcmpy;
            this.address = address;
            this.website = website;
            this.GST = GST;
        }
    }
}
