using OOP_RATIONAL;

Rational r1 = new Rational(4, 8); 
Rational r2 = new Rational(2, -5);
Rational r3 = new Rational(-3, -4);

Console.WriteLine(r1);
Console.WriteLine(r2);
Console.WriteLine(r3);

Rational r4 = r1 + r2 * r3;
Console.WriteLine(r4);


Console.WriteLine($"{r1} == {r2}: {r1 == r2}");
Console.WriteLine($"{r1} == {r3}: {r1 == r3}");
Console.WriteLine($"{r1} != {r3}: {r1 != r3}");

Console.WriteLine($"{r3} > {r1}: {r3 > r1}");
Console.WriteLine($"{r1} < {r3}: {r1 < r3}");
Console.WriteLine($"{r1} >= {r2}: {r1 >= r2}");
Console.WriteLine($"{r1} <= {r3}: {r1 <= r3}");
