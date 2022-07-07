

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNumbers(int num)
{
    int i = 0; // счетчик
    int summa = 0;
    int summa1 = 0;
    while(i <= num)
    {   
        summa = num - num%10;
        summa1 = summa1 + (num - summa);
        num = num/10;
        i++;
    }
    return summa1;
}

Console.Write("Input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = SumNumbers(n1);

Console.WriteLine("sum all numbers = " + n2);




//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


int[] array = new int [8];

array [0] = 1;
array [1] = 2;
array [2] = 5;
array [3] = 7;
array [4] = 19;
array [5] = 6;
array [6] = 1;
array [7] = 33;

Console.Write(array[0] + ", "); Console.Write(array[1] + ", "); Console.Write(array[2] + ", "); Console.Write(array[3] + ", "); Console.WriteLine(array[4]); 
Console.Write(array[5] + ", "); Console.Write(array[6] + ", "); Console.Write(array[7]);
Console.ReadLine();
