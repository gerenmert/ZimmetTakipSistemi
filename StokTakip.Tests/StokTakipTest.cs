using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;



namespace StokTakip.Tests
{
    [TestClass]
   public class StokTakipTest
    {
        [TestMethod, ExpectedException(typeof(AuthenticationException))] //testin basarili olabilmesi icin hata olmasi gerek
        public void kullaniciSifreHataliGiris()
        {
            LoginEkran control = new LoginEkran();
            control.giris("dssd", "sdsdds");
        }


        [TestMethod, ExpectedException(typeof(AuthenticationException))] //testin basarili olabilmesi icin hata olmasi gerek
        public void kullaniciSifreGirilmemesi()
        {
            LoginEkran control = new LoginEkran();
            control.giris("", "");
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void KullaniciEkleBoslukKontrol()
        {
            KullaniciEkle control = new KullaniciEkle();
            control.kullaniciEkle(2, 2, "", "");
        }



        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void BolumRolKontrol()
        {
            KullaniciEkle control = new KullaniciEkle();
            control.kullaniciEkle(9, 9, "neclet", "123456");
        }


        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void StokEkleKontrol()
        {
            SatinAlma control = new SatinAlma();
            control.StokEkle("asus ekran kartı", 3, DateTime.Now, "ekran kartı", 10, 30, "altin Bilisim");
        }

    }
}
