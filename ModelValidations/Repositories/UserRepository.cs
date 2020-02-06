using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelValidations.Models;

namespace ModelValidations.Repositories
{
    public class UserRepository
    {
        public static List<User> list=new List<User>(){new User()
         {
                Name = "roshi",
                Country = "Us",
                Uname = "roshi123",
                Pwd = "1234"
            }

         
        };
        public void Add(User item)
        {
            list.Add(item);
        }
        public User Validate(string uname,string pwd)
        {
            foreach(var item in list)
            {
                if(item.Uname==uname&&item.Pwd==pwd)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
