using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsLeagueOrganizer.Models
{
    [Table("Teams")]
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        public int DivisionId { get; set; }
        public int Captain { get; set; }
        public int SportId { get; set; }

        [ForeignKey("DivisionId")]
        public virtual Division Division { get; set; }

        [ForeignKey("Captain")]
        public virtual Player Player { get; set; }

        [ForeignKey("SportId")]
        public virtual Sport Sport { get; set;}

        public virtual ICollection<Affiliation> Affiliations { get; set; }
    }
}
