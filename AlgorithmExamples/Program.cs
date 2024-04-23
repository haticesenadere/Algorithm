using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgorithmExamples
{
    internal class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Ana Sayfa - Tüm Sorular");
            Console.WriteLine("  1-  Ödev; İki sayının toplamı ");
            Console.WriteLine("  2-  Ödev; Verilen bir sayının faktöriyelini ");
            Console.WriteLine("  3-  ödev; Bir dizideki en büyük sayıyı ");
            Console.WriteLine("  4- Ödev;  Asal Sayiyi bul ");
            Console.WriteLine("  5- Ödev;Bir dizini küçükten büyüğe sırala ");
            Console.WriteLine("  6- Ödev; Bir dizindeki tekrar eden sayiyi bulun ");
            Console.WriteLine("  7- Ödev; Bir metindeki karakter sayisini bulun ");
            Console.WriteLine("  8- Ödev; Bir metin dizisi alın ve bu metinde kaç tane kelime olduğunu hesaplıyın. ");
            Console.WriteLine("  9- Ödev;  Bir metin tekrar eden kelime adetini bulun ");
            Console.WriteLine("  10- Ödev; Bir kelimeyi tersine çevirin. ");
            Console.WriteLine("  11- Ödev; Fibonacci serisinin ilk N terimini yazdıran bir fonksiyon yazın ");
            Console.WriteLine("  12- Ödev;  Kelimenin anagram olup olmadığını kontrol edin. ");
            Console.WriteLine("  13- Ödev;  Kelimenin polinom kontrolü  ");
            Console.WriteLine("  14- Ödev; Bir dizinin medyanını alın. ");
            Console.WriteLine("  15- Ödev;  Bir sayı listesinin ortalamasını alın. ");
            Console.WriteLine("  16- Ödev; 5 Kişilik bir grubu yaşlarına göre küçükten büyüğe göre sırak ");

            Console.Write("Görmek istediğiniz sorunun numarasını girin: ");

            int qNum = Convert.ToInt32(Console.ReadLine());

            if (qNum == 1)
            {
                Console.WriteLine("1- İki sayıyı toplayan bir algoritma yazınız. ");
                Console.WriteLine("Toplama işlemi için birinci sayıyı giriniz");
                int sayi1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Toplama işlemi için ikinci sayıyı giriniz");
                int sayi2 = Convert.ToInt32(Console.ReadLine());


                int toplam = sayi1 + sayi2;

                Console.WriteLine("Sayilatin Toplamı;" + toplam);

            }


            if (qNum == 2)
            {
                Console.WriteLine("2- Verilen bir sayının faktöriyelini hesaplayan bir algoritma yazın.");
                Console.WriteLine("Bir sayi giriniz.");
                int num1 = Convert.ToInt32(Console.ReadLine());


                int faktöriyel = 1;


                for (int i = 1; i <= num1; i++)
                {
                    faktöriyel *= i;
                }
                Console.WriteLine("Girdiğiniz sayının faktöriyeli: " + faktöriyel);

            }


            if (qNum == 3)
            {
                {
                    Console.WriteLine("3- Bir dizideki en büyük sayıyı bulan bir algoritma yazın.");
                    int[] sayilar = new int[5];

                    Console.WriteLine("Lütfen 5 adet sayı giriniz:");

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"Sayı {i + 1}: ");
                        sayilar[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    int büyük = sayilar[0];

                    for (int i = 1; i < sayilar.Length; i++)
                    {


                        if (büyük < sayilar[i])
                        {
                            büyük = sayilar[i];
                        }



                    }


                    Console.WriteLine("Dizide ki en büyük sayı: " + büyük);




                }

            }










            if (qNum == 4)
            {
                Console.WriteLine("4-  Asal Sayiyi bul.");

                Console.WriteLine("Bir sayi giriniz.");
                int asalSayi = Convert.ToInt32(Console.ReadLine());

                bool asalMi = AsalMi(asalSayi);

                if (asalMi)
                {
                    Console.WriteLine(asalSayi + " bir asal sayıdır.");
                }
                else
                {
                    Console.WriteLine(asalSayi + " bir asal sayı değildir.");
                }


                bool AsalMi(int sayi)
                {
                    if (sayi <= 1)
                    {
                        return false;
                    }

                    for (int i = 2; i <= sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            return false;
                        }
                    }

                    return true;

                }
            }
            if (qNum == 5)
            {


                int temp;
                int[] numberList = { 5, 9, 2, 3, 1, 7, 6, 8, 4 };
                Console.WriteLine("5 -Bir dizini küçükten büyüğe sırala: " + string.Join(", ", numberList));



                for (int i = 0; i < numberList.Length - 1; i++)
                {
                    int minIndex = i;

                    for (int j = i + 1; j < numberList.Length; j++)
                    {
                        if (numberList[j] < numberList[minIndex])
                        {
                            minIndex = j;


                        }
                    }
                    temp = numberList[i];
                    numberList[i] = numberList[minIndex];
                    numberList[minIndex] = temp;
                }
                Console.WriteLine("Sıralanmış Dizi:");
                foreach (var num in numberList)
                {
                    Console.Write(num + " ");
                }
            }
            if (qNum == 6)
            {
                Console.WriteLine("6 -  Bir dizindeki tekrar eden sayiyi bulun.");
                int[] numberList = { 5, 9, 5, 3, 1, 3, 6, 6, 4 };
                List<int> emptyList = new List<int>();

                for (int i = 0; i < numberList.Length - 1; i++)
                {
                    for (int j = i + 1; j < numberList.Length; j++)
                    {
                        if (numberList[i] == numberList[j])
                        {
                            emptyList.Add(numberList[i]);
                        }
                        {

                        }
                    }
                }
                Console.WriteLine("Tekrarlanan Sayılar:");
                foreach (var sayi in emptyList)
                {
                    Console.WriteLine(sayi);
                }

            }

            if (qNum == 7)
            {
                Console.WriteLine("7 -  Bir metindeki karakter sayisini bulun.");
                int charNumber = 0;
                string metinDizisi = Console.ReadLine();

                for (int i = 0; i < metinDizisi.Length; i++)
                {
                    charNumber++;

                }
                Console.WriteLine("Tekrarlanan Sayılar:{0}", charNumber);


            }
            if (qNum == 8)
            {
                Console.WriteLine("8 - Bir metin dizisi alın ve bu metinde kaç tane kelime olduğunu hesaplıyın.");
                int wordNumber = 0;
                Console.WriteLine("Bir Metin giriniz");
                string metin = Console.ReadLine();


                for (int i = 0; i < metin.Length; i++)
                {
                    if (char.IsWhiteSpace(metin[i]))
                    {
                        wordNumber++;
                    }
                }
                wordNumber++;

                Console.WriteLine("Metindeki kelime sayısı: " + wordNumber);

            }
            if (qNum == 9)
            {
                Console.WriteLine("9- Bir metin tekrar eden kelime adetini bulun");
                int wordCount = 0;
                Console.WriteLine("Bir Metin giriniz");
                string metin = Console.ReadLine();
                string[] kelimeler = metin.Split(' ');

                Console.WriteLine("Bir kelime seçiniz");
                string takeword = Console.ReadLine();

                for (int i = 0; i < kelimeler.Length; i++)
                {
                    if (takeword.Equals(kelimeler[i], StringComparison.OrdinalIgnoreCase)) // Equals harflerin eşitliğini kontrol eder. StringComparison.OrdinalIgnore vs. ise küçük büyük fark etmeden devam eder.
                    {
                        wordCount++;

                    }


                }
                Console.WriteLine($"Metinde \"{takeword}\" kelimesi {wordCount} kez geçmektedir.");
            }
            if (qNum == 10)
            {

                Console.WriteLine("10- Bir kelimeyi tersine çevirin");
                Console.WriteLine("Bir Metin giriniz");
                string metin = Console.ReadLine();

                char[] character = metin.ToCharArray();

                Array.Reverse(character);

                string tersMetin = new string(character);

                Console.WriteLine(" Metnin önceki hali  " + metin + "  ve metnin sonraki hali  " + tersMetin + "  Tersi çevirilmiş hali.");
            }
            if (qNum == 11)
            {
                Console.WriteLine("11-  Fibonacci serisinin ilk N terimini yazdıran bir fonksiyon yazın. ");
                int a = 0; int b = 1; int sonuc = 0;
                Console.WriteLine("Bir sayi giriniz.");
                int Sayi = Convert.ToInt32(Console.ReadLine());
                if (Sayi == 1)
                {
                    Console.WriteLine(a);
                }
                if (Sayi == 2)
                {
                    Console.WriteLine(b);
                }
                for (int i = 3; i < Sayi; i++)
                {
                    sonuc = a + b;
                    Console.WriteLine(sonuc);
                    a = b;
                    b = sonuc;
                }

            }
            if (qNum == 12)
            {
                Console.WriteLine("12-  Kelimenin anagram olup olmadığını kontrol edin. ");
                bool anagram = false;
                Console.WriteLine("1.Kelimeyi giriniz");
                string word1 = Console.ReadLine();

                Console.WriteLine("2.Kelimeyi giriniz");
                string word2 = Console.ReadLine();

                if (word1.Length != word2.Length)
                {
                    anagram = false;
                }
                else
                {
                    if (Sorted(word1) == Sorted(word2))
                    {
                        anagram = true;
                    }
                }

                if (anagram = true)
                {
                    Console.WriteLine(word1 + "ve" + word2 + "Kelimeleri anagramdır.");
                }
                if (anagram = false)
                {
                    Console.WriteLine(word1 + "ve" + word2 + "Kelimeleri anagram değildir.");
                }

            }
            static string Sorted(string str)
            {
                char[] chars = str.ToArray();
                Array.Sort(chars);
                return new string(chars);
            }
            if (qNum == 13)
            {
                Console.WriteLine("13-  Kelimenin polinom kontrolü  ");
                Console.WriteLine("Bir kelime giriniz:");
                string kelime = Console.ReadLine();

                if (IsPalindrome(kelime))
                {
                    Console.WriteLine("Girilen kelime bir palindromdur.");
                }
                else
                {
                    Console.WriteLine("Girilen kelime bir palindrom değildir.");
                }
            }

            static bool IsPalindrome(string kelime)
            {

                char[] chars = kelime.ToCharArray();
                Array.Reverse(chars);
                string tersKelime = new string(chars);


                return kelime.Equals(tersKelime, StringComparison.OrdinalIgnoreCase);
            }
            if (qNum == 14)
            {
                Console.WriteLine("14-  Bir dizinin medyanını alın.  ");
                int[] numberList = { 5, 9, 2, 3, 1, 7, 6, 8, 4 };
                Array.Sort(numberList);

                int ortancaIndex;
                double ortancaDeger;

                if (numberList.Length % 2 == 1)
                {
                    ortancaIndex = numberList.Length / 2;
                    ortancaDeger = numberList[ortancaIndex];
                }
                else
                {
                    int altOrtancaIndex = numberList.Length / 2 - 1;
                    int ustOrtancaIndex = numberList.Length / 2;
                    ortancaDeger = (numberList[altOrtancaIndex] + numberList[ustOrtancaIndex]) / 2.0;
                }
                Console.WriteLine("Dizinin ortanca değeri: " + ortancaDeger);
            }
            if (qNum == 15)
            {
                Console.WriteLine("15-  Bir sayı listesinin ortalamasını alın. ");
                int i; int toplam = 0;
                double ortalama;
                int[] sayilar = new int[5];
                Console.WriteLine("Lütfen 5 adet sayı giriniz:");
                for (i = 0; i < 5; i++)
                {
                    Console.Write($"Sayi {i + 1} ");
                    sayilar[i] = Convert.ToInt32(Console.ReadLine());
                    toplam = toplam + sayilar[i];
                }
                ortalama = (double)toplam / sayilar.Length;
                Console.WriteLine("Ortalama: " + ortalama);
            }

            if (qNum == 16)
            {
                Console.WriteLine("16- 5 Kişilik bir grubu yaşlarına göre küçükten büyüğe göre sırak ");
                (string isim, int yas)[] kisiler = {
            ("Ahmet", 32),
            ("Mehmet", 25),
            ("Ayşe", 41),
            ("Fatma", 19),
            ("Ali", 28)
               };


                Array.Sort(kisiler, (x, y) => x.yas.CompareTo(y.yas));


                Console.WriteLine("Sıralanmış İsimler ve Yaşlar:");
                foreach (var kisi in kisiler)
                {
                    Console.WriteLine($"İsim: {kisi.isim}, Yaş: {kisi.yas}");
                }
            }


            if (qNum == 17)
            {
                Console.WriteLine(" Bir işe alım uygulaması.   ");

                Console.WriteLine("Yaşınızı giriniz. ");
                int age = Convert.ToInt32(Console.ReadLine());


                if (age < 18 || age > 35)
                {
                    Console.WriteLine("Uygun değil.");
                    return;
                }

                Console.WriteLine("İş tecrübelerinizi kaç yıldır?  ");
                int year = Convert.ToInt32(Console.ReadLine());
                if (year < 2)
                {
                    Console.WriteLine("Uygun değil.");

                }
                else if (year < 5)
                {
                    Console.WriteLine("Maaş Teklifimiz 45.000 tl'dir.");
                }
                else
                {
                    Console.WriteLine("Maaş Teklifimiz 80.000 tl'dir.");
                }

                Console.WriteLine(" Bizimle çalışmak ister misiniz?  ");
                string answer = Console.ReadLine();

                if (answer == "evet")
                {
                    Console.WriteLine(" O zaman  şirketimize hoş geldiniz..");

                }
                else
                {
                    Console.WriteLine(" Bizi kaybettiğiniz için çok pişman olucaksınız ");
                }

            }

              

            }


            }
        }
    


// Değişken isimlendirmeleri tek kelimesiyle küçük harfle yazılır. 
// Eğer 2 kelime yazılıyorsa ilk kelimenin harfi küçük ikinci kelimenin harfi de büyük olur. 
// Tamamen ingilizce karakterler kullanılıyor. 
// 1-Değişken isimleri harf (a-z, A-Z), rakam (0-9) veya alt çizgi (_) ile başlamalıdır.
//2 - İsimler harfle başlamalıdır; rakamla başlayamazlar.
//3 - İsimler, harf, rakam ve alt çizgi dışında özel karakterler içeremez.
//4-Büyük-küçük harf duyarlıdır. Yani "degisken", "Degisken" ve "Değişken" farklı değişkenler olarak kabul edilir.
//4-keyword kelimeler kullanılamaz. Örneğin, "int", "double", "if", "for" gibi anahtar kelimeler değişken ismi olarak kullanılamaz.
//5-İsimlendirme açıklayıcı ve anlamlı olmalıdır. Değişkenin amacını veya kullanımını yansıtan isimler tercih edilmelidir.
//6-CamelCase kullanılması önerilir. İsimlerin içindeki kelimelerin baş harfleri küçük olmalı, ardından her yeni kelimenin baş harfi büyük olmalıdır. Örneğin: "toplamUrunAdedi".
//İsimler Türkçe karakterler içermemelidir. C# dilinde genellikle İngilizce karakterler kullanılır.