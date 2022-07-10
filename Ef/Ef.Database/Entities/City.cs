using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Database.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    [Table("tblCity")]
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
