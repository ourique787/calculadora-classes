Calculadora calc = new Calculadora();
Console.WriteLine("Digite o valor de x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor de y: ");
double y = Convert.ToDouble(Console.ReadLine());

double resultadoSoma = calc.Soma(x,y);
Console.WriteLine($"O resultado da soma de {x} e {y} e igual a: {resultadoSoma}");

Console.WriteLine($"Resultado da subtracao e: {calc.Subtracao(x,y)}");

Console.WriteLine($"O resultado da multiplicacao e: {calc.Multiplicacao(x,y)}");

Console.WriteLine($"O resultado da divisao e: {calc.Divisao(x,y)}");



