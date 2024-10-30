using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trần_Thanh_Mai___31231022190___24C1INF50900503
{
    /// <summary>
    /// Máy tính đỗ 3 con xúc sắc ngẫu nhiên
    /// Người chơi sẽ đoán là tài hay xỉu
    /// </summary>
    class game_Taixiu
    {
        static int rollDice ()
        {
            Random rnd = new Random();
            int die_1 = rnd.Next(6) + 1;
            int die_2 = rnd.Next(6) + 1;
            int die_3 = rnd.Next(6) + 1;
            int sum_of_dice = die_1 + die_2 + die_3;
            return sum_of_dice;
        }
        static void playOneround()
        {
            int com_dice = rollDice();
            Console.Write("Ban doan Tai hay Xiu <T/X>");
            string user_guessing = Console.ReadLine();
            if (user_guessing.ToUpper().Equals("T"))
            {
                if (com_dice >= 10)//Tai
                    Console.WriteLine("Ban thang: ");
                else
                    Console.WriteLine("Ban thua: ");
            }
            else if (user_guessing.ToUpper().Equals("X"))
            {
                if (com_dice < 10)//Xiu
                    Console.WriteLine("Ban thang: ");
                else
                    Console.WriteLine("Ban thua: ");
            }
            else
            {
                Console.WriteLine("Vui long chon dung");
            }
        }
        static void game_engine()
        {
            do
            {
                playOneround();
                Console.Write("Ban choi nua khong? <C/K>");
                string choice = Console.ReadLine();
                if (choice.ToUpper().Equals ("K"))
                    break;
            } while (true);
            Console.WriteLine("Mai choi nua nhe!");
        }
        public static void Main ()
        {
            game_engine();
        }
    }

}
