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
        [StringLength(50)]
        public string adminUserName { get; set; }
        [StringLength(50)]
        public string password { get; set; }
        
        public bool adminCinsiyet { get; set; }

        
    }
}
