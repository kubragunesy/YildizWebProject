using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class CompanyInfo
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string name { get; set; }
        [StringLength(200)]
        public string logo { get; set; }
        [StringLength(150)]
        public string description { get; set; }
        public bool statu { get; set; }

    }
}
