//Написать программу, которая получает двузначное число из отрезка
// и показывает наибольшую цифру числа.
/*
int Digits (int number)       //метод,  Digits - имя метода(объявление метода), (int number) - аргумент метода, 
{                           //получает целое число и возвращает целое число
    int ed = number % 10;                // найдем еденицы, % 10 - остаток от деления на 10
    int dec = number / 10;              // найдем десятки

    int result;

    if (ed > dec)                 //сравниваем десятки и единицы
    {
        result = ed;
    }
    else result = dec;         //завершение метода возвращаем в программу десятки

    return result;         //возврат, завершение метода - возвращаем в программу еденицы (метод с возвращением)

}

Console.Write("Input yor 2digits number: ");
int user_num = Convert.ToInt32(Console.ReadLine());                              
int res = Digits(user_num);                          //вызов метода, res - называем переменную, 
                                                     //в которую возвращаем результат метода Digits
Console.WriteLine($"The biggest digits is {res} ");
*/
//9.Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.
//78 -> 8
//12 -> 2
//85 -> 8
/*
int Digits ()       //объявление метода Digits; получает аргументом целое число и возвращает целое число
{                           
    int randomNum = new Random().Next(10, 100);     //Сгенерировали случайную двузначную величину(генерация двузначного числа, правая граница не включается) Next(10, 100) интервал числа от 10 до 100
    Console.WriteLine("Your number is " + randomNum);
    
    int ed = randomNum % 10;                // найдем еденицы, % 10 - остаток от деления на 10
    int dec = randomNum / 10;              // найдем десятки

    if (ed > dec)                 //сравниваем десятки и единицы
    {
        return ed;             //завершение метода, возвращение в программу еденицы
    }
    else return dec;         //завершение метода возвращаем в программу десятки
}
Console.Write("The biggest digit is " + Digits());
*/

//Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно a и b.
/*
void Cratnost(int num, int a, int b)       //метод для проверки на кратнось, метод без возвращения -void
{
    if(num % a == 0 && num % b == 0)           //проверка на кратнось
    {
        Console.WriteLine($"Your number {num} is multirle of {a} and {b}");
    }
    else 
    {
        Console.WriteLine($"Your number {num} is not multirle of {a} and {b}");
    }    
}
//Запрос данных у пользователя
Console.Write("Enter your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your 1 divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your 2 divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());
//Вызов метода
Cratnost(user_num, divider1, divider2);               //вызываем метод в самой программе
*/

//Написать программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456 -> 46, 789 -> 79
/*
int DeleteDec()                                         //метод
{
    int randomNum = new Random().Next(100, 1000);         //введение рандомного трехзначного  числа, new Random().Next(...) - генерация числа в интервале;  Next(...) - интервал чисел
    Console.WriteLine("Your number is: " + randomNum);     // вывод этого числа на экран

    int fut_dec = randomNum / 100;    //деление нацело
    int fut_ed = randomNum % 10;      //деление с остатком

    int new_num = fut_dec * 10 + fut_ed;                     //нахождение числа без второй цифры
    return new_num;                                  //возвращение числа без второй цифры
}

Console.WriteLine($"Your new number is {DeleteDec()} ");         //вывод результата через метод
*/