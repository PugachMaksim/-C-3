/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int xA;
int yA;
int zA;

int xB;
int yB;
int zB;
double AB;

Console.WriteLine("Введите координаты точки А: ");
int.TryParse(Console.ReadLine(), out xA);
int.TryParse(Console.ReadLine(), out yA);
int.TryParse(Console.ReadLine(), out zA);
Console.WriteLine("Введите координаты точки А: ");
int.TryParse(Console.ReadLine(), out xB);
int.TryParse(Console.ReadLine(), out yB);
int.TryParse(Console.ReadLine(), out zB);
AB = Math.Sqrt((xA-xB)*(xA-xB)+(yA-yB)*(yA-yB)+(zA-zB)*(zA-zB));
Console.WriteLine($"A ({xA}, {yA}, {zA}); B ({xB}, {yB}, {zB}) -> {AB}");