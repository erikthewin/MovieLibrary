using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryDataAccess.Models
{
    public class Studio
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(32)]
        [Column(TypeName = "varchar(32)")]
        public string Name { get; set; }
        [Required]
        [MaxLength(300)]
        [Column(TypeName = "varchar(300)")]
        public string Description { get; set; }
    }
}
