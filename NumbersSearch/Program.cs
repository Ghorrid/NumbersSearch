using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersSearch
{
    internal class Program
    {
        #region descritpion
        //            Zadanie 3:
        //-Stwórz metodę, które przyjmuje 2 argumenty typu int(num1, oraz num2) i zwraca true
        //jeżeli jakaś cyfra powtarza się 3 razy z rzędu(jedna za drugą)
        //w liczbie num1 i ta sama cyfra powtarza się 2 razy z rzędu(jedna za drugą) w liczbie num2.
        //Przykład
        //- Dla parametrów 12777121 oraz 771231 zostanie zwrócone 'true'
        //- Dla parametrów 92727121 oraz 871231 zostanie zwrócone 'false'
        //- Dla parametrów 3252111 oraz 14137117 zostanie zwrócone 'true'
        //- Dla parametrów 2121212121 oraz 131313 zostanie zwrócone 'false'
        #endregion

        public static bool NumbersSearch(int num1, int num2)
        {
          

            string[] numbers1 = { "111", "222", "333", "444", "555", "666", "777", "888", "999", "000" };
            string[] numbers2 = { "11", "22", "33", "44", "55", "66", "77", "88", "99", "00" };
            bool check1 = false;
            bool check2 = false;

            for (int i = 0; i < numbers1.Length; i++)
            {

                if (num1.ToString().Contains(numbers1[i]))
                {
                    check1 = true;
                    if (num2.ToString().Contains(numbers2[i])) check2 = true;
                }
            }
            if (check1 && check2) return true;
            else return false;
        }

        static void Main(string[] args)
        {
            //- Dla parametrów 12777121 oraz 771231 zostanie zwrócone 'true'
            //- Dla parametrów 92727121 oraz 871231 zostanie zwrócone 'false'
            //- Dla parametrów 3252111 oraz 14137117 zostanie zwrócone 'true'
            //- Dla parametrów 2121212121 oraz 131313 zostanie zwrócone 'false'

            Console.WriteLine("Metoda zwraca true jakaś cyfra powtarza się 3 razy z rzędu" +
                " w liczbie num 1 (1 parametr) i ta sama cyfra powtarza się 2 razy z rzędu w 2 parametrze: ");
            Console.WriteLine(NumbersSearch(12777121, 771231));
            Console.WriteLine(NumbersSearch(92727121, 871231));
            Console.WriteLine(NumbersSearch(3252111, 14137117));
            Console.WriteLine(NumbersSearch(2121212121, 131313));

            Console.ReadKey();
        }
    }
}
