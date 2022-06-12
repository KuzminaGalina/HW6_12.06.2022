/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Введите количество чисел: ");
int NumberOfNumbers = Convert.ToInt32(Console.ReadLine());
int count = 0;
Console.WriteLine("Введите числа: ");
for (int i = 0; i < NumberOfNumbers; i++)
{
    int Number = Convert.ToInt32(Console.ReadLine());
    if(Number > 0)
    {
        count++;
    } 
}
Console.WriteLine($"Количество чисел больше нуля: {count}");