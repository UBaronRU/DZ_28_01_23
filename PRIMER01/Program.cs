/*
## PRIMER01
Найти точку пересечения двух прямых заданных уравнением 
y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
*/
int Num_y  = 0;
int Num_x  = 0;
int Num_k1 = 0;
int Num_k2 = 0;
int Num_b1 = 0;
int Num_b2 = 0;
Console.Write("Введите число k1 для уровнения y = k1 * x + b1: ");
Num_k1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число b1 для уровнения y = k1 * x + b1: ");
Num_b1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число k2 для уровнения y = k2 * x + b2: ");
Num_k2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число b1 для уровнения y = k2 * x + b2: ");
Num_b2 = int.Parse(Console.ReadLine() ?? "0");
if (Num_k1 != Num_k2)
{
    Num_x = (Num_b2 - Num_b1) / (Num_k1 - Num_k2);
    Num_y =  Num_x * Num_k1 + Num_b1;
    Console.Write(" Прямые заданные уровнениями: ");
    Console.Write(" y = "+ Num_k1 + " * x + " +Num_b1 + " и y = "+ Num_k2 + " * x + " +Num_b2);
    Console.Write(" Пересекаются в точке : x = "+Num_x+" y = "+Num_y);
}
else
{
   if (Num_k1 != Num_k2 )
   {
   Console.Write(" Прямые заданные уровнениями: ");
   Console.Write(" y = "+ Num_k1 + " * x + " +Num_b1 + " и y = "+ Num_k2 + " * x + " +Num_b2);
   Console.Write(" Паралельны: ");
   }
   else
   {
   Console.Write(" Прямые заданные уровнениями: ");
   Console.Write(" y = "+ Num_k1 + " * x + " +Num_b1 + " и y = "+ Num_k2 + " * x + " +Num_b2);
   Console.Write(" Одинаковы: ");   
   }

}
