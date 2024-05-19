using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Persistence.Domain
{
    public class Variant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }

        //navigate
        public Product Product { get; set; }
        public ICollection<Stock> Stocks { get; set; }
    }
}
