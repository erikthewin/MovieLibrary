﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryDataAccess.Models
{
    public class Director
    {
        public int Id{ get; set; }
        [Required]
        [MaxLength(32)]
        [Column(TypeName = "varchar(32)")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(32)]
        [Column(TypeName = "varchar(32)")]
        public string LastName { get; set; }
    }
}
