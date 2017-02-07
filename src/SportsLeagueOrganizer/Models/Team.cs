using System;
using System.Collections.Generic;
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
        public int CaptainId { get; set; }
        public int SportId { get; set; }
        public virtual Division Division { get; set; }
        public virtual Player Captain { get; set; }
        public virtual Sport Sport { get; set;}
        public virtual ICollection<Affiliation> Affiliations { get; set; }
    }
}
