// ### Шаг 2. Работа с элементами

// int[] scores = [5, 4, 3, 5, 4];

// Console.WriteLine($"Первый элемент: {scores[0]}");
// Console.WriteLine($"Последний элемент: {scores[^1]}");

// scores[2] = 5;
// Console.WriteLine($"Массив: {string.Join(", ", scores)}");
// Console.WriteLine($"Последний элемент: {scores[scores.Length - 1]}");



// ## Часть 2. `for` и `foreach`

// ### Шаг 3. Два способа перебора

// int[] scores = [5, 4, 3, 5, 4];

// // for удобно, потому что нужен номерэлемента
// for (int i = 0; i < scores.Length; i++)
// {
//     Console.WriteLine($"Индекс {i}: {scores[i]}");
// }

// Console.WriteLine();

// foreach (int score in scores)
// {
//     Console.WriteLine(score);
// }


// ### Шаг 4. Ищем ошибку

// int[] numbers = [10, 20, 30];

// for (int i = 0; i <= numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }

// // 1. До ошибки числа: 10, 20, 30
// // 2. i = 3, Length = 3
// // 3. Условие i <= numbers.Length истинно при i = 3 (3 <= 3),
// //    тело цикла выполнилось и произошло обращение к numbers[3]
// // 4. Изменить условие на i < numbers.Length

// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }

