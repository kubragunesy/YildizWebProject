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
        public string name { get; set; }
        public string logo { get; set; }
        public string description { get; set; }
        public bool statu { get; set; }

    }
}
