// Напишите программу, которая принимает на вход число и выдает таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число N");
int n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов данного числа");
for (int i=1; i<=n; i++) {
    double K= Math.Pow(i,3);
    Console.WriteLine("{0}", K);
}