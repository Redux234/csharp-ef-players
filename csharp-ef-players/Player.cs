using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    [Table("Player")]
    [Index(nameof(id),IsUnique = true)]
    public class Player
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string surname { get; set; }
        public int points { get; set; }
        public int matchplayed { get; set; }
        public int matchwon { get; set; }
    }
}
