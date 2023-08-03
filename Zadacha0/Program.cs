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

int tmp = MyLine("Введите количество элементов массива: ");

WriteLine($"[{String.Join(", ", newArr(tmp))}]");

int MyLine (string message) //Получение количества элементов в строковом массиве
{
System.Console.WriteLine(message);// Выводим приглашение ко вводу
int result = int.Parse(ReadLine());// приводим к числу
return result; //возвращаем результат
}


string[] newArr (int szarr) // Генерирует строковый массив с заданным количеством элементов
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

