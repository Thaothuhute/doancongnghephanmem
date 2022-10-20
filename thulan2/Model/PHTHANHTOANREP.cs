using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thulan2.Model
{
    internal class PHTHANHTOANREP
    {
        public string Maptt { get; set; }

        public DateTime? Ngaylapphieu { get; set; }

       
        

        public string TenKH  {get; set; }

        public string Sop { get; set; }
        public double Tongtien { get; set; }

        
    }
}
