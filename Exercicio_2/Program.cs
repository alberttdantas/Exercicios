using System;
using System.Collections.Generic;

namespace DuplicadosConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = { "abracadabra", "allottee", "assessee", "kelless","keenness","Alfalggo" };
            string[] resultado = Duplicados(palavras);
            Console.WriteLine(string.Join(", ", resultado));
        }

        static string[] Duplicados(string[] palavras)
        {
            List<string> resultado = new List<string>();

            foreach (string palavra in palavras)
            {
                char[] chars = palavra.ToCharArray();
                string novaPalavra = "" + chars[0];

                for (int i = 1; i < chars.Length; i++)
                {
                    if (chars[i] != chars[i - 1])
                    {
                        novaPalavra += chars[i];
                    }
                }

                resultado.Add(novaPalavra);
            }

            return resultado.ToArray();
        }
    }
}
