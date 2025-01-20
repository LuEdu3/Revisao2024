using System.Collections;

using (StreamWriter escrever = new StreamWriter("bkp.txt"))
{
    Random randNum = new Random();

    Console.WriteLine("Gerador de senhas");

    Console.WriteLine("Insira a quantidade de caracteres que deseja na senha:");
    if (int.TryParse(Console.ReadLine(), out int tamanhoSenha))
    {
        Console.WriteLine("1 - Somente números na senha");
        Console.WriteLine("2 - Números e letras");
        Console.WriteLine("3 - Números e caracteres especiais");
        Console.WriteLine("4 - Números, letras e caracteres especiais");
        Console.WriteLine("5 - Somente Letras");
        Console.WriteLine("6 - Letras e caracteres especiais");
        
        int senhagerada;
        int simbolos = int.Parse(Console.ReadLine());
        switch (simbolos)
        {
            case 1:

                for (int a = 1; a <= tamanhoSenha; a++)
                {
                    senhagerada = randNum.Next(1, 60);
                    if (senhagerada < 10)
                    {
                        Console.Write($"{senhagerada}");
                    }
                    else
                    {
                        Console.Write($"{senhagerada}");
                    }
                }
                break;
        }

    }
}

// Random randNum = new Random();
// int num = randNum.Next(1,60);
