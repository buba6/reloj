/*
 * Created by SharpDevelop.
 * User: buba
 * Date: 02/03/2015
 * Time: 02:27 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace reeloj
{
	class Program
	{
		static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue
            	;
            Console.Clear();
            int h, m, s, x;
            int alarmaH, alarmaM, alarmaS;
            String alarma;
            Console.WriteLine("Introduce las horas");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce los minutos");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce los segundos");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quieres poner alarma, si o no");
            alarma = Convert.ToString(Console.ReadLine());


            if (alarma == "si")
            {
                Console.Clear();
                Console.WriteLine("Introduce las horas de la alarma");
                alarmaH = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce los minutos de la alarma");
                alarmaM = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce los segundos de la alarma");
                alarmaS = Convert.ToInt32(Console.ReadLine());

            }
            else
            {
                alarmaH = -1;
                alarmaM = -1;
                alarmaS = -1;
            }


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Son las {0}:{1}:{2}", h, m, s);
                x = Environment.TickCount;
                while (Environment.TickCount <= x + 1000) ;
                s = s + 1;
                if (alarmaH == h && alarmaM == m && alarmaS == s)
                {
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();

                }


                if (s == 60)
                {
                    s = 0;
                    m = m + 1;
                    if (m == 60)
                    {
                        m = 0;
                        h = h + 1;
                        if (h == 24)
                        {
                            h = 0;

                        }
                    }
                }




            }

        }

    }
	
}