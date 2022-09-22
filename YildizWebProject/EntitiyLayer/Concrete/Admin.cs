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
        [StringLength(20)]
        public string password { get; set; }
        [StringLength(1)]
        public string adminRole { get; set; }
    }
}
