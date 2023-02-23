using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete
{
    //In passworHash and passwordSalt columns will store the users password encrypted way
    public class User:IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordSalt  { get; set; }
        public byte[] PasswordHash  { get; set; }
        public bool Status { get; set; }
    }
}
