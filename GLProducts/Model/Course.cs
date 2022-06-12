using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GLProducts.Model
{
    [Table("Course")]
    public partial class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        [StringLength(100)]
        public string CourseName { get; set; }
        public int CatalogId { get; set; }
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
    }
}
