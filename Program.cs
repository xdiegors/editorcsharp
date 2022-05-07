using static System.Console;
Clear();
System.Console.BackgroundColor = ConsoleColor.Red;

CriarBorda();

System.Console.BackgroundColor = ConsoleColor.Black;
WriteLine("Digite algo");
string textoDigitado = ReadLine();

WriteLine(textoDigitado);

System.Console.BackgroundColor = ConsoleColor.Red;
CriarBorda();
System.Console.BackgroundColor = ConsoleColor.Black;

static void CriarBorda() {
    
    Write("+");

    for (int i = 0; i < 90; i++)
    {
        Write("-");
    }

    WriteLine("+");
}