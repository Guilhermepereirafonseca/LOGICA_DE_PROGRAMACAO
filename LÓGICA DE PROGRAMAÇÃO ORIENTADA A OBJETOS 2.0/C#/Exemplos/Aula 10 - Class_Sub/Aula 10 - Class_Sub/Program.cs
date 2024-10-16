// o C# não aceita '-' por isso colocou underline
using Aula_10___Class_Sub;

Subtracao sub = new Subtracao(); // classe variavel = new função;
sub.setN1(70); // dentro da variavel tera esses números
sub.setN2(40);

sub.setSub(sub.getN1() - sub.getN2()); // operação de subtracao ocorrendo
// Exibindo na tela
Console.Write("O Resultado é: ");
Console.WriteLine(sub.getSub());
Console.ReadKey();

Subtracao subtrai = new Subtracao();
subtrai.setN1(50);
subtrai.setN2(30);
subtrai.setSub(subtrai.getN1() - subtrai.getN2());

Console.Write("O Resultado é: ");
Console.WriteLine(subtrai.getSub());
Console.ReadKey();