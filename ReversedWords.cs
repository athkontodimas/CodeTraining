using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_Words
{
    class ReversedWords
    {
        static void Main(string[] args)
        {
            string words = "hello you";
            //Reverse words using a method
            string result = ReverseWords(words);
            Console.WriteLine(result);
            
            //-----------------------------------------------------
            //Reverse words without a method
            
            //List<string> strings = words.Split(' ').ToList();
            //strings.Reverse();
            //string str ="";
            
         
            //for (int i = 0; i < strings.Count; i++)
            //{
            //    if (i!=strings.Count-1)
            //    {
            //        str += strings[i] + ' ';
            //    }
            //    else
            //    {
            //        str += strings[i];
            //    }
                
            //}
            //Console.WriteLine(str);

         
        }//end of Main
        //Reverse words Method
            public static string ReverseWords(string str1)
            {
                List<string> strings1 = str1.Split(' ').ToList();
                strings1.Reverse();
                string str2 = "";

                for (int i = 0; i < strings1.Count; i++)
                {
                    if (i != strings1.Count - 1)
                    {
                        str2 += strings1[i] + ' ';
                    }
                    else
                    {
                        str2 += strings1[i];
                    }

                }

                return str2;
            }
    }
}
