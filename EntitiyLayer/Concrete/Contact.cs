using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int customerId { get; set; }
        [StringLength(50)]
        public string customerName { get; set; }
        [StringLength(50)]
        public string customerLastName { get; set; }
        [StringLength(100)]
        public string customerMail { get; set; }
        [StringLength(15)]
        public string customerPhoneNumber { get; set; }
        [StringLength(1000)]
        public string customerMessage { get; set; }
        public bool statu { get; set; }
    }
}
