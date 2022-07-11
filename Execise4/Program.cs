int a,b,c;
Console.WriteLine ("Введите первое число");
a = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите второе число");
b = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите третье число");
c = Convert.ToInt32(Console.ReadLine ());
int max = a;
if ((a > b) && (a > c)) max = a;
if ((b > a) && (b > c)) max = b;
if ((c > a) && (c > b)) max = c;

Console.Write ("max = ");
Console.Write (max);