using System;

namespace inluppg5_7A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nummer = { 1111, 3333, 45, 9999999, 77777};
            string[] fakeNummer = new string[nummer.Length];

            for (int i = 0; i < nummer.Length; i++)
            {
                fakeNummer[i] = nummer[i].ToString();
            }

            System.Threading.Thread.Sleep(300);

            for(int i = 0;  i < nummer.Length; i++)
            {
                for (int j = 0; j < fakeNummer[i].Length; j++)
                {

                    Console.Write(fakeNummer[i][0]);
                    System.Threading.Thread.Sleep(300);
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(600);
            }
        }
    }
}