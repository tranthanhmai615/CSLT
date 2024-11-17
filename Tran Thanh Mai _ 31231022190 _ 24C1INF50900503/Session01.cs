namespace Tran_Thanh_Mai___31231022190___24C1INF50900503
{
    internal class Session01
    {
        public static void Main()
        {
            //Question_01(); 
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();
            //Question_09();
            //Question_10();
            Console.ReadKey();
        }
        public static void Question_01()
        {
            //cộng 2 số
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.Write($"{a} + {b} = {c}");
        }
        public static void Question_02()
        {
            //đổi chỗ 2 giá trị
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.Write($"Sau hoan doi: a = {b} , b ={c} , c={a}");
        }
        public static void Question_03()
        {
            //nhân 2 số
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = a * b;
            Console.Write($"{a} * {b} = {c}");
        }
        public static void Question_04()
        {
            Console.Write("Nhap so feet: ");
            double feet = double.Parse(Console.ReadLine());
            double meter = feet * 0.3048f;
            Console.Write($"Chuyen Feet sang Meter = {meter}");
        }
        public static void Question_05()
        {
            //độ C sang độ f và ngược lại
            Console.Write("Nhap do C: ");
            double c = double.Parse(Console.ReadLine());
            double f = c * 9 / 5 + 32;
            Console.WriteLine($"{c}°C se bang {f}°F");
            Console.Write("Nhap do F: ");
            double F = double.Parse(Console.ReadLine());
            double C = (F - 32) * 5 / 9;
            Console.WriteLine($"{F}°F se bang {C}°C");
        }
        public static void Question_06()
        {
            //kích thước của kiểu dữ liệu
            Console.WriteLine("Kich thuoc cua kieu du lieu int la: " + sizeof(int));
            Console.WriteLine("Kich thuoc cua kieu du lieu char la: " + sizeof(char));
            Console.WriteLine("Kich thuoc cua kieu du lieu double la: " + sizeof(double));
            Console.WriteLine("Kich thuoc cua kieu du lieu float la: " + sizeof(float));
        }
        public static void question_07()
        {
            //character to asciii
            Console.Write("Nhap gi do di: ");
            var x = Console.ReadLine();
            foreach (char c in x) Console.Write((int)c + " ");
            //char x = 'a';
            //int num = x;
            //Console.WriteLine($"{x} in ASCII = {num}");
        }
        public static void question_08()
        {
            //tinh dien tich hinh tron
            Console.Write("Nhap ban kinh hinh tron: ");
            float x = float.Parse(Console.ReadLine());
            double S = x * x * 3.14;
            Console.Write($"Dien tich hinh tron la: {S}");
        }
        public static void question_09()
        {
            //tinh dien tich hinh vuong
            Console.Write("Nhap ban kinh hinh vuong: ");
            float x = float.Parse(Console.ReadLine());
            double S = x * x;
            Console.Write($"Dien tich hinh vuong la: {S}");
        }
        public static void Question_10()
        {
            // days to year, week and days
            Console.Write("Nhap so ngay can tinh: ");
            int d = int.Parse(Console.ReadLine());
            int y = d / 365;
            int w = (d - y * 365) / 7;
            int d2 = d - y * 365 - w * 7;
            Console.Write($"{d} days = {y} years, {w} weeks, {d2} days");
        }
    }
}
