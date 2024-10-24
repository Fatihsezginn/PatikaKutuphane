public class Kitap
{
    public string Ad; // Kitap adı
    public string YazarAdi; // Yazar adı
    public int SayfaSayisi; // Sayfa sayısı

    public Kitap(string ad, string yazarAdi, int sayfaSayisi)
    {
        Ad = ad; // Kitap adını ayarlıyoruz
        YazarAdi = yazarAdi; // Yazar adını ayarlıyoruz
        SayfaSayisi = sayfaSayisi; // Sayfa sayısını ayarlıyoruz
    }
}
