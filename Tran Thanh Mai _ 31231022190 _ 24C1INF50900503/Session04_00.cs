namespace Tran_Thanh_Mai___31231022190___24C1INF50900503
{
    internal class Session04_00
    {
        public static void Main()
        {
            do
            {
                //1.may nghi ngau nhien 1 so
                Random rnd = new Random();
                int comp_num = rnd.Next(0, 10) + 1;
                //2. hoi nguoi dung doan so
                //doan cho den chung nao dung thi thoi
                int count = 0;
                bool isContinue = true;
                do
                {
                    count++;
                    Console.Write("Ban doan so may? <1..10>");
                    int user_num = int.Parse(Console.ReadLine());
                    //3. kiem tra ket qua
                    if (user_num == comp_num)
                    {
                        Console.WriteLine($"Ban doan trung sau {count} lan");
                        isContinue = false;
                    }
                    else
                    {
                        if (user_num > comp_num)
                            Console.WriteLine("So ban doan lon hon so may nghi: ");
                        else
                            Console.WriteLine("So ban doan nho hon so may nghi: ");
                    }
                } while (isContinue);
                Console.WriteLine("==================================");
                Console.Write("Choi nua khong? <C/K>: ");
                string tl = Console.ReadLine();
                if (tl.ToUpper().Equals("K"))
                {
                    Console.WriteLine("Thang ma cho go. Lan sau khong choi nua!");
                    return;
                }
            } while (true);
        }
    }
}