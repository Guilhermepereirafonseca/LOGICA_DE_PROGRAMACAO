
int n1;

Console.Write("Digite um número: ");
try
{
    n1 = int.Parse(Console.ReadLine());

    // Cabeçalho
    Console.WriteLine("\nTabuada do " + n1);
    Console.WriteLine();

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("\t" + n1 + " x " + i + " = " + (n1 * i));
    }

    // Rodapé
    Console.WriteLine("\nFim da Tabuada!!");
}
catch(Exception digitou_letra) {
    Console.WriteLine("VOCÊ DIGITOU UMA LETRA...\n");
}
finally {
    Console.WriteLine("Pressione uma tecla para sair...");
    Console.ReadKey();
}