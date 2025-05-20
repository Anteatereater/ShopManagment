using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Employee> employees { get; set; }

        public ICollection<Product> products { get; set; }

        public ICollection<Customer> customers { get; set; }

        [ForeignKey(nameof(ManagerInstance))]

        public int ManagerID { get; set; }

        public Manager ManagerInstance { get; set; }

    }
}
