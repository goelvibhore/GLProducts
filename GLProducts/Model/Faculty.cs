using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GLProducts.Model
{
    [Table("Faculty")]
    public partial class Faculty
    {
        [Key]
        public int FacultyId { get; set; }
        [Required]
        [StringLength(100)]
        public string FacultyName { get; set; }
    }
}
