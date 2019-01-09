using System;


namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort N, M;
            int  valor, X, Y;
            int[,] matriz;
             
            
            bool encontrou;

            string[] vet0 = Console.ReadLine().Split(' ');            N = ushort.Parse(vet0[0]);
            M = ushort.Parse(vet0[1]);


            matriz = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                for (int j = 0; j < M; j++)
                {
                    valor = int.Parse(vet[j]);
                    matriz[i, j] = valor;
                } 
            }
                X = 0;
              Y = 0;
                encontrou = false;
             

                for (int i = 1; i < N-1 && encontrou == false ; i++)
                {

                    for (int j = 1; j < M-1 && encontrou == false ; j++)
                    {
                        if (matriz[i, j] == 42 && matriz[i - 1, j - 1] == 7 && matriz[i + 1, j + 1] == 7 &&
                            matriz[i - 1, j + 1] == 7 && matriz[i + 1, j - 1] == 7 && matriz[i, j + 1] == 7 &&
                            matriz[i + 1, j] == 7 && matriz[i, j - 1] == 7 && matriz[i - 1, j] == 7)
                        {

                            X = i + 1;
                            Y = j + 1;
                            encontrou = true;
                        }


                    }
                }
           



            Console.WriteLine(X + " " + Y);


        
        }
    }
}