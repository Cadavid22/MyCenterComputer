using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterComputer.Shared.Entities
{
    public class MyCenterComputer
    {
        public int Id { get; set; } 
        public string Type { get; set; } = null!; 

        public string Brand { get; set; } = null!; 

        public string Name { get; set; } = null!; 

        public string LastName { get; set; } = null!; 

        public int Phone { get; set; } 

        public string Email { get; set; } = null!;      

        [Required]
        public string Diagnosis { get; set; } = null!; 

        [Required]
        public string Coments { get; set; } = null!; 

        public string Status { get; set; } = null!; 

        [Required]
        public decimal Value { get; set; } 

        public DateTime DateStarted { get; set; } 

        public DateTime DateFinished { get; set; } 
    }
}
