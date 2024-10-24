class Program
{
    static void Main(string[] args)
    {
        // Yeni bir kitap oluştur
        Kitap kitap = new Kitap("Aylin", "Ayşe", 398);

        // Kitap bilgilerini yazdır
        Console.WriteLine("Kitap Adı: " + kitap.Ad);
        Console.WriteLine("Yazar: " + kitap.YazarAdi);
        Console.WriteLine("Sayfa Sayısı: " + kitap.SayfaSayisi);
    }
}
