using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ef.Database.Entities
{
    [Table("tblModel")]
    public class Model
    {
        public int Id { get; set; }
    
        public string Name { get; set; }

        public Brand Brand { get; set; }
    }
}
