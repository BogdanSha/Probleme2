using System.Globalization;

namespace Probleme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CatePare();
            //CatePlusMinusZero();
            //SumaProdusN();
            //PozNrA();
            //CateNumereEgalePoz();
            //ECrescatoare();
            //MinimMaxim();
            //Fibo();
            //Monotonie();
            //CateConsecutiveEgale();
            //SumaInverse();
            //CateDiferiteDeZero();
            //SecventaBitonica();
            //Paranteze();
        }
        /// <summary>
        /// Se da o secventa de 0 si 1, 0 fiind paranteza deschisa iar 1 paranteza inchisa
        /// Se verifica daca parantezele sunt scrise corect iar in caz afirmativ se scrie nivelul lor de incuibare
        /// </summary>
        private static void Paranteze()
        {
            int n, count = 1,openCount=1,closeCount=0;
            n= int.Parse(Console.ReadLine());
            int first,next=0;
            bool point = true;
            first= int.Parse(Console.ReadLine());
            if (first == 1)
            {
                point = false;
            }
            for (int i = 2; i <= n; i++)
            {
                next= int.Parse(Console.ReadLine());
                if(first==0 && next == 0)
                {
                    count++;
                }
                if (next == 0)
                {
                    openCount++;
                }
                if (next == 1)
                {
                    closeCount++;
                }
                first = next;
            }
            if (next == 0 || point==false)
            {
                Console.WriteLine("Parantezele sunt scrise incorect");
                return;
            }
            if (openCount == closeCount)
            {
                Console.WriteLine($"Parantezele sunt scrise corect iar nivelul lor de incuibare este {count}");
            }
            else
            {
                Console.WriteLine("Parantezele sunt scrise incorect");
            }
        }

        /// <summary>
        /// Se verifica daca o secventa data este bitonica
        /// </summary>
        private static void SecventaBitonica()
        {
            int n, x1, x2,i;
            bool point = true;
            n= int.Parse(Console.ReadLine());
            x1 = int.Parse(Console.ReadLine());
            for (i = 2; i <= n && point == true; i++)
            {
                x2= int.Parse(Console.ReadLine());
                if (x1 > x2)
                {
                    point = false;
                }
                x1 = x2;
            }
            if (i != n)
            {
                point = true;
            }
            for(int j = i; j <= n; j++)
            {
                x2= int.Parse(Console.ReadLine());
                if (x1<x2)
                {
                    point = false;
                }
                x1 = x2;
            }
            if (point == true)
            {
                Console.WriteLine("Secventa data este bitonica");
            }
            else
            {
                Console.WriteLine("Secventa data nu este bitonica");
            }
        }

        /// <summary>
        /// Se calculeaza numarul de secvente consecutive diferite de zero dintr-o alta secventa
        /// </summary>
        private static void CateDiferiteDeZero()
        {
            int n, count = 0, x1, x2;
            n= int.Parse(Console.ReadLine());
            x1= int.Parse(Console.ReadLine());
            for(int i = 2; i <= n; i++)
            {
                x2= int.Parse(Console.ReadLine());
                if((x1!=0 && x2 == 0) ||(x1==0 && x2!=0))
                {
                    count++;
                }
                x1 = x2;
            }
            Console.WriteLine($"Numarul de secvente diferite de zero este {count}");
        }

        /// <summary>
        /// Se calculeaza suma inverselor unor numere dintr-o secventa
        /// </summary>
        private static void SumaInverse()
        {
            int n, s = 0, x;
            n= int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                x= int.Parse(Console.ReadLine());
                s += Invers(x);
            }
            Console.WriteLine($"Suma inverselor numerelor secventei este {s}");
        }
        /// <summary>
        /// Se calculeaza inversul unui numar
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static int Invers(int x)
        {
            int inv = 0;
            while(x > 0)
            {
                inv = inv * 10 + x % 10;
                x /= 10;
            }
            return inv;
        }

        /// <summary>
        /// Se afla numarul maxim de elemente consecutive egale dintr-o secventa
        /// </summary>
        private static void CateConsecutiveEgale()
        {
            int n, count = 0, x1, x2;
            n= int.Parse(Console.ReadLine());
            x1 = int.Parse(Console.ReadLine());
            for(int i = 2; i <= n; i++)
            {
                x2= int.Parse(Console.ReadLine());
                if (x1 == x2)
                {
                    count++;
                }
            }
            Console.WriteLine($"Numarul maxim de elemente consecutive egale este {count}");
        }

        /// <summary>
        /// Se verifica daca o secventa este monotona
        /// </summary>
        private static void Monotonie()
        {
            int n, x1,x2,x3;
            bool point = true;
            n= int.Parse(Console.ReadLine());
            x1= int.Parse(Console.ReadLine());
            x2= int.Parse(Console.ReadLine());
            for(int i = 3; i <= n; i++)
            {
                x3 = int.Parse(Console.ReadLine());
                if((x1>x2&& x2 < x3) || (x1 < x2 && x2 > x3))
                {
                    point = false;
                }
                x1 = x2;
                x2 = x3;
            }
            if (point == true)
            {
                Console.WriteLine("Secventa data este monotona");
            }
            else
            {
                Console.WriteLine("Secventa data nu este monotona");
            }
        }

        private static void Fibo()
        {
            int n, f1, f2, fn;
            n= int.Parse(Console.ReadLine());
            f1 = 0;
            f2 = 1;
            n -= 2;
            Console.Write(f1+ " " + f2+" ");
            while (n > 0)
            {
                fn = f1 + f2;
                Console.Write(fn + " ");
                f1 = f2;
                f2 = fn;
                n--;
            }
        }

        /// <summary>
        /// Se afla minimul si maximul dintr-o secventa
        /// </summary>
        private static void MinimMaxim()
        {
            int min, max, n, x;
            n= int.Parse(Console.ReadLine());
            x= int.Parse(Console.ReadLine());
            min = max = x;
            for(int i = 2; i <= n; i++)
            {
                x= int.Parse(Console.ReadLine());
                if (x > max)
                {
                    max = x;
                }
                if (x < min)
                {
                    min = x;
                }
            }
            Console.WriteLine($"Numarul minim din secventa este {min}, iar cel maxim este {max}");
        }

        /// <summary>
        /// Se verifica daca numerele dintr-o secventa sunt in ordine crescatoare
        /// </summary>
        private static void ECrescatoare()
        {
            int n,x1,x2;
            bool point = true;
            n= int.Parse(Console.ReadLine());
            x1 = int.Parse(Console.ReadLine());
            for(int i = 2; i <= n; i++)
            {
                x2 = int.Parse(Console.ReadLine());
                if (x1 > x2)
                {
                    point = false;
                }
                x1 = x2;
            }
            if (point == true)
            {
                Console.WriteLine("Numerele din secventa sunt in ordine crescatoare");
            }
            else
            {
                Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare");
            }
        }

        /// <summary>
        /// Se verifica cate numere dintr-o secventa sunt egale cu pozitia pe care se afla
        /// </summary>
        private static void CateNumereEgalePoz()
        {
            int n, count = 0, x;
            n=int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                x= int.Parse(Console.ReadLine());
                if (x == i)
                {
                    count++;
                }
            }
            Console.WriteLine($"Numarul de elemente egale cu pozitia pe care apar in secventa este {count}");

        }

        /// <summary>
        /// Se afla pozitia unui nr a dintr-o secventa data, daca nr nu se afla in secventa se afiseaza -1
        /// </summary>
        private static void PozNrA()
        {
            int n,i,a,x;
            int pozitie = -1;
            n=int.Parse(Console.ReadLine());
            a=int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                x= int.Parse(Console.ReadLine());
                if (x == a)
                {
                    pozitie = i;
                }
            }
            if (pozitie < 0)
            {
                Console.WriteLine($"Numarul {a} nu se afla in secventa");
            }
            else
            {
                Console.WriteLine($"Numarul {a} se afla in secventa iar pozitia sa este {pozitie}");
            }
        }

        /// <summary>
        /// Se face suma si produsul numerelor de la 1 la n;
        /// </summary>
        private static void SumaProdusN()
        {
            int n,s=0,p=1;
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                s += i;
                p *= i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n} este {s}, iar produsul lor este {p}");
        }

        /// <summary>
        /// Se dau n numere si se verifica care din ele sunt pozitive, negative si respectiv 0
        /// </summary>
        private static void CatePlusMinusZero()
        {
            int cminus = 0, cplus = 0, czero = 0,n;
            n=int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > 0)
                {
                    cplus++;
                }
                if (x == 0)
                {
                    czero++;
                }
                if (x < 0)
                {
                    cminus++;
                }
            }
            Console.WriteLine($"{cplus} numere sunt pozitive, {cminus} sunt negative si {czero} sunt egale cu 0");
        }

        /// <summary>
        /// Se dau n numere si se verifica cate dintre ele sunt pare
        /// </summary>
        private static void CatePare()
        {
            int n;
            int count = 0;
            n =int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int x;
                x=int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} numere din secventa sunt pare");
        }
    }
}