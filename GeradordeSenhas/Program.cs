using System.Collections;
using System.Collections.Specialized;
using System.Linq.Expressions;

using (StreamWriter escrever = new StreamWriter("bkp.txt"))
{
    Random randNum = new Random();
    var Random = new Random();
    char[] beto = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    char[] gama = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    // Console.WriteLine(beto[0]);
    Console.WriteLine("Gerador de senhas");

    Console.Write("Insira a quantidade de caracteres que deseja na senha: ");
    if (int.TryParse(Console.ReadLine(), out int tamanhoSenha))
    {
        Console.WriteLine("1 - Somente números na senha");
        Console.WriteLine("2 - Números e letras");
        Console.WriteLine("3 - Números e caracteres especiais");
        Console.WriteLine("4 - Números, letras e caracteres especiais");
        Console.WriteLine("5 - Somente Letras");
        Console.WriteLine("6 - Letras e caracteres especiais");

        int simbolos = int.Parse(Console.ReadLine());
        // int senhagerada;
        // int senhagerada2;
        switch (simbolos)
        {
            case 1:

                for (int a = 0; a < tamanhoSenha; a++)
                {
                    var numAleat = randNum.Next(gama.Length);
                    Console.Write(numAleat);
                }
                break;

            case 2:

                Console.Write("Quantas letras você quer:");
                int letraNaSenha = int.Parse(Console.ReadLine());
                char index;

                for (int b = 0; b < letraNaSenha; b++)
                {
                    char[] alfa = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

                    var randomIndex = Random.Next(alfa.Length);

                    index = alfa[randomIndex];
                    Console.Write(index);
                }
                char index1;
                // if
                for (int c = 0; c < tamanhoSenha - letraNaSenha; c++)
                {
                    gama = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                    var randomIndex1 = Random.Next(gama.Length);

                    index1 = gama[randomIndex1];

                    Console.Write(index1);
                }
                // senhagerada = randNum.Next(1, 9);
                break;
            case 3:

                Console.Write("Quantos caracteres especiais você deseja: ");
                int caractNaSenha = int.Parse(Console.ReadLine());

                char index2;

                for (int d = 0; d < caractNaSenha; d++)
                {

                    char[] delta = new char[] { '(', ')', '{', '}', '[', ']', '/', ';', ':', '.', ',', '?', '!', '+', '-', '*', '=', '<', '>', '%', '#', '@', '^', '&', '_', '~', '`', '$', '|' };

                    var randomIndex = Random.Next(delta.Length);

                    index2 = delta[randomIndex];
                    Console.Write(index2);
                }

                char index3;

                for (int e = 0; e < tamanhoSenha - caractNaSenha; e++)
                {

                    gama = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                    var randomIndex1 = Random.Next(gama.Length);

                    index3 = gama[randomIndex1];

                    Console.Write(index3);

                }
                break;

            case 4:
                Console.Write("Quantas letras você quer na senha:");
                int letrasCaracteres = int.Parse(Console.ReadLine());

                Console.Write("Quantos caracteres especiais você quer na senha:");
                int caracteresLetras = int.Parse(Console.ReadLine());

                char index4;
                char index5;

                for (int b = 0; b < letrasCaracteres; b++)
                {
                    char[] alfa = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

                    var randomIndex = Random.Next(alfa.Length);

                    index4 = alfa[randomIndex];
                    Console.Write(index4);
                }
                for (int d = 0; d < caracteresLetras; d++)
                {

                    char[] delta = new char[] { '(', ')', '{', '}', '[', ']', '/', ';', ':', '.', ',', '?', '!', '+', '-', '*', '=', '<', '>', '%', '#', '@', '^', '&', '_', '~', '`', '$', '|' };

                    var randomIndex = Random.Next(delta.Length);

                    index2 = delta[randomIndex];
                    Console.Write(index2);
                }
                // if
                for (int c = 0; c < tamanhoSenha - letrasCaracteres - caracteresLetras; c++)
                {
                    gama = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                    var randomIndex1 = Random.Next(gama.Length);

                    index5 = gama[randomIndex1];

                    Console.Write(index5);
                }

                // s
                // char index4;


                // for (int f = 0; f < letrasCaracteres; f++)
                // {

                // }
                break;
        }
    }
}

// Random randNum = new Random();
// int num = randNum.Next(1,60);
