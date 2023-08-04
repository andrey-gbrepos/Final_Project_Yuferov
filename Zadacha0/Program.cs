//Задача: Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, либо равна 
//3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
//задать на старте выполнения алгоритма. При решении не рекомендуется 
//пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

using System;
using static System.Console;

Clear();

WriteLine("     Программа из имеющегося массива строк формирует новый массив,");
WriteLine("          длина элементов которого не превышает трех символов.");
WriteLine("(Исходный массив генерируется автоматически, с количеством элементов заданным пользователем.)");

WriteLine();
int tmp = MyLine("Введите количество элементов исходного массива: ");//Задание количества элементов исходного массива
string[] rndArr = newArr(tmp); //Генерация исходного массива с заданным колличеством элементов

WriteLine();
WriteLine($"Исходный массив из {rndArr.Length} элементов:");
WriteLine($"[{String.Join(", ", rndArr)}]");

WriteLine();
WriteLine($"Получен массив из {resArr(rndArr).Length} элементов:");
WriteLine($"[{String.Join(", ", resArr(rndArr))}]");

WriteLine();


int MyLine (string message) //МЕТОД - получение количества элементов в строковом массиве
{
Write(message);// Выводим приглашение ко вводу
int result = int.Parse(ReadLine());// приводим к числу
return result; //во8звращаем результат
}


string[] newArr (int szarr) //МЕТОД - Генерирует строковый массив с заданным количеством элементов
{
string[] myArray = new string[szarr];
for(int j = 0; j < myArray.Length; j++)
{
int rnd = new Random().Next(1, 10);
string m = string.Empty;
for(int i = 0; i< rnd; i++)
{ 
    int strnd = new Random().Next(33, 127);
    m += Convert.ToChar(strnd);
}
myArray[j] = m;
}
return myArray;
}

string[] resArr (string[] inArr) //МЕТОД - Формирует новый массив с элементами от 3-х и менее символов
{
    int count = 0;
    string strtmp = string.Empty;
    for (int i = 0; i < inArr.Length; i++)
    {
        if (inArr[i].Length < 4) 
        {            
           count++; // считаем сколько нужных нам элементов в массиве
        }
    }
       string[] tmpArr = new string[count]; //Создаем новый массив необходимого размера
       count = 0;
    for (int i = 0; i < inArr.Length; i++) //Заполняем массив
    {
        if (inArr[i].Length < 4) 
        {
            tmpArr[count] = inArr[i];
            count++;
        }
    }
    return tmpArr;
}