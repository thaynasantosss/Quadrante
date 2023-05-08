double x, y;
string local;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("*** Quadrante Cartesiana ***");
Console.WriteLine();
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Entre com o ponto desejado.");
Console.WriteLine();
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Coordenada x: ");
Console.ResetColor();
x = Convert.ToDouble(Console.ReadLine());


Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Coordenada y: ");
Console.ResetColor();
y = Convert.ToDouble(Console.ReadLine());


if (x == 0 && y == 0) local = "a origem";
else if (x == 0) local = "o eixo das ordenadas";
else if (y == 0) local = "o eixo das abscissas";
else if (y > 0)
{
    if (x > 0)
        local = "o quadrante 1";
    else
        local = "o quadrante 2";
}
else
{
    if (x < 0)
        local = "o quadrante 3";
    else
        local = "o quadrante 4";
}

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"O ponto ({x}, {y}) fica n{local}.");
Console.WriteLine();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("Clique para inserir outros pontos");
Console.ResetColor();
Console.WriteLine();
Console.ReadKey();
Console.Clear();