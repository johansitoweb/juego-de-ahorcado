using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Base
{
    public class Entity : IEntity
    {
        [Key]
        public int? id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Creation { get; set; }
        public DateTime LastModified { get; set; }
        public int ModifiedBy { get; set; }
    }
}
