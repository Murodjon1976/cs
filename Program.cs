Console.Clear();
/* Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
*/

/*void PrintNumber(int a, int b)
{
    Console.Write($"{a}, ");
    if (a==b)
    {
        return;
    }
    else if (a<b)
    {
        a+=1;
    }
    else if (a>b)
    {
        a-=1;
    }
    PrintNumber(a,b);
    
}
Console.Write("Введите первое число: ");
int firstNumber =int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondNumber =int.Parse(Console.ReadLine()!);
PrintNumber(firstNumber,secondNumber);
*/


/* Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/

/*
int FuncAker(int a, int b)
{
    if (a==0)
    {
        return b+=1;
    }
    else 
        if (a>0 && b==0)
        {
            return FuncAker(a-1,1);
        } 
        else 
        {
            return FuncAker(a-1,FuncAker(a,b-1));
        } 


}
Console.Write("Введите первое число: ");
int firstNumber =int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondNumber =int.Parse(Console.ReadLine()!);
Console.WriteLine (FuncAker(firstNumber,secondNumber));
*/

/* Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.
*/
void PrintArray(int[] array,int n=1)
{
    if (n>array.Length)
    {
        return;
    }
    Console.Write($"{array[array.Length-n]} ");
    PrintArray(array,n+1);

}
int[] numbers = {3, 4, 5, 6, 7, 8};
PrintArray(numbers);

