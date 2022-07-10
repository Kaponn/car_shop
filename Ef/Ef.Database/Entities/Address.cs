using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Database.Entities
{
    [Table("tblAddress")]
    public class Address
    {
        public int Id { get; set; }

        public Building Building { get; set; }

        public int FlatNumber { get; set; }
    }
}
