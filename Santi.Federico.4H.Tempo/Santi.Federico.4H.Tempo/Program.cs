using System;

namespace Santi.Federico._4H.Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma orario di Santi Federico");
            string ora1 = "12:11:29";
            string ora2 = "07:15:46";
            TimeSpan TSora2 =TimeSpan.Parse(ora2);
            DateTime Orario1;
            DateTime Orario2;
            Orario1 = DateTime.Parse(ora1);
            Console.WriteLine(Orario1);
            
            Orario2 = DateTime.Parse(ora2);
            Console.WriteLine(Orario2);
            tempo tempo1 = new tempo(Orario1, Orario2);
            Console.WriteLine("Differenza orari");
            Console.WriteLine(tempo1.DiffOrario());
            Console.WriteLine("Somma orari");
            Console.WriteLine(tempo1.SommaOrario(TSora2));


        }
        class tempo
        {
            public DateTime Orario1 { get; set; }
            public DateTime Orario2 { get; set; }
            public tempo(DateTime Ora1, DateTime Ora2)
            {
                Orario1 = Ora1;
                Orario2 = Ora2;
            }
            public TimeSpan DiffOrario()
            {
                TimeSpan differenza;
                differenza = Orario1 - Orario2;
                return differenza;
            }
            public DateTime SommaOrario(TimeSpan ora2)
            {
                DateTime somma = Orario1.Add(ora2);
                return somma;
              

            }

          
           
        }
    }
}
