using System;
namespace input_output
{
    public struct NM
    {
        public char N;
        public int M;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string word = Console.ReadLine();
            word = word.ToUpper(); 
            NM[] str = new NM[word.Length]; 
          
            int k = 0; 
            int g;
            str[k].N = word[0];
            str[k].M = 1;

            for (int i = 1; i < word.Length; i++)
            {
                g = Check(word[i], str, k); if (g >= 0)
                {
                    str[g].M++;
                }
                else
                {
                    k++;
                    str[k].N = word[i];
                    str[k].M = 1;
                }
            }

            string s1 = "";
            for (int i = 0; i < word.Length; i++)
            {
                g = Check(word[i], str, k);
                if (str[g].M == 1)
                    s1 += "(";
                else
                    s1 += ")";
            }
            Console.WriteLine(s1);
            Console.ReadLine();
        }
   
        static int Check(char c1, NM[] str, int k)
        {
            int r = -1;
            for (int i = 0; i <= k; i++)
                if (c1 == str[i].N)
                {
                    r = i;
                    break;
                }
            return r;
        }
       
    }
}
