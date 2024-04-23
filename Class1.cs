using System;
using System.Collections.Generic;

class Soru
{
    public int Numara { get; set; }
    public string Baslik { get; set; }

    public Soru(int numara, string baslik)
    {
        Numara = numara;
        Baslik = baslik;
    }
}

class Program
{
    static void Main()
    {
        // Soruları tanımlayalım
        List<Soru> sorular = new List<Soru>
        {
            new Soru(1, "Birinci Soru Başlığı"),
            new Soru(2, "İkinci Soru Başlığı"),
            // Diğer soruları da buraya ekleyin
            new Soru(13, "Bir metin dizisi alın ve bu metinde kaç tane kelime olduğunu hesaplayın.")
        };

        // Ana sayfayı göster
        Console.WriteLine("Ana Sayfa - Tüm Sorular");
        foreach (Soru soru in sorular)
        {
            Console.WriteLine($"{soru.Numara}. {soru.Baslik}");
        }

        // Kullanıcıdan soru numarası al
        Console.Write("Görmek istediğiniz sorunun numarasını girin: ");
        int qNum = Convert.ToInt32(Console.ReadLine());

        // Kullanıcının seçtiği soruyu bul ve göster
        Soru seciliSoru = sorular.Find(s => s.Numara == qNum);
        if (seciliSoru != null)
        {
            Console.WriteLine($"Soru {seciliSoru.Numara}: {seciliSoru.Baslik}");
            // Kullanıcı buradan istediği işlemleri yapabilir
        }
        else
        {
            Console.WriteLine("Böyle bir soru bulunamadı.");
        }
    }
}

Console.WriteLine("Ana Sayfa - Tüm Sorular");
Console.WriteLine("  1-  Ödev; İki sayının toplamı ");
Console.WriteLine("  2-  Ödev; Verilen bir sayının faktöriyelini ");
Console.WriteLine("  3-  ödev; Bir dizideki en büyük sayıyı ");
Console.WriteLine("  4- Ders çalışması; Toplama ve Çarpma işlemlerini yapınız.");
Console.WriteLine("  5- Ders çalışması : Bir dizinin toplamı çarpımı küçüğü büyüğü ortalamasını ");
Console.WriteLine("  6- Ders Çalışması ; İki sayi kıyaslaması yap ");
Console.WriteLine("  7- Ders çalışması : Haftanın hangi günlerinde ders var ? ");
Console.WriteLine("  8- Ders Çalışması; Yaş Aralıklarının isimlendirmesini yap ");
Console.WriteLine("  9- Ödev;  Asal Sayiyi bul ");
Console.WriteLine("  10- Ödev;Bir dizini küçükten büyüğe sırala ");
Console.WriteLine("  11- Ödev; Bir dizindeki tekrar eden sayiyi bulun ");
Console.WriteLine("  12- Ödev; Bir metindeki karakter sayisini bulun ");
Console.WriteLine("  13- Ödev; Bir metin dizisi alın ve bu metinde kaç tane kelime olduğunu hesaplıyın. ");
Console.WriteLine("  14- Ödev;  Bir metin tekrar eden kelime adetini bulun ");
Console.WriteLine("  15- Ödev; Bir kelimeyi tersine çevirin. ");
Console.WriteLine("  16- Ödev; Fibonacci serisinin ilk N terimini yazdıran bir fonksiyon yazın ");
Console.WriteLine("  17- Ödev;  Kelimenin anagram olup olmadığını kontrol edin. ");
Console.WriteLine("  18- Ödev;  Kelimenin polinom kontrolü  ");
Console.WriteLine("  19- Ödev; Bir dizinin medyanını alın. ");
Console.WriteLine("  20- Ödev;  Bir sayı listesinin ortalamasını alın. ");
Console.WriteLine("  21- Ödev; 5 Kişilik bir grubu yaşlarına göre küçükten büyüğe göre sırak ");





