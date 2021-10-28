using System;

namespace _27_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Assignment-1
            //Console.WriteLine("enter string: ");
            //string enterString = Console.ReadLine();

            //Console.WriteLine(oppositeString(enterString));
            #endregion

            #region Assignment-2
            //Console.WriteLine(findWords("   salam  sag  ol  "));
            #endregion

            #region Assignment-3
            foreach (var item in findChar("salam", 'a'))
            {
                Console.Write(item);
            }
            #endregion
        }

        #region Assignment-1 Method
        static string oppositeString(string text)
        {
            string oppositeStr = "";

            var textLength = text.Length;

            
            for (int i = textLength - 1; i >= 0; i--)
            {
                oppositeStr += text[i].ToString();
            }

            return oppositeStr;
        }
        #endregion

        #region Assignment-2 Method
        static int findWords(string text)
        {

            int counter = 0;
            for (int i = 1; i < text.Length-1; i++)
            {
                if (text[i] == ' ' && text[i+1] != ' ')
                {
                    counter++;
                }
            }

            return counter;
        }
        #endregion

        #region  Assignment-3 Method
        static int[] findChar(string text , char chr)
        {

            
            int[] numberChar = new int[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == chr)
                {
                    numberChar[i] = i;
                }


            }

            return numberChar;
        }
        #endregion
    }
}
