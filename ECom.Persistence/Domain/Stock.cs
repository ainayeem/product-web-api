using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Persistence.Domain
{
    public class Stock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int VariantId { get; set; }
        public int WarehouseId { get; set; }
        public int Quantity { get; set; }

        //navigiate
        public Variant Variant { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
