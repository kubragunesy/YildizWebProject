using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Business
    {
        [Key]
        public int businessId { get; set; }
        [StringLength(200)]
        public string businessName { get; set; }
        [StringLength(1000)]
        public string businessDescription { get; set; }
        [StringLength(200)]
        public string businessIcon { get; set; }
        public bool statu { get; set; }
    }

}
