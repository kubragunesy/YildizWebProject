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
        public string businessName { get; set; }
        public string businessDescription { get; set; }
        public bool statu { get; set; }
    }

}
