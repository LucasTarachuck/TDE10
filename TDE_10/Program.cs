Retangulo R1 = new Retangulo();
Retangulo R2 = new Retangulo(5);
Retangulo R3 = new Retangulo(4, 6);

Console.WriteLine($"A area de R1 é {R1.CalcularArea()}");
Console.WriteLine($"O perimetro de R1 é {R1.CalcularPerimetro()}");

Console.WriteLine($"A area de R2 é {R2.CalcularArea()}");
Console.WriteLine($"O perimetro de R2 é {R3.CalcularPerimetro()}");

Console.WriteLine($"A area de R3 é {R3.CalcularArea()}");
Console.WriteLine($"O perimetro de R3 é {R3.CalcularPerimetro()}");

R2.Redimensionar(10, 15);
Console.WriteLine($"A area de R2 é {R2.CalcularArea()}");
Console.WriteLine($"O perimetro de R2 é {R2.CalcularPerimetro()}");

R3.Redimensionar(2);
Console.WriteLine($"A area de R3 é {R3.CalcularArea()}");
Console.WriteLine($"O perimetro de R3 é {R3.CalcularPerimetro()}");
