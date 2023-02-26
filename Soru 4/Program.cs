namespace Soru_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Elemanları rastgele(1,10000 dahil) tamsayılardan oluşan 30 elemanlı bir dizinin  hem 2'ye hem de 3'e bölünebilenlerinin index'lerini başka bir array'de tutup, sonrasında bu index'leri ekrana yazan program(Ekrana yazma kısmını foreach ile yapın)


            int[] sayilar = new int[30];

            int sayac = 0;

            Random rnd = new Random();

            for (int i = 0; i< sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1, 10001);

                if (sayilar[i] % 2 == 0 && sayilar[i] % 3 == 0) // ikinci dizinin boyutunu belirlemek için
                {
                    sayac++;

                }
            }

            int[] bolunenler = new int[sayac];
            sayac= 0;

            for (int i = 0; i< sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0 && sayilar[i] % 3 == 0) // ikinci diziye eleman atamak için
                {
                    bolunenler[sayac] = sayilar[i];
                    sayac++;
                }
            }
           
            foreach (int i in bolunenler) 
            { 
                Console.WriteLine(i);
            }
        }
    }
}