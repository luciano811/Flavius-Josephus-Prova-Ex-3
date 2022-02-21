using System;

namespace Flavius_Josephus_Prova_Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número de casos de teste:");
            var nc = Console.ReadLine();

            int nci = Convert.ToInt32(nc);

            int[] pessoasPorCaso = new int[nci];
            int[] saltos = new int[nci];

            for (int i = 0; i < nci; i++)
            {
                Console.WriteLine("Informe o número de pessoas do caso " + (i + 1) + ":");
                var n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o número do salto do caso " + (i + 1) + ":");
                var k = Convert.ToInt32(Console.ReadLine());

                pessoasPorCaso[i] = n;
                saltos[i] = k;
            }

            for (int i = 0; i < nci; i++)
                Console.WriteLine("{0}, {1}", pessoasPorCaso[i], saltos[i]);

            for (int i = 0; i < nci; i++)
            {
                int npessoas = pessoasPorCaso[i];
                int salto = saltos[i];

                int[] casoArray = new int[npessoas];


                for (int j = 0; j < npessoas; j++)
                    casoArray[j] = j + 1;

                int npessoasvivas = npessoas;
                int saltovivas = 0;

                while (npessoasvivas != 1)
                {
                    //contador de pessoas vivas
                    for (int l = 0; l < npessoas; l++)
                    {
                        //conta pessoas vivas
                        if (casoArray[l] != 0)
                            saltovivas++;

                        //matar as pessoas do salto
                        if (saltovivas == salto)
                        {
                            casoArray[l] = 0;
                            npessoasvivas--;
                            saltovivas = 0;
                        }
                    }
                }

                for (int x = 0; x < casoArray.Length; x++)
                {
                    if (casoArray[x] != 0)
                        System.Console.WriteLine($"Só restou o número {casoArray[x]} vivo...");
                }
            }

        }
    }

}
//OBS: Com ajuda do Estevam Longo