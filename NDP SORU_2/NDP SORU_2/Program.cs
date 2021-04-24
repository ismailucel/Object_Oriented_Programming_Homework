/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1     
**				ÖĞRENCİ ADI............: İsmail Üçel    
**				ÖĞRENCİ NUMARASI.......: G201210352
**              DERSİN ALINDIĞI GRUP...: 2.Öğretim A Grubu
****************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_SORU_2
{
    class Program
    {
        

        static void Main(string[] args)
        {
                Console.WriteLine();
                char secim; //secim değişkeni
           

                // örnekte gösterilen menü gösterimi oluşturuluyor

                Console.WriteLine("\t\t\t\t\t\tMENÜ");

                Console.WriteLine();

                Console.WriteLine("\t1)String bir değişkende string bir değeri substring kullanmadan ara!");
                Console.WriteLine("\t2)String bir değişkende string bir değeri substring kullanarak ara!");
                Console.WriteLine("\t3)Alfabenin karakterlerini bir string değişkeninde ara, kaç adet geçtiğini bul ve çiz!");

                Console.WriteLine();


                // seçim alınıyor

                Console.Write("Seçiminizi giriniz: ");
                secim = Convert.ToChar(Console.ReadLine());

                
                //gerekli değişkenler oluşturuluyor

                string aranılan;
                string dizin;
                int index;

                // kullanıcının girdiği seçime göre yapılacak işlemler

                switch (secim)
                {
                    case '1':        
                        Console.Write("Aranılacak kelimeyi giriniz: ");
                        aranılan = Console.ReadLine(); // kullanıcıdan aranılacak kelime alınıyor
                        Console.Write("Karakter dizinini giriniz: ");
                        dizin = Console.ReadLine();    // kullanıcdan girilecek metin alınıyor
                        
                        //büyük ya da küçük harf girilmesi halinde çalışması için
                        aranılan = aranılan.ToLower();
                        dizin = dizin.ToLower();

                        index = dizin.IndexOf(aranılan);  // aranılan kelimenin metinde olup olmadığı kontrol ediliyor


                        Console.WriteLine("- - - - - - - - - - - - - - - - - - -  - - - - - - - - ");

                        Console.WriteLine("- - - - - - - - - - - - - - - - - - -  - - - - - - - - ");


                        while (index != -1)  //eğer metinde varsa yapılacaklar(kelime ve indis yazılır ve bir sonraki indeksten devam edilir)
                        {
                            Console.WriteLine("Aranılan kelime = {0} - İndisi: {1}", aranılan, index);
                            index = dizin.IndexOf(aranılan, index + 1);
                        }

                        Console.Read();

                        break;

                    case '2':  //NOT: BU SEÇİMDE BÜYÜK-KÜÇÜK HARF DUYARLILIĞINA DİKKAT EDİLMİŞTİR.
                        Console.Write("Aranılacak kelimeyi giriniz: ");
                        aranılan = Console.ReadLine();  // kullanıcıdan aranılacak kelime alınıyor
                        Console.Write("Karakter dizinini giriniz: ");
                        dizin = Console.ReadLine();     // kullanıcdan girilecek metin alınıyor

                        //büyük ya da küçük harf girilmesi halinde çalışması için
                        aranılan = aranılan.ToLower();
                        dizin = dizin.ToLower();

                        index = dizin.IndexOf(aranılan);


                        Console.WriteLine("- - - - - - - - - - - - - - - - - - -  - - - - - - - - ");

                        Console.WriteLine("- - - - - - - - - - - - - - - - - - -  - - - - - - - - ");


                        while (index != -1)  //eğer metinde varsa yapılacaklar substring metoduyla belirtiliyor(kelime ve indis yazılır ve bir sonraki indeksten devam edilir)
                    {
                            for (int i = 0; i <= (dizin.Length - aranılan.Length); i++)
                            {
                                if (dizin.Substring(i, aranılan.Length) == aranılan)
                                {
                                    Console.WriteLine("Aranılan kelime = {0} - İndisi: {1}", aranılan, index);
                                    index = dizin.IndexOf(aranılan, index + 1);

                                }
                            }


                        }
                        break;

                    case '3':
                        Console.Write("Karakter dizinini giriniz: "); // kullanıcdan girilecek metin alınıyor
                        dizin = Console.ReadLine();


                        dizin = dizin.ToUpper(); 
                        String karakterler = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ"; // grafikte gösterilecek harfler

                        Console.WriteLine("Karakter Sayısı     Grafik Gösterimi");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - -  - - - - - - - - ");
                        

                        //metin içinde bulunan harflerin sıklık sayısı tutuluyor

                        int[] count = new int[karakterler.Length];
                        for (int i = 0; i < dizin.Length; i++)
                        {
                            index = karakterler.IndexOf(dizin[i]);
                            if (index < 0)
                                continue;
                            else
                            {
                                count[index]++;
                            }
                        }

                         //metin içinde bulunan harflerin sıklık sayısı kadar yıldız yazdırma işlemi yapılıyor

                        for (int i = 0; i < count.Length; i++)
                        {

                            Console.Write(karakterler[i] + ", \t sayısı:  " + count[i]);
                            for (int j = 0; j < count[i]; j++)
                            {
                                Console.Write(" * ");

                            }

                            Console.WriteLine();

                        }
                        break;
                    default: //1,2 ya da 3 girilmediğinde uyarı verilmesi için yazılan blok
                        Console.WriteLine("Hatalı bir seçim yaptınız");
                        break;



                }
            
        }
    }
}
