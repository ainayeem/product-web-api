using ECom.Persistence.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Service.DTOs
{
    public class AddProductRequestDto
    {
        public string Name { get; set; }
        public string SearchEngineFriendlyName { get; set; }
        public DateTime CreatedOn { get; set; }
        
    }
}
