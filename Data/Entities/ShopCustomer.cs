using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{

    [PrimaryKey("ShopID", "CustomerID")]
    public class ShopCustomer
    {
        [ForeignKey(nameof(ShopInstance))]

        public int ShopId { get; set; }

        public Shop ShopInstance { get; set; }

        [ForeignKey(nameof(CustomerInstance))]

        public int CustomerID { get; set; }

        public Customer CustomerInstance { get; set; }
    }
}
