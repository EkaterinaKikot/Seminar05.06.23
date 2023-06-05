void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-99, 100);
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
int sum = 0;

for (int m = 1; m < array.Length; m+=2)
sum = sum + array[m];
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях:{sum} ");
