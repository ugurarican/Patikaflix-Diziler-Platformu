using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix_Diziler_Platformu
{
    internal class ComedyShow
    {
        public string DiziAdi  { get; set; }
        public string DiziTuru { get; set; }
        public string Yonetmen { get; set; }
        public ComedyShow(string diziAdi, string diziTuru, string yonetmen)
        {
            DiziAdi = diziAdi;
            DiziTuru = diziTuru;
            Yonetmen = yonetmen;
        }
    }
}
