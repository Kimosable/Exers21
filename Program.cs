//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Print("Введите х1: ");
int x2 = Print("Введите х2: ");
int y1 = Print("Введите y1: ");
int y2 = Print("Введите y2: ");
int z1 = Print("Введите z1: ");
int z2 = Print("Введите z2: ");

int Print(string arg1)
{
    System.Console.Write(arg1);
    int i;
    while(!int.TryParse(System.Console.ReadLine(), out i))
    {
        System.Console.WriteLine("its not a number");
    }
    return i;
}

double Third(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double number = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
    return number;
}

System.Console.WriteLine("Расстояние между точками = " + Third(x1, x2, y1, y2, z1, z2));