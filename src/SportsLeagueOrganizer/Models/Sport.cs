using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsLeagueOrganizer.Models
{
    [Table("Sports")]
    public class Sport
    {
        [Key]
        public int SportId { get; set; }
        public string Name { get; set; }
    }
}
