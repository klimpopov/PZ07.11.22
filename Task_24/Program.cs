/* Принимаем на вход число (N) и выдает количество цифр в числе.
*/

int GetCountNums(int number)
{
    string str = Convert.ToString(number);
    int sum = str.Length;
    return sum;
}

Console.Clear();
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = GetCountNums(num);
Console.WriteLine($"Количество цифр в числе {num} = {sum}");