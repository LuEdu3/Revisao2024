using System.Collections;
using System.Collections.Specialized;

using (StreamWriter escrever = new StreamWriter("bkp.txt"))
{
    Random randNum = new();
    Random letraAleatoria = new ();
    // char[] alfa = new char[] {"a","b","c ","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
    string [] beto = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
    string [] gama = {"0","1","2","3","4","5","6","7","8","9",};
    Console.WriteLine(beto[0]);
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
        string senhagerada;
        string senhagerada2;
        switch (simbolos)
        {
            case 1:

                for (int a = 0; a < tamanhoSenha; a++)
                {
                    var numAleat = randNum.Next(gama.Length);
                    senhagerada = gama[numAleat];
                    Console.Write($"{senhagerada}");
                    // escrever.WriteLine($"{senhagerada}");
                }
                break;
            case 2:
            for (int b = 0; b < tamanhoSenha; b++){
                var letraAleat = letraAleatoria.Next(beto.Length);
                // senhagerada = randNum.Next(1, 9);
                
                senhagerada2 = beto[letraAleat];

                // Console.Write(senhagerada);
                
                Console.Write(senhagerada2);

                // Console.Write();
            }


            break;

        }
    }
}

// Random randNum = new Random();
// int num = randNum.Next(1,60);
