
Console.WriteLine("Kısa kenarı giriniz :");
int kısakenarinput  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Uzun kenarı giriniz :");
int uzunkenarinput = Convert.ToInt32(Console.ReadLine());

int AlanHesaplamaMetod(int kısakenar , int uzunkenar)
{
    int alan = kısakenar * uzunkenar;
    return alan;
}

int alansonucu = AlanHesaplamaMetod(kısakenarinput, uzunkenarinput);
Console.WriteLine($"Alanın hesap sonucu :{alansonucu}");