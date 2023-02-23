using Core.Concrete;
using Core.DataAccess;
using Core.DataAccess.Repositories;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EfDals
{
    public class EfUserDal : GenericRepository<User, MoviePickerContext>, IUserDal
    {
        public List<Role> GetClaims(User user)
        {
            using (var context = new MoviePickerContext())
            {
                var result = from role in context.Role
                             join userRolePairing in context.UserRolePairing
                                 on role.RoleId equals userRolePairing.Id
                             where userRolePairing.UserId == user.UserId
                             select new Role { RoleId = role.RoleId, RoleName = role.RoleName };
                return result.ToList();

            }
        }
    }
}
