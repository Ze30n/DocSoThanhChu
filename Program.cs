internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao so can doc");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a >= 0)
        {
            if (a<=10)
            {
            switch (a)
            {
            case 0: Console.Write("Khong"); break;
            case 1: Console.Write("Mot"); break;
            case 2: Console.Write("Hai"); break;
            case 3: Console.Write("Ba"); break;
            case 4: Console.Write("Bon"); break;
            case 5: Console.Write("Nam"); break;
            case 6: Console.Write("Sau"); break;
            case 7: Console.Write("Bay"); break;
            case 8: Console.Write("Tam"); break;
            case 9: Console.Write("Chin"); break;
            case 10: Console.Write("Muoi"); break;
            default: break;
            }
            }
            int tram = a/100;
            int chuc = (a/10)%10;
            int donvi = (a % 100)%10;
            
            switch (tram)
            {
            case 1: Console.Write("Mot"); break;
            case 2: Console.Write("Hai"); break;
            case 3: Console.Write("Ba"); break;
            case 4: Console.Write("Bon"); break;
            case 5: Console.Write("Nam"); break;
            case 6: Console.Write("Sau"); break;
            case 7: Console.Write("Bay"); break;
            case 8: Console.Write("Tam"); break;
            case 9: Console.Write("Chin"); break;
            default: break;
            }
            Console.Write(" tram ");
            switch (chuc)
            {
            case 0: Console.Write("Linh"); break;
            case 1: Console.Write("Muoi"); break;
            case 2: Console.Write("Hai muoi"); break;
            case 3: Console.Write("Ba muoi"); break;
            case 4: Console.Write("Bon muoi"); break;
            case 5: Console.Write("Nam muoi"); break;
            case 6: Console.Write("Sau muoi"); break;
            case 7: Console.Write("Bay muoi"); break;
            case 8: Console.Write("Tam muoi"); break;
            case 9: Console.Write("Chin muoi"); break;
                default: break;
            }

            switch (donvi)
            {
            case 0: Console.Write(" "); break;
            case 1: Console.Write(" Mot"); break;
            case 2: Console.Write(" Hai"); break;
            case 3: Console.Write(" Ba"); break;
            case 4: Console.Write(" Tu"); break;
            case 5: Console.Write(" Nam"); break;
            case 6: Console.Write(" Sau"); break;
            case 7: Console.Write(" Bay"); break;
            case 8: Console.Write(" Tam"); break;
            case 9: Console.Write(" Chin"); break;
                default: break;
            }

            //Console.WriteLine($"{tram} tram {chuc} {donvi}");

        } else
        {
            Console.WriteLine("Nhap dung so can doc > 0");
        }
    }
}