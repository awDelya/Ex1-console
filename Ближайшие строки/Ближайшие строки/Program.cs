using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_methods;

namespace Ближайшие_строки
{
    class Program
    {
        private static int[] Num, Po;
        private static int x, y, min;
        private static void ReqInform()
        {
            Color.Print("\n Введите количество точек (от 2 до 1000000): ", ConsoleColor.Yellow);
            int q = Number.Check(2, 1000000);
            Num = new int[q];
            Po = new int[q];
            for (int i = 0; i < q; i++)
            {
                Console.Clear();
                Color.Print("\n Введите " + (i + 1) + " число (только положительные числа): ", ConsoleColor.Yellow);
                int z = Number.Check(0, int.MaxValue);
                Num[i] = z;
                Po[i] = z;
            }
        }
        private static void Process()
        {
            Array.Sort(Po);
            x = 0;
            y = 0;
            min = int.MaxValue;
            int tempDist = 0;
            for (int i = 0; i < Po.Length; i++)
            {
                try
                {
                    tempDist = Math.Abs(Po[i + 1] - Po[i]);
                }
                catch { }
                if (tempDist < min && tempDist != 0)
                {
                    min = tempDist;
                    x = Po[i];
                    y = Po[i + 1];
                }
            }
        }
        static void Main()
        {
            ReqInform();
            Process();
            Console.Clear();
            Color.Print("\n Минимальное расстояние между ближайшими точками равно: " + min, ConsoleColor.Cyan);
            Color.Print("\n Номера точек: " + (Array.IndexOf(Num, x) + 1) + " " + (Array.IndexOf(Num, y) + 1) + "\n", ConsoleColor.Cyan);
            Text.GoBackMenu();
        }
    }
}
