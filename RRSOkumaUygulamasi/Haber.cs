using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRSOkumaUygulamasi
{
    public class Haber
    {
        public string baslik { get; set; }
        public string link { get; set; }
        public string aciklama { get; set; }

        public override string ToString()
        {
            return baslik;
        }
    }
}
