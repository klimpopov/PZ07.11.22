// Выводит массив из 8 элементов, заполняемый нулями и единицами в случайном порядке.

int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result;
}