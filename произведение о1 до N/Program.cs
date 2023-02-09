//Написать программу вычисления произведения чисел от 1 до N

Console.Clear();

Console.Write("Введиет число: ");
int num = int.Parse(Console.ReadLine()!);

int total = 1;


for (int count = 1; count <= num; count++ )
{
    total= total * count;
}
Console.WriteLine(total);