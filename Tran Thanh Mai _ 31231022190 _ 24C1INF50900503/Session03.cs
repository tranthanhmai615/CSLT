namespace Tran_Thanh_Mai___31231022190___24C1INF50900503
{
    internal class Session03
    {
        public static void Main()
        {
            //Question02();
            //Question03();
            //Question05();
            Console.ReadKey();
        }
        public static void Question02()
        {
            //Display certain values of the function x = y2 + 2y +1 (using integer numbers for y, ranging from -5 to +5)
            Console.Write("Nhap vao so nguyen y nam trong khoang -5 den 5: ");
            int y = int.Parse(Console.ReadLine());

            while (y < -5 || y > 5)
            {
                Console.WriteLine("Nhap lai y, y chi nam trong khoang -5 den 5: ");
                y = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ban da nhap vao y thoa man");
            int x;
            x = y * y + 2 * y + 1;
            Console.WriteLine($"Vay x= y2 + 2y + 1 = {y}*{y} + 2{y} + 1 = {x}");
        }
        public static void Question03()
        {
            //Takes distance and time (hours, minutes, seconds) as input and display speed in km/h and miles/h
            Console.Write("Nhap vao gio: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao phut: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao giay: ");
            int seconds = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao khoang cach (km): ");
            int distance = int.Parse(Console.ReadLine());
            double kmh = (double)distance / (hours + (minutes / 60.0f) + (seconds / 3600.0f));
            double mih = kmh / 1.609344;
            Console.WriteLine($"Toc do theo km/h = {kmh}");
            Console.WriteLine($"Toc do theo miles/h = {mih}");
        }
        public static void Question05()
        {
            //Takes a character as input and checks if it is a vowel, a digit, or any other symbol
            Console.Write("Ban hay nhap 1 ky tu: ");
            char x = char.Parse(Console.ReadLine());
            if (x == 'a' || x == 'o' || x == 'e' || x == 'u' || x == 'i' || x == 'A' || x == 'O' || x == 'E' || x == 'U' || x == 'I')
            {
                Console.WriteLine($"Ky tu ban vua nhap vao la chu cai nguyen am");
            }
            else if ((x >= '0') && (x <= '9'))
            {
                Console.WriteLine($"Ky tu ban vua nhap vao la chu so");
            }
            else
            {
                Console.WriteLine($"Ky tu ban vua nhap vao la ky tu khac");
            }
        }
    }
}