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
        public string customerName { get; set; }
        public string customerLastName { get; set; }
        public string customerMail { get; set; }
        public string customerPhoneNumber { get; set; }
        public string customerMessage { get; set; }
        public bool statu { get; set; }
    }
}
