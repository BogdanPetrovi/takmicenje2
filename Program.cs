using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] a, b, c, d, g;
        int[,] f;
        int x, y, z, prethodnaVrednost, srednjaVrednost, indeksNajblize, najblizaRazlika;
        string palindrom;
        bool isTrue;

        Console.WriteLine("********ULAZ********");
        Console.WriteLine("Unesite broj elemenata niza N");
        int N = int.Parse(Console.ReadLine());
        if (N >= 5 && N < 50) {
            Console.WriteLine("Unesite elemente niza");
            a = new int[N];
            for (int i = 0; i < N; i++)
            {
                 a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Uneti celobrojnu vrednost x");
            x = int.Parse(Console.ReadLine());
            if (x > -50 && x < 50)
            {
                Console.WriteLine("Unesite broj izmena y");
                y = int.Parse(Console.ReadLine());
                if(y >= 1 && y <= 10)
                {
                    Console.WriteLine("Unesite broj rotacija z");
                    z = int.Parse(Console.ReadLine());


                    //1.1
                    b = new int[N  + 1];
                    for(int i = 0; i < a.Length; i++)
                    {
                        b[i] = a[i];
                    }
                    b[N] = x;
                    prethodnaVrednost = b[0];
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
                    Console.Write("\n\n");

                    //1.2
                    c = new int[N];
                    for (int i=0; i < N; i++)
                    {
                        c[i] = a[i];
                    }

                    srednjaVrednost = 0;
                    for(int i = 0; i < c.Length; i++)
                    {
                        if (i % 2 == 0 && c[i] % 2 != 0)
                        {
                            c[i] = c[i] ^ i;
                        }
                        srednjaVrednost += c[i];
                    }
                    srednjaVrednost = srednjaVrednost / c.Length; 
                    indeksNajblize = 0;
                    najblizaRazlika = Math.Abs(c[0] - srednjaVrednost);

                    for (int i=1; i < c.Length; i++)
                    {
                        if ((Math.Abs(c[i] - srednjaVrednost)) < najblizaRazlika)
                        {
                            najblizaRazlika = Math.Abs(c[i] - srednjaVrednost);
                            indeksNajblize = i;
                    }
                        else if ((Math.Abs(c[i] - srednjaVrednost)) == najblizaRazlika)
                        {
                            if (i < indeksNajblize)
                            {
                                indeksNajblize = i;
                            }
                        }
                    }
                    g = new int[N-1];
                    for (int i = indeksNajblize + 1; i < c.Length; i++)
                    {
                        c[i - 1] = c[i];
                    }
                    for(int i = 0; i<g.Length; i++)
                    {
                        g[i] = c[i];
                    }
                    Console.WriteLine("\n******** odgovor 2 ********");
                    for (int i = 0; i < g.Length; i++)
                    {
                        Console.Write(g[i] + " ");
                    }
                    Console.Write("\n\n");

                    //1.3
                    d = new int[N];
                    palindrom = "";

                    for (int i = 0; i < N; i++)
                    {
                        if (Math.Abs(a[i]) > 0 && Math.Abs(a[i]) < 10) {
                            d[i] = Math.Abs(a[i]);
                        }
                        else
                        {
                            d[i] = a[i] % 10;
                        }
                        palindrom = palindrom + d[i].ToString();
                    }

                    isTrue = true;
                    for (int i = 0; i < palindrom.Length / 2 - 1; i++)
                    {
                        for (int j = palindrom.Length - 1; j > palindrom.Length / 2 - 1; i--)
                        {
                            if (palindrom[i] != palindrom[j])
                            {
                                isTrue = false;
                            }
                        }
                    }
                    if(isTrue)
                    {
                        Console.WriteLine("broj je palindrom" + isTrue + " " + palindrom + " " + palindrom.Length);
                    }
                    else
                    {
                        Console.WriteLine("broj nije palindrom");
                    }



                    //1.4
                    // f = new int[N, N+1];
                    // for(int i = 0 ; i<N ; i++)
                    // {
                    //     for(int j = 0 ; j <= N; j++)
                    //     {
                    //         a[j] = a[j] * j;
                    //         f[i,j] = a[j];
                    //         Console.Write(f[i, j] + "\t");  
                    //     }
                    //     Console.WriteLine();
                    // }

                }
                else { Console.WriteLine("Broj nije u opsegu"); }
            }
            else { Console.WriteLine("Broj nije u opsegu"); }
        } else { Console.WriteLine("Broj nije u opsegu"); }

    }
}
