using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete
{
    public class Movie:IEntity
    {
        
        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string ShootingYear { get; set; }
        [MaxLength(4)]//10.0,6.4

        public string Time { get; set; }
        public double IMDb { get; set; }
        public int CategoryId { get; set; }
    }
}
