namespace KullaniciVeriDeposu.KisiselBilgi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı girin: ");
            string ad = Console.ReadLine();

            Console.Write("Soyadınızı girin: ");
            string soyad = Console.ReadLine();

            Console.Write("Yaşadığınız il/ilçeyi girin: ");
            string ilIlce = Console.ReadLine();

            Console.Write("Mesleğinizi girin: ");
            string meslek = Console.ReadLine();

            Console.Write("Yaşınızı girin: ");
            string yasGelenDeger = Console.ReadLine();
            int yas = int.Parse(yasGelenDeger);

            Console.WriteLine($"{ad} {soyad} Merhaba, {ilIlce} bölgesinde {meslek} mesleğini yapıyorsunuz. {yas} yaşındasınız.");
        }
    }
}
