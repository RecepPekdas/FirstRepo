namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi\n");
            Console.Write("Birinci Sayıyı Giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İşlem Seçiniz(+,-,/,*): ");
            string islem = Console.ReadLine();
            Console.Write("İkinci Sayıyı Giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
        }
    }
}