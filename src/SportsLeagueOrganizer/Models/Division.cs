using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsLeagueOrganizer.Models
{
    [Table("Divisions")]
    public class Division
    {
        [Key]
        public int DivisionId { get; set; }
        public string Name { get; set; }
        public string SkillLevel { get; set; }
        public int MaxTeams { get; set; }
        public virtual ICollection<Team> Teams { get; set; }

        public Division()
        {
            this.Teams = new HashSet<Team>();
        }
    }
}
