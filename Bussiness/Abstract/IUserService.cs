using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //I define the interface we need for User stuff 
    public interface IUserService
    {
        List<Role> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
