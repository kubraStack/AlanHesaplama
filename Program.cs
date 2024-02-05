namespace ConsoleApp_AlanHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim;

            do
            {
                MenuYaz();
                bool result;
                do
                {
                    Console.WriteLine("Seçiminiz: ");
                    string secimStr =  Console.ReadLine(); //Kullanıcan string seçimde gelebileceği için bunu string olarak alıp daha sonra tryparse metotu ile sayısal gelirse secim içine parse ettik
                    result = int.TryParse(secimStr, out secim);
                }while (result == false);

                İslemiYap(secim);


            } while (secim != 0);
            
            
        }
        static void İslemiYap(int secim)
        {
            switch (secim)
            {
                case 1:
                    //Kare Hesaplama
                    KareAlanHesaplama();
                    break;
                case 2:
                    //Dikdörtgen Hesaplama
                    DikdörtgenAlanHesaplama();
                    break;
                case 3:
                    //Üçgen Hesaplama
                    ÜcgenAlanHesaplama();
                    break;
                case 4:
                    //Yamuk Hesaplama
                    YamukHesaplama();
                    break;
                default:
                    break;
            }
        }
        static void MenuYaz()
        {
            Console.Clear();


            EkranaBaslikYaz("Alan Hesaplama Uygulaması");
            EkranaBaslikYaz("Menü:");           
            Console.WriteLine("1) Kare Alanı Hesaplama");
            Console.WriteLine("2) Dikdörtgen Alanı Hesaplama");
            Console.WriteLine("3) Üçgen Alanı Hesaplama");
            Console.WriteLine("4) Yamuk Alanı Hesaplama");
            Console.WriteLine("0) Çıkış");
            Console.WriteLine();
        }

        static void EkranaBaslikYaz(string baslik)
        {
            Console.WriteLine(baslik);

            for (int i = 0; i < baslik.Length; i++)
            {
                Console.Write("-------------------");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Cikisİslemi()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen çıkış yapmak için bir tuşa başınız..");
            Console.ReadKey();
        }
        static void  KareAlanHesaplama()
        {
            Console.Clear();
            EkranaBaslikYaz("Kare Alan Hesaplama");
            Console.WriteLine("Lütfen a kenar uzunluğu giriniz: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Kare alanı: " + (a * a));

            Cikisİslemi();

        }
        static void DikdörtgenAlanHesaplama()
        {
            Console.Clear();
            EkranaBaslikYaz("Dikdörtgen Alan Hesaplama");
            Console.WriteLine("Lütfen a kenar uzunluğu giriniz: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen b kenar uzunluğunu giriniz: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dikdörtgen Alanı: " + a*b);
            Cikisİslemi();
            
        }
        static void ÜcgenAlanHesaplama()
        {
            Console.Clear();
            EkranaBaslikYaz("Üçgen Alan Hesaplama");
            Console.WriteLine("Lütfen a kenar uzunluğunu giriniz: ");
            int a = int.Parse (Console.ReadLine());
            Console.WriteLine("Lütfen h yükseklik değerini giriniz: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Üçgen Alanı: " + (Convert.ToDouble(a) * Convert.ToDouble(h)) /2d);
            Cikisİslemi();

        }
        static void YamukHesaplama()
        {
            Console.Clear();
            EkranaBaslikYaz("Yamuk Alan Hesaplama");
            Console.WriteLine("Lütfen a kenar uzunluğunu giriniz: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen b kenar uzunluğunu giriniz: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen h yükseklik değerini giriniz: ");
            int h = int.Parse(Console.ReadLine());

            double sub = (Convert.ToDouble(a) + Convert.ToDouble(b)) / 2d;
            double result = sub * Convert.ToDouble(h);

            Console.WriteLine();
            Console.WriteLine("Yamuk Alanı: " + result);
            Cikisİslemi();
        }

    }
}
