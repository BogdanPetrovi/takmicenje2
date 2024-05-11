using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********ULAZ********");
        Console.WriteLine("Unesite broj elemenata niza N");
        int N = int.Parse(Console.ReadLine());
        if (N >= 5 && N < 50) {
            Console.WriteLine("Unesite elemente niza");
            int[] a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Uneti celobrojnu vrednost x");
            int x = int.Parse(Console.ReadLine());
            if (x > -50 && x < 50)
            {
                Console.WriteLine("Unesite broj izmena y");
                int y = int.Parse(Console.ReadLine());
                if(y >= 1 && y <= 10)
                {
                    Console.WriteLine("Unesite broj rotacija z");
                    int z = int.Parse(Console.ReadLine());


                    //1.1
                    int[] b = new int[N  + 1];
                    for(int i = 0; i < a.Length; i++)
                    {
                        b[i] = a[i];
                    }
                    b[N] = x;
                    int prethodnaVrednost = b[0];
                    for(int i = 1; i < b.Length; i++)
                    {
                        if (b[i-1] > b[i])
                        {
                            prethodnaVrednost = b[i - 1];
                            b[i - 1] = b[i];
                            b[i] = prethodnaVrednost;
                            i = 1;
                        }
                    }
                    Console.WriteLine("******** odgovor 1 ********");
                    for(int i = 0; i < b.Length; i++)
                    {
                        Console.Write(b[i] + " ");
                    }










                } else { Console.WriteLine("Broj nije u opsegu"); }
            }
            else { Console.WriteLine("Broj nije u opsegu"); }
        } else { Console.WriteLine("Broj nije u opsegu"); }

    }
}
