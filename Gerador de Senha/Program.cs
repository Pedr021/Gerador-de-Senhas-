using System;
using System.Text;





namespace GeradordeSenha
{
    class Program
    {
        static void Main ( string[] args)
        {
            int qtd = 15;

            string caracteresPossiveis =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ" +
            "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ".ToLower() +
            "0123456789" + "%$#@!";

            Random sorteio = new Random();
            int numeroSorteado = 0;
            StringBuilder password = new StringBuilder();
           
            for (int t = 0;  t < qtd; t++)
            {
                numeroSorteado = sorteio.Next(0, caracteresPossiveis.Length - 1);
                password.Append(caracteresPossiveis[numeroSorteado]);
            }

            Console.Write(password);
            
        }


    }
}