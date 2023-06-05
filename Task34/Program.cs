void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100,1000);
}



Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
int count = 0;

for (int m = 0; m < array.Length; m++)
if (array[m] % 2 == 0)
count++;
Console.WriteLine($"Количество четных чисел в массиве:{count} ");
