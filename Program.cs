/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine("Введите число N больше 0 ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumbersReverse(N));


string PrintNumbersReverse( int start, int end = 1){
    if(start == end) return start.ToString();
    return start + ", " + PrintNumbersReverse(start - 1, end);
}


/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите число N  ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число M  ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSumBetweenNum(n, m));


int GetSumBetweenNum(int a, int b){
    if (a > b){
    int temp = a;
    a = b;
    b = temp;}
    if(a == b) return a;
    return a + GetSumBetweenNum(a + 1, b);}
    

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.WriteLine("Введите число m  ");
int m68 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число n  ");
int n68 = int.Parse(Console.ReadLine()!);
Console.WriteLine(AckermannFunc(m68, n68));

double AckermannFunc(double m, double n){
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermannFunc(m - 1, 1);
    return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}