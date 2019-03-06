using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    public class SistemGirisTarih
    {
        private static SistemGirisTarih _sistemGirisTarih; 

        private SistemGirisTarih()
        {

        }

        public static SistemGirisTarih CreateAsSingleton()
        {
            return _sistemGirisTarih ?? (_sistemGirisTarih = new SistemGirisTarih());    
        }

        public string TarihGoster()
        { string tarih = "";
            tarih = DateTime.Now.ToLongDateString().ToString();
            return tarih;
        }
    }
}
