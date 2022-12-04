using System;

namespace tryparsse
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            if (!int.TryParse(s: Console.ReadLine(), result: out result))
                Console.Write(value: "Skriv in en siffra"); 
        }
        public static bool TryParse(string s, out int result) {
            bool isparsed;
            int res = 0;
            result = res;
            try {
                result = Convert.ToInt32(value: s);
                isparsed = true;
                if (isparsed == true) {
                    return true;
                }
            } catch (System.Exception) {
                isparsed = false;
                if (isparsed == false) {
                    return false;
                }
            }
            return false;
        }
    }
}