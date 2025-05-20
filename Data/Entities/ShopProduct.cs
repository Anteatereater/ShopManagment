using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [PrimaryKey("ShopID", "ProductID")]
    public class ShopProduct
    {
        [ForeignKey(nameof(ShopInstance))]

        public int ShopId { get; set; }

        public Shop ShopInstance { get; set; }

        [ForeignKey(nameof(ProductInstance))]

        public int ProductID { get; set; }

        public Product ProductInstance { get; set; }
    }
}
