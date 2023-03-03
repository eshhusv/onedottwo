Console.Write("Введите стоимость 1кг конфет");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите стоимость 1кг печенья");
double b = double.Parse(Console.ReadLine());
Console.WriteLine($"Стоимость покупки 300г конфет и 400г печенья: {a * 0.3 + b * 0.4}");
Console.WriteLine($"Стоимость трёх покупок по 1кг 800г конфет и 2кг печенья: {3 * (2 * b + 1.8 * a)}");
