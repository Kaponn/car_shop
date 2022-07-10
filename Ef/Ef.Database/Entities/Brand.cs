using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef.Database.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    [Table("tblBrand")]
    public class Brand
    {
        [Key]
        public string Name { get; set; }
    }
}
