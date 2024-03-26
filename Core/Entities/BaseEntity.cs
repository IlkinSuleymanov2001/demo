using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public  class BaseEntity<TId>
    {

        public TId Id { get; set; }
      
        public DateTime CreatedTime { get; set; }
        public DateTime? DeletedTime { get; set; }

        public DateTime?  UpdatedTime { get; set; }
    }
}
