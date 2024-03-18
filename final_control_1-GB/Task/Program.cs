// Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.


﻿string[] workArray = FillArray();
string[] resultArray = GenerateNewArray(workArray);
string firstArray = PrintArray(workArray);
string secondArray = PrintArray(resultArray);
Console.WriteLine(firstArray + " -> " + secondArray);

string[] FillArray()
{
    Console.WriteLine("Введите элементы исходного массива через пробел, и нажмите Enter: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] workArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArray;
}
