using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Program
    {
        static void Peso()
        {
            int maiorPeso = int.MinValue;
            int menorPeso = int.MaxValue;
            int somaPeso = 0;
            double mediaPeso;
            int pesos;
            string linha;
            
            string[] dados;
            int[] vet = new int[9]; 

            StreamReader arq = new StreamReader("C:\\Users\\1538415\\Downloads\\arquivo-01.txt", Encoding.UTF8);
            linha = arq.ReadLine();
            int i = 0;
            try
            {
                while (linha != null)
                {
                    dados = linha.Split(';');
                    pesos = int.Parse(dados[3]);
                    linha = arq.ReadLine();
                    vet[i] = pesos;
                    i++;
                }
                
                arq.Close();
            }

            catch(Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
            


            for (int j = 0; j < vet.Length; j++)
            {
                if (vet[j] > maiorPeso)
                {
                    maiorPeso = vet[j];
                }
                if (vet[j] < menorPeso)
                {
                    menorPeso = vet[j];
                }
                somaPeso += vet[j];
            }
            mediaPeso = somaPeso / 9;


            Console.WriteLine("Maior peso é igual a: " + maiorPeso);
            Console.WriteLine("Menor peso é igual a: " + menorPeso);
            Console.WriteLine("A média dos pesos é igual a: " + mediaPeso);

        }

        static void Main(string[] args)
        {
            Peso();
            Console.ReadLine();
        }
    }
}
