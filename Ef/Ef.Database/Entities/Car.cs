using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ef.Database.Entities
{
    [Table("tblCar")]
    public class Car
    {
        public int Id { get; set; }
        
        public Model Model { get; set; }

        public Person CurrentPerson { get; set; }

        public IEnumerable<Person> Owners { get; set; }
    }
}
