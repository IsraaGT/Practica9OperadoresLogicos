double num1;
double num2;

Console.WriteLine("Ingrese el primer numero:");
num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero:");
num2 = double.Parse(Console.ReadLine());

Console.WriteLine("El primer numero es: " + num1);
Console.WriteLine("El segundo numero es: " + num2);

bool igual = num1 == num2;
bool noIgual = num1 != num2;
bool menorQue = num1 < num2;
bool mayorQue = num1 > num2;
bool menorOIgual = num1 <= num2;
bool mayorOIgual = num1 >= num2;

Console.WriteLine("¿El primer numero es igual al segundo numero? " + igual);
Console.WriteLine("¿El primer numero es diferente al segundo numero? " + noIgual);
Console.WriteLine("¿El primer numero es menor que el segundo numero? " + menorQue);
Console.WriteLine("¿El primer numero es mayor el segundo numero? " + mayorQue);
Console.WriteLine("¿El primer numero es menor o igual que el segundo numero? " + menorOIgual);
Console.WriteLine("¿El primero numero es mayor o igual que el segundo numero? " + mayorOIgual);

// Operadores lógicos 
bool ambosSonPares = num1 % 2 == 0 && num2 % 2 == 0;
bool alMenosUnoEsPar = num1 % 2 == 0 || num2 % 2 == 0;
bool num1EsImpar = num1 % 2 != 0;

Console.WriteLine("¿Ambos números son pares? " + ambosSonPares);
Console.WriteLine("¿Al menos uno es par? " + alMenosUnoEsPar);
Console.WriteLine("¿El primer número es impar? " + num1EsImpar);

Console.ReadKey();