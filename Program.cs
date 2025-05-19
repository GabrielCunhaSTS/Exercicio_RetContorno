int largura, altura;

Console.Write("Digite a largura de 1 a 10: ");

while (!int.TryParse(Console.ReadLine(), out largura) || largura < 1 || largura > 10)
{
    Console.Write("Número inválido! Digite a largura apenas de 1 a 10: ");
}

Console.Write("Digite a altura de 1 a 10: ");

while (!int.TryParse(Console.ReadLine(), out altura) || altura < 1 || altura > 10){
    Console.Write("Número invalido! Digite a altura apenas de 1 a 10: ");
}

Console.WriteLine();

for (int i = 0; i < altura; i++)
{
    for (int j = 0; j < largura; j++)
    {
        if (i == 0 || i == altura - 1 || j == 0 || j == largura - 1)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}
