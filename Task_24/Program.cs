/* Принимаем на вход число (А) и выдает сумму чисел от 1 до А
*/
void GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++) // Math.Abs число по модулю
        sum = sum + i;
    Console.WriteLine($"Сумма цифр от 1 до {number} = {sum}");
}
Console.Clear();
Console.WriteLine("Введите число");
GetSumNums(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Введите число");
GetSumNums(Convert.ToInt32(Console.ReadLine()));