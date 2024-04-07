﻿// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

// char[,] array = new char[2, 2] { { 'a', 'b' }, { 'c', 'd' } }; // Объявляем и инициализируем двумерный массив символов

// string result = ""; // Объявляем строку, в которую будем собирать символы из массива

// for (int i = 0; i < array.GetLength(0); i++) // Проходим по первому измерению массива (по строкам)
// {
//     for (int j = 0; j < array.GetLength(1); j++) // Внутри каждой строки проходим по второму измерению массива (по столбцам)
//     {
//         result += array[i, j]; // Добавляем текущий символ в строку
//     }
// }
// Выводим получившуюся строку в консоль
Console.WriteLine(result); // Вывод: "abcd"
//------------------------------------------------------------------//
// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

