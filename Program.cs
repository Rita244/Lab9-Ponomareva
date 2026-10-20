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



// ### Шаг 5. Проверка передачи массива

// void ChangeFirst(int[] array)
// {
//     array[0] = 100;
// }

// int[] data = [1, 2, 3];
// Console.WriteLine($"До:    {string.Join(", ", data)}");
// ChangeFirst(data);
// Console.WriteLine($"После: {string.Join(", ", data)}");




// ### Шаг 6. Свой метод

// void MultiplyByTwo(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= 2;
//     }
// }

// int[] values = [1, 2, 3, 4, 5];
// Console.WriteLine($"До:    {string.Join(", ", values)}");
// MultiplyByTwo(values);
// Console.WriteLine($"После: {string.Join(", ", values)}");

// // Изменения видны в основной программе без ref, потому что массив —
// // ссылочный тип. При передаче параметра копируется не сам массив,
// // а ссылка на него. Метод получает копию ссылки, которая указывает
// // на ТОТ ЖЕ массив в памяти. Поэтому array[i] = ... изменяет
// // элементы исходного массива, который видит вызывающий код



// ### Шаг 7. Статистика по массиву

// int[] data = [7, -3, 12, 0, 5, 9, -8];

// int sum = 0;
// int max = data[0];
// int min = data[0];

// for (int i = 0; i < data.Length; i++)
// {
//     sum += data[i];
//     if (data[i] > max) max = data[i];
//     if (data[i] < min) min = data[i];
// }

// double average = (double)sum / data.Length;

// Console.WriteLine($"Сумма:   {sum}");
// Console.WriteLine($"Среднее: {average:F2}");
// Console.WriteLine($"Максимум: {max}");
// Console.WriteLine($"Минимум:  {min}");



// ### Шаг 8. Почему не `0`

// int[] negative = [-5, -2, -9];

// // Если начинать с максимума 0, то для массива из одних
// // отрицательных чисел 0 окажется больше всех элементов. мы
// // получим max = 0 — неверно
// // min = 0 при поиске минимума по положительным числам
// // тоже даст неверно.Из за этого, начальным значением
// // берут первый элемент массива: он принадлежит массиву



// ### Шаг 9. Ввод с клавиатуры

// int ReadInt(string prompt, bool mustBePositive = false)
// {
//     int value;
//     while (true)
//     {
//         Console.Write(prompt);
//         if (int.TryParse(Console.ReadLine(), out value))
//         {
//             if (!mustBePositive || value > 0)
//                 return value;
//         }
//         Console.WriteLine("Некорректный ввод, попробуйте ещё раз.");
//     }
// }

// int size = ReadInt("Размер массива: ", mustBePositive: true);

// int[] array = new int[size];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = ReadInt($"Элемент {i + 1}: ");
// }

// Console.WriteLine();
// Console.WriteLine($"Массив: {string.Join(", ", array)}");