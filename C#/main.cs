using System;

class MainClass {
  public static void Main (string[] args) {
    //urun1 adında urun clasından oluştur
    urun urun1 = new urun();
    urun1.adi = "A Bilgisayar";
    urun1.kategorisi = "Bilgisayar Bileşenleri";
    urun1.ozellikleri = "32 GB, 3200 MHz, DDR2 RAM";
    urun1.ulkesi = "Türkiye";
    urun1.fiyati = 2500.00;
    urun1.indirimOrani = 5;
    urun1.sifirmi = true;
    urun1.kargoBilgileri = "Aras Kargo";
    urun1.kargoUcreti = 0; 
    urun1.saticiBilgileri = "Aykut Bilişim";
    urun1.saticiAciklamasi = "PC Uyumludur.";
    
    //urun2 adında urun clasından oluştur
    urun urun2 = new urun();
    urun2.adi = "B Bilgisayar";
    urun2.kategorisi = "Bilgisayar Bileşenleri";
    urun2.ozellikleri = "1TB SSD 3200 MHz, DDR4 RAM";
    urun2.ulkesi = "Türkiye";
    urun2.fiyati = 5000.00;
    urun2.indirimOrani = 5;
    urun2.sifirmi = true;
    urun2.kargoBilgileri = "Aras Kargo";
    urun2.kargoUcreti = 9.90;
    urun2.saticiBilgileri = "Aykut Bilişim";
    urun2.saticiAciklamasi = "Oyun canavarı bilgisayar.";

    //urun3 adında urun clasından oluştur
    urun urun3 = new urun();
    urun3.adi = "C Bilgisayar";
    urun3.kategorisi = "Bilgisayar Bileşenleri";
    urun3.ozellikleri = "1TB SSD 3400 MHz, DDR8 RAM";
    urun3.ulkesi = "Türkiye";
    urun3.fiyati = 2000.00;
    urun3.indirimOrani = 10;
    urun3.sifirmi = false;
    urun3.kargoBilgileri = "Aras Kargo";
    urun3.kargoUcreti = 9.90;
    urun3.saticiBilgileri = "Aykut Bilişim";
    urun3.saticiAciklamasi = "Oyun canavarı bilgisayar.";

    //urun3 adında urun clasından oluştur
    urun urun4 = new urun();
    urun4.adi = "D Bilgisayar";
    urun4.kategorisi = "Bilgisayar Bileşenleri";
    urun4.ozellikleri = "1TB SSD 4200 MHz, DDR16 RAM";
    urun4.ulkesi = "Türkiye";
    urun4.fiyati = 2700.00;
    urun4.indirimOrani = 8;
    urun4.sifirmi = false;
    urun4.kargoBilgileri = "Aras Kargo";
    urun4.kargoUcreti = 9.90;
    urun4.saticiBilgileri = "Aykut Bilişim";
    urun4.saticiAciklamasi = "Oyun canavarı bilgisayar.";

    urun[] urunler = new urun[] {urun1,urun2,urun3,urun4};
    //Şimdi ilk işlemimizi 'for döngüsü' ile yapalım...
    Console.WriteLine("---ÜRÜNLERİMİZ---(for döngüsü)");    
    for (int i = 0; i < urunler.Length; i++)
    {
      Console.WriteLine("----------------------------------");
      Console.WriteLine("Ürün Adı: "+urunler[i].adi);
      Console.WriteLine("Ürün Kategorisi: "+urunler[i].kategorisi);
      Console.WriteLine("Ürün Özellikleri: "+urunler[i].ozellikleri);
      Console.WriteLine("Ürün Ülkesi: "+urunler[i].ulkesi);
      Console.WriteLine("Ürün Fiyatı: "+urunler[i].fiyati+" TL");
      //şimdi indirimli fiyatları hesaplayalım...
      if(urunler[i].indirimOrani!=0){
      Console.WriteLine("İndirim Oranı: %"+urunler[i].indirimOrani);
      double indirimliFiyati=urunler[i].fiyati-urunler[i].fiyati*urunler[i].indirimOrani/100;
      Console.WriteLine("İndirimli Fiyatı: "+indirimliFiyati+" TL");
      }
      //ternary operatörünü kullanacağız...
      //kargo ücreti 0 ise ücretsiz kargo 0 değilse kargo ücretini yazdıracak...
      string kargo= urunler[i].kargoUcreti==0 ? "Ücretsiz Kargo" : urunler[i].kargoUcreti.ToString()+" TL";
      string urunSifirmi= urunler[i].sifirmi==true ? "Sıfır Ürün": "İkinci El Ürün";
      Console.WriteLine("Ürün Durumu: "+urunSifirmi);
      Console.WriteLine("Kargo Şirketi: "+urunler[i].kargoBilgileri);
      Console.WriteLine("Kargo Ücreti: "+kargo);
      Console.WriteLine("Satıcı Bilgileri: "+urunler[i].saticiBilgileri);   
      Console.WriteLine("Satıcı Açıklaması: "+urunler[i].saticiAciklamasi);   
    }    
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Toplam "+urunler.Length+" Ürün Listelendi...");     
  
    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

    //Şimdi ki işlemlerimizi 'for each döngüsü' ile yapalım...
    Console.WriteLine("---ÜRÜNLERİMİZ---(for each döngüsü)");    
    foreach (var urun in urunler)
    {
      Console.WriteLine("-------------------------------");
      Console.WriteLine("Ürün Adı: "+urun.adi);
      Console.WriteLine("Ürün Kategorisi: "+urun.kategorisi);
      Console.WriteLine("Ürün Özellikleri: "+urun.ozellikleri);
      Console.WriteLine("Ürün Ülkesi: "+urun.ulkesi);
      Console.WriteLine("Ürün Fiyatı: "+urun.fiyati+" TL");
      if(urun.indirimOrani!=0)
      {
      Console.WriteLine("İndirim Oranı: %"+urun.indirimOrani);
      double indirimliFiyati=urun.fiyati-urun.fiyati*urun.indirimOrani/100;
      Console.WriteLine("İndirimli Fiyatı: "+indirimliFiyati+" TL");
      }
      string kargo= urun.kargoUcreti==0 ? "Ücretsiz Kargo" : urun.kargoUcreti.ToString()+" TL";
      string urunSifirmi= urun.sifirmi==true ? "Sıfır ürün": "İkinci el ürün";
      Console.WriteLine("Ürün Durumu: "+urunSifirmi);
      Console.WriteLine("Kargo Şirketi: "+urun.kargoBilgileri);
      Console.WriteLine("Kargo Ücreti: "+kargo);
      Console.WriteLine("Satıcı Bilgileri: "+urun.saticiBilgileri);   
      Console.WriteLine("Satıcı Açıklaması: "+urun.saticiAciklamasi);      
    }    
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Toplam "+urunler.Length+" Ürün Listelendi..."); 
    
    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

    //Şimdi ki işlemlerimizi 'while döngüsü' ile yapalım...
    Console.WriteLine("---ÜRÜNLERİMİZ---(while döngüsü)");  
    int a=0;
    while (a < urunler.Length)
     {
      Console.WriteLine("--------------------------------");
      Console.WriteLine("Ürün Adı: "+urunler[a].adi);
      Console.WriteLine("Ürün Kategorisi: "+urunler[a].kategorisi);
      Console.WriteLine("Ürün Özellikleri: "+urunler[a].ozellikleri);
      Console.WriteLine("Ürün Ülkesi: "+urunler[a].ulkesi);
      Console.WriteLine("Ürün Fiyatı: "+urunler[a].fiyati+" TL");
      if(urunler[a].indirimOrani!=0)
      {
      Console.WriteLine("İndirim Oranı: %"+urunler[a].indirimOrani);
      double indirimliFiyati=urunler[a].fiyati-urunler[a].fiyati*urunler[a].indirimOrani/100;
      Console.WriteLine("İndirimli Fiyatı: "+indirimliFiyati+" TL");
      }
      string kargo= urunler[a].kargoUcreti==0 ? "Ücretsiz Kargo" : urunler[a].kargoUcreti.ToString()+" TL";
      string urunSifirmi= urunler[a].sifirmi==true ? "Sıfır Ürün": "İkinci El Ürün";
      Console.WriteLine("Ürün Durumu: "+urunSifirmi);
      Console.WriteLine("Kargo Şirketi: "+urunler[a].kargoBilgileri);
      Console.WriteLine("Kargo Ücreti: "+kargo);
      Console.WriteLine("Satıcı Bilgileri: "+urunler[a].saticiBilgileri);   
      Console.WriteLine("Satıcı Açıklaması: "+urunler[a].saticiAciklamasi);   
      a++;
    }    
    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
    Console.WriteLine("Toplam "+urunler.Length+" Ürün Listelendi...");     
    
}
}


//urun sınıfı tanımlaması
class urun 
{
  public string adi {get ; set; }
  public string kategorisi {get ; set; }
  public string ozellikleri {get ; set; }
  public string ulkesi {get ; set; }
  public double fiyati {get ; set; }
  public double indirimOrani {get ; set; }
  public bool sifirmi {get ; set; }
  public string kargoBilgileri {get ; set; }
  public double kargoUcreti {get ; set; }
  public string saticiBilgileri {get ; set; }
  public string saticiAciklamasi {get ; set; }
}