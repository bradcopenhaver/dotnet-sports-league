using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsLeagueOrganizer.Models
{
    [Table("Affiliations")]
    public class Affiliation
    {
        [Key]
        public int AffiliationId { get; set; }
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }
        [ForeignKey("PlayerId")]
        public virtual Player Player { get; set; }

    }
}
