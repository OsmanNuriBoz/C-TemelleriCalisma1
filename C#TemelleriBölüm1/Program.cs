Console.WriteLine("1.Sayıyı giriniz :");
int bırıncısayı = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2.Sayıyı giriniz :");
int ıkıncısayı = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1.İsimi giriniz :");
string bırıncıısım = Console.ReadLine();
Console.WriteLine("2.İsimi giriniz :");
string ıkıncıısım = Console.ReadLine();

int sayılarıncarpımımetod(int sayi1, int sayi2)
{
    int sayılarıncarpımı = sayi1 * sayi2;
    return sayılarıncarpımı;
}

string ısımbırlestırmemetod(string isim1, string isim2)
{
    string ısımbırlestırme = $"{isim1}_{isim2}";
    return ısımbırlestırme;
}

int sayılarıncarpımısonucu = sayılarıncarpımımetod(bırıncısayı, ıkıncısayı);
Console.WriteLine($"Girilen sayının çarpımı : {sayılarıncarpımısonucu}");

string ısımbırlesımısonucu = ısımbırlestırmemetod(bırıncıısım, ıkıncıısım);
Console.WriteLine($"Girilen ismin birleşimi : {ısımbırlesımısonucu}");