Console.WriteLine("Выберите задание: ");
Console.WriteLine("Задание 66.  Сумма элементов от M до N. Рекурсия");
Console.WriteLine("Задание 68.  Функция Аккермана. Рекурсия");
int n = Convert.ToInt32(Console.ReadLine());

switch (n){
    case 66: Task66();
    break;
    case 68: Task68();
    break;
    default:
    break;
}

void Task66()
{

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
if (n < m)
     {
     Console.WriteLine("Число N должно быть меньше числа M");
     return;
     }
else
     Summa(m, n);
Console.WriteLine("Сумма элементов в промежутке от {0} до {1} равна: " + Summa(m, n), m, n);
}
int Summa(int m, int n)
{
     if (m == n)
          return 1;
     m++;
     
     return m + Summa(m, n);   
}

void Task68()
{
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
if ((m < 0 ) || (n < 0))
     {
     Console.WriteLine( "Функция Аккермана принимает на вход два неотрицательных целых числа" );
     return;
     }
else
Akkerman(m, n);
Console.WriteLine( "Функция Аккермана для чисел {0} до {1} равна: " + Akkerman(m, n), m, n);

int Akkerman (int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m > 0) && (n == 0))
      return Akkerman(m - 1, 1);
    else
      return Akkerman(m - 1, Akkerman(m, n - 1));
}

}