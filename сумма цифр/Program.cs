Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int total = 0;


for (int count = 1; count <= num; count++ )
{
    total+=count;
}
Console.WriteLine(total);