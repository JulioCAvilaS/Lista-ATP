using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lista_10
{
    internal class Program
    {
        static void NomeCientifico()
        {
            string linha;
            string[] dados;
            string nomeC;
            try{
                StreamReader arq = new StreamReader("C:\\Users\\1538415\\Downloads\\arquivo-01.txt", Encoding.UTF8);
                linha = arq.ReadLine();
                while (linha != null)
                {
                    dados = linha.Split(';');
                    nomeC = dados[1];
                    linha = arq.ReadLine();
                    Console.WriteLine(nomeC);
                }
                arq.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }            
        }

        static void Main(string[] args)
        {
            NomeCientifico();
            Console.ReadLine();
        }
    }
}
