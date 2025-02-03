using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikaflix_Diziler_Platformu
{
    internal class TVShow
    {
        public string DiziAdi { get; set; }
        public int YapimYili { get; set; }
        public string DiziTuru { get; set; }
        public int YayimYili { get; set; }
        public string Yonetmen { get; set; }
        public string IlkPlatform { get; set; }

        public TVShow(string diziAdi, int yapimYili, string diziTuru, int yayimYili, string yonetmen, string ilkPlatform)
        {
            DiziAdi = diziAdi;
            YapimYili = yapimYili;
            DiziTuru = diziTuru;
            YayimYili = yayimYili;
            Yonetmen = yonetmen;
            IlkPlatform = ilkPlatform;
        }
    }
}
