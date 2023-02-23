using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Movies:IEntity
    {
        
        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        [MaxLength(4)]//2023 ,1976 vs.
        public string ShootingYear { get; set; }
        public string Time { get; set; }
        [MaxLength(5)]//10.0,6.4
        public string IMDb { get; set; }
        public Categories Categories { get; set; }


    }
}
