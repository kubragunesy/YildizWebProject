using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int adminId { get; set; }
        public string adminUserName { get; set; }
        public string password { get; set; }
        public string adminRole { get; set; }
    }
}
