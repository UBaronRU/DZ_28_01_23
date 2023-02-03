/*
## PRIMER02
Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
## PRIMER03
*/
int kol_vershin=0;
double koef;
Console.WriteLine($"Количество вершин фигуры ( более 2) :");
kol_vershin = int.Parse(Console.ReadLine()?? "");
double[,] coordinates = new  double[kol_vershin,2];
if (kol_vershin > 2)
{
    
    for (int i = 0; i < kol_vershin; i++)
    {
    Console.WriteLine($"Введите координату по X:");
    coordinates[i,0] = double.Parse(Console.ReadLine()?? "");
    Console.WriteLine($"Введите координату по Y:");
    coordinates[i,1] = double.Parse(Console.ReadLine()?? "");
    }
    Console.WriteLine($"Введите коэффициент масштабирования:");
    koef = double.Parse(Console.ReadLine()?? "");
    for (int i = 0; i < kol_vershin; i++)
    {
        coordinates[i,0] = coordinates[i,0]*koef;
        coordinates[i,1] = coordinates[i,1]*koef;
    }
    for (int i = 1; i < kol_vershin+1; i++)
    {
    Console.WriteLine($"Новая координата для вершины №"+i+" по X:"+coordinates[i-1,0]+" по Y:"+coordinates[i-1,1]);
    }
    

}
else
{
      Console.WriteLine($"Количество вершин фигуры заданно не верно");  
}