using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerAdress { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }
        [Required]
        [MaxLength(50)]
        public string CustomerPhone { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        public DateTime CreatedDate { set; get; }
        public string CreateBy{ set; get; }

        [MaxLength(256)]
        public string PaymentMethod { set; get; }
        [Required]
        public string PaymentStatus { set; get; }

        public bool Status { get; set; }

         public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }


    }
}
