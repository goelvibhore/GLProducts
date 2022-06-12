using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GLProducts.Model
{
    [Table("Catalog")]
    public partial class Catalog
    {
        [Key]
        public int CatalogId { get; set; }

        [Required]
        [StringLength(100)]
        public string CatalagName { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
    }
}
