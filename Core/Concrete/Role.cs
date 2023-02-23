using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete
{
    //This Role table is gonna store the roles we need for Role Base Authentication
    public class Role:IEntity
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
