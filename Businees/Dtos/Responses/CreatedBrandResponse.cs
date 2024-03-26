using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Dtos.Response
{
    public class CreatedBrandResponse
    {
        public int  Id { get; set; }

        public DateTime CreatedTime { get; set; }
      
        public string Name { get; set; }
        
    }
}
