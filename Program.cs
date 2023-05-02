using System.Net.Http.Headers;

namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aula 6.  - Data:24/04  
               Lab. J1 207 - Algoritmos e Técnicas de Programação – 4/2023

               Aluno(a): Miguel Sanches Braga Inácio
               Profa. Michelle Nery Nascimento*/

            /*1. Faça um programa para preencher um vetor com 30 valores quaisquer do tipo
            inteiro e contabilizar o número de elementos iguais a ‘10`*/
            //variavel
            /*
            int[] vet = new int[30];
            Random num = new Random();
            int contador = 0;
            //entrada de dados
            for(int i = 0; i < vet.Length; i++)
            {
               vet[i] = num.Next(1,100);

                if(vet[i] == 10)
                {
                    contador++;
                }
               
            }
            //saida
            Console.WriteLine("Elementos iguais a 10:  " + contador);*/

            /*2. Faça um programa para preencher um vetor com 100 valores inteiros e verificar
            se existem elementos iguais a zero. Se existirem, imprima as posições em que
            estão armazenados*/
            /*
            //variavel
            int[] vet = new int[100];
            Random aleat = new Random();
           
            //entrada de dados
            for(int i=0; i < vet.Length; i++)
            {
                vet[i] = aleat.Next(100);

                if(vet[i] == 0)
                {
                    //saida
                    Console.Write(" " + i+", ");

                }
            }
            */

            /*3. Faça um programa que preencha um vetor com dez números inteiros, calcule e
            mostre o vetor resultante colocando os elementos em ordem decrescente.*/
            /*
            //variavel
            int[] vet = new int[10];
            int vl;
            Random aleat = new Random();
            //entrada de dados
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = aleat.Next(1, 20);
                Console.Write(" " + vet[i]);     
            }
            Console.WriteLine("\n");
            Console.WriteLine(" Ordem decrescente:");
            //saida
            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = i + 1; j < vet.Length; j++)
                {
                    if (vet[i] < vet[j])
                    {
                        vl = vet[i];
                        vet[i] = vet[j];
                        vet[j] = vl;
                    }

                }
                Console.Write(" " + vet[i]);
            }
            */
            /*4. Faça um programa que receba a temperatura média de cada mês do ano,
             armazenando -as em um vetor. Calcule e mostre a maior e a menor
             temperatura do ano e em que mês ocorreram(quando for imprimir, mostrar o
             mês por extenso: 1 - Janeiro, 2 - fevereiro, ...) Desconsidere empates*/
            /*
             //varivel
            int[] vet = new int[12];
            int maior=int.MinValue,menor=int.MaxValue,tempmaior=0,tempmenor=0;
            Random alet = new Random();
            //entrada de dados
            for(int i=0; i<vet.Length; i++)
            {

                vet[i] = alet.Next(1,51);   
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    tempmenor = i;
                }
                if (vet[i] < menor) 
                { 
                    menor = vet[i];
                    tempmaior = i;
                }
            }
            switch (tempmaior)
            {
                case 0:
                    Console.Write("Janeiro");
                    break;
                case 1:
                    Console.Write("Fevereiro");
                    break;
                case 2:
                    Console.Write("Março");
                    break;
                case 3:
                    Console.Write("Abril");
                    break;
                case 4:
                    Console.Write("Maio");
                    break;
                case 5:
                    Console.Write("Junho");
                    break;
                case 6:
                    Console.Write("Julho");
                    break;
                case 7:
                    Console.Write("Agosto");
                    break;
                case 8:
                    Console.Write("Setembro");
                    break;
                case 9:
                    Console.Write("Outubro");
                    break;
                case 10:
                    Console.Write("Novembro");
                    break;
                case 11:
                    Console.Write("Dezembro");
                    break;
            }
            //saida
            Console.WriteLine("\n"+ "com a maior temp: " + maior+"\n");
            //entrada de dados
            switch (tempmenor)
            {
                case 0:
                    Console.Write("Janeiro");
                    break;
                case 1:
                    Console.Write("Fevereiro");
                    break;
                case 2:
                    Console.Write("Março");
                    break;
                case 3:
                    Console.Write("Abril");
                    break;
                case 4:
                    Console.Write("Maio");
                    break;
                case 5:
                    Console.Write("Junho");
                    break;
                case 6:
                    Console.Write("Julho");
                    break;
                case 7:
                    Console.Write("Agosto");
                    break;
                case 8:
                    Console.Write("Setembro");
                    break;
                case 9:
                    Console.Write("Outubro");
                    break;
                case 10:
                    Console.Write("Novembro");
                    break;
                case 11:
                    Console.Write("Dezembro");
                    break;
            }
            //saida
            Console.WriteLine(" com a menor temp: " + menor);*/

            /*5. Dados dois vetores:
              A – 8 elementos do tipo inteiro
              B – 12 elementos do tipo inteiro
              Faça um programa que leia os dois vetores A e B, gere o vetor C correspondente a
              união dos vetores A e B.*/
            /*
            int[] veta = {1,2,3,4,5,6,7,8};
            int[] vetb = {9,10,11,12,13,14,15,16,17,18,19,20};
            int[] soma = new int[20];
            Random rd = new Random();
            for(int i = 0; i < veta.Length; i++)
            {
                soma[i] = veta[i];
            }
            for(int i = 0;i < vetb.Length; i++)
            {  
                soma[i+8] = vetb[i];
            }
            for(int i = 0;i <soma.Length;i++)
            Console.Write(" "+soma[i]);
            */
        }
    }
}