﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryDataAccess.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Title { get; set; }
        [Required]
        [MaxLength(300)]
        [Column(TypeName = "varchar(300)")]
        public string Description { get; set; }
        public int? Rating { get; set; }
        public Studio Studio { get; set; }
        public Director Director { get; set; }
    }
}