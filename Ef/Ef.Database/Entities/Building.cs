using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Database.Entities
{
    [Table("tblBuilding")]
    public class Building
    {
        public int Id { get; set; }

        public Street Street { get; set; }

        public int Number { get; set; }
    }
}
