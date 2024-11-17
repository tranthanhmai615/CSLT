namespace Tran_Thanh_Mai___31231022190___24C1INF50900503
{
    internal class Session06_01
    {
        //Hàm tạo mảng số nguyên ngẫu nhiên
        public static int[] Taomangngaunhien(int kichthuoc, int nho, int lon)
        {
            int[] a = new int[kichthuoc];
            Random rand = new Random();
            for (int i = 0; i < kichthuoc; i++)
            {
                a[i] = rand.Next(nho, lon + 1);
            }
            return a;
        }
        //Hàm tính giá trị trung bình của các phần tử
        public static float Trungbinh(int[] a)
        {
            float Tb;
            int Sum = 0;
            for (int i = 0; i < a.Length; i++)
            { Sum += a[i]; }
            Tb = (float)Sum / a.Length;
            return Tb;
        }
        //Hàm kiểm tra mảng có chứa giá trị cụ thể hay không
        public static bool Kiemtra(int[] a1, int value)
        {
            foreach (int phantu in a1)
            {
                if (phantu == value) return true;
            }
            return false;
        }
        //Hàm tìm chỉ số của một phần tử trong mảng
        public static int Timchiso(int[] a2, int val)
        {
            for (int i = 0; i < a2.Length; i++)
            {
                if (a2[i] == val) return i;
            }
            return -1;
        }
        //Hàm xóa 1 phần tử cụ thể khỏi mảng
        public static int[] Xoaphantu(int[] a3, int giatri)
        {
            int index = Array.IndexOf(a3, giatri);
            if (index == -1)
            {
                Console.WriteLine($"Gia tri {giatri} khong ton tai trong mang");
                return a3;
            }
            int[] mangmoi = new int[a3.Length - 1];
            Array.Copy(a3, 0, mangmoi, 0, index);
            Array.Copy(a3, index + 1, mangmoi, index, a3.Length - index - 1);
            return mangmoi;
        }

        //Hàm tìm giá trị lớn nhất trong mảng
        public static int Timmax(int[] a4)
        {
            int lonnhat = a4[0];
            for (int i = 1; i < a4.Length; i++)
            {
                int n = a4[i];
                if (n > lonnhat)
                    lonnhat = n;
            }
            return lonnhat;
        }
        //Hàm tìm giá trị nhỏ nhất trong mảng
        public static int Timmin(int[] a5)
        {
            int nhonhat = a5[0];
            foreach (int giatri in a5)
                if (giatri < nhonhat)
                {
                    nhonhat = giatri;
                }
            return nhonhat;
        }
        //Hàm đảo ngược mảng
        public static void Daonguocmang(int[] a6)
        {
            int trai = 0;
            int phai = a6.Length - 1;
            while (trai < phai)
            {
                int temp = a6[trai];
                a6[trai] = a6[phai];
                a6[phai] = temp;

                trai++;
                phai--;
            }
        }

        //Hàm tìm giá trị trùng lặp
        public static void laplai(int[] a7)
        {
            Array.Sort(a7);
            int temp = 0;
            Console.WriteLine("Cac phan tu bi lap lai: ");
            for (int i = 0; i < a7.Length; i++)
            {
                for (int j = i + 1; j < a7.Length; j++)
                {
                    if (a7[i] != temp) if (a7[j] == a7[i])
                        {
                            Console.WriteLine(a7[i] + "\t");
                        }
                    break;
                }
                temp = a7[i];
            }
            Console.WriteLine();
        }


        //Xóa giá trị trùng lặp
        public static void xoalaplai(int[] a8)
        {
            int[] xll = a8.Distinct().ToArray();
            Console.WriteLine("Mang sau khi xoa cac phan tu lap: ");
            {
                for (int i = 0; i < xll.Length; i++)
                    Console.Write(xll[i] + "\t");
            }
        }



        public static void Main()
        {
            //Nhập thông tin người dùng
            Console.WriteLine("NHAP GIA TRI MANG");
            Console.Write("Nhap kich thuoc cua mang: ");
            int kichthuoc = int.Parse(Console.ReadLine());

            Console.Write("Nhap gia tri nho nhat cua so ngau nhien: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri lon nhat cua so ngau nhien: ");
            int max = int.Parse(Console.ReadLine());
            //Tạo mảng ngẫu nhiên
            int[] mangngaunhien = Taomangngaunhien(kichthuoc, min, max);
            //Hiển thị mảng ngẫu nhiên
            Console.WriteLine("Mang ngau nhien duoc tao: ");
            foreach (int giatri in mangngaunhien)
            {
                Console.Write(giatri + " ");
            }
            Console.WriteLine();


            Console.WriteLine("TINH GIA TRI TRUNG BINH CUA MANG");
            float av = Trungbinh(mangngaunhien);
            Console.WriteLine($"Gia tri trung binh: {av}");


            Console.WriteLine();
            Console.WriteLine("KIEM TRA GIA TRI TRONG MANG");
            Console.Write("Nhap gia tri can tim: ");
            int giatricantim = int.Parse(Console.ReadLine());
            bool coko = Kiemtra(mangngaunhien, giatricantim);
            if (coko)
            {
                Console.WriteLine($"Mang co chua {giatricantim}");
            }
            else
            { Console.WriteLine($"Mang khong chua {giatricantim}"); }


            Console.WriteLine();
            Console.WriteLine("TIM CHI SO CUA GIA TRI TRONG MANG");
            int chiso = Timchiso(mangngaunhien, giatricantim);
            if (chiso != -1)
            {
                Console.WriteLine($"Gia tri {giatricantim} nam tai chi so {chiso}");
            }
            else
                Console.WriteLine($"Gia tri {giatricantim} khong ton tai trong mang");


            Console.WriteLine();
            Console.WriteLine("XOA PHAN TU TRONG MANG");
            Console.WriteLine("Nhap gia tri can xoa khoi mang");
            int giatricanxoa = int.Parse(Console.ReadLine());
            int[] mangSaukhixoa = Xoaphantu(mangngaunhien, giatricanxoa);
            Console.WriteLine("Mang sau khi xoa phan tu: ");
            foreach (int giatri in mangSaukhixoa)
            {
                Console.Write(giatri + " ");
            }
            Console.ReadKey();

            Console.WriteLine();
            int lonnhat = Timmax(mangngaunhien);
            int nhonhat = Timmin(mangngaunhien);
            Console.WriteLine($"Gia tri lon nhat trong mang: {lonnhat}");
            Console.WriteLine($"Gia tri nho nhat trong mang: {nhonhat}");



            Console.WriteLine();
            Console.WriteLine("DAO NGUOC MANG");
            Daonguocmang(mangngaunhien);
            Console.WriteLine("Mang sau khi dao nguoc: ");
            foreach (int giatri in mangngaunhien)
            {
                Console.Write(giatri + " ");
            }



            Console.WriteLine();
            Console.WriteLine("IN PHAN TU LAP LAI");
            laplai(mangngaunhien);
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine("XOA CAC PHAN TU LAP LAI");
            xoalaplai(mangngaunhien);
            Console.WriteLine();



            Console.ReadKey();
        }



    }
}