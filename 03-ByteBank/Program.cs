using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            //O resultado aqui será falso pois estão sendo ocupados dois espaços na memória 
            Console.WriteLine("Igualdade de tipo de referência:" + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));

            //O resultado aqui será verdadeiro pois a conta da Gabriela e a conta da Gabriela Costa estão ocupando o mesmo espaço na memória 
            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);


            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

            if(contaDaGabriela.saldo >= 100)
            {
                //Supondo que a Gabriela saque 100,00
                contaDaGabriela.saldo -= 100;
            }

            Console.ReadLine(); 

        }
    }
}
