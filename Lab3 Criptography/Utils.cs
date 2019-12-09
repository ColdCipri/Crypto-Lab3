using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Criptography
{
    public static class Utils
    {
        public static Dictionary<char, int> alphabet = new Dictionary<char, int>(27) { };
        public static Random random = new Random();
        public static void generateDictionary()
        {
            alphabet.Add(' ', 0);
            alphabet.Add('A', 1);
            alphabet.Add('B', 2);
            alphabet.Add('C', 3);
            alphabet.Add('D', 4);
            alphabet.Add('E', 5);
            alphabet.Add('F', 6);
            alphabet.Add('G', 7);
            alphabet.Add('H', 8);
            alphabet.Add('I', 9);
            alphabet.Add('J', 10);
            alphabet.Add('K', 11);
            alphabet.Add('L', 12);
            alphabet.Add('M', 13);
            alphabet.Add('N', 14);
            alphabet.Add('O', 15);
            alphabet.Add('P', 16);
            alphabet.Add('Q', 17);
            alphabet.Add('R', 18);
            alphabet.Add('S', 19);
            alphabet.Add('T', 20);
            alphabet.Add('U', 21);
            alphabet.Add('V', 22);
            alphabet.Add('W', 23);
            alphabet.Add('X', 24);
            alphabet.Add('Y', 25);
            alphabet.Add('Z', 26);
        }

        public static int eulerFunction(int p, int q)
        {
            return (p - 1) * (q - 1);
        }

        public static int generateE(int euler)
        {
            int e = random.Next(1, euler);
            while (gcd(e, euler) != 1)
                e = random.Next(1, euler);
            return e;
        }

        public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }

        public static bool isPrime(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;

            for (int i = 3; i < Math.Floor(Math.Sqrt(n)); i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }

        public static int binaryPow(int a, int k, int n)
        {
            a %= n;
            int res = 1;
            while (k > 0)
            {
                if ((k & 1) != 0)
                    res = (res * a) % n;
                a = (a * a) % n;
                k >>= 1;
            }
            return res;
        }

        public static int convertToNumbers(String item)
        {
            if (item.Length == 2)
                return (27 * alphabet[item[0]] + alphabet[item[1]]);
            else
                return 27 * alphabet[item[0]];
        }

        public static String convertToString(int item)
        {
            int a = item / 27;
            int b = item - (a * 27);


            var keyA = from entry in alphabet
                     where entry.Value == a
                     select entry.Key;

            var keyB = from entry in alphabet
                       where entry.Value == b
                       select entry.Key;

            return keyA.ElementAt(0).ToString() + keyB.ElementAt(0);
        }

        public static int euclidianAlgorithm(int a, int b)
        {
            int u1 = 0, v1 = 1, u2 = 1, v2 = 0, q = 0, r, u, v, d;
            while (b > 0)
            {
                q = a / b;
                r = a - q * b;
                u = u2 - q * u1;
                v = v2 - q * v1;
                a = b;
                b = r;
                u2 = u1;
                u1 = u;
                v2 = v1;
                v1 = v;
            }
            d = a;
            u = u2;
            v = v2;
            return v;
        }
    }
}
