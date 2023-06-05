void InputArray(double[] array)
{
    int end = 30, begin = 10;
    for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
    }


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
         max = array[i];
    }
    if (array[i] < min)
    {
         min = array[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {Math.Round(max - min)}");
