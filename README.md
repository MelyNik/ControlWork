# Итоговая проверочная работа

## Задача: 
 * Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

 ## Основной алгоритм

 1. Вводим количество элементов массива отдельной переменной.
 2. Задаём переменную как условие фильтрации для результирующего массива. 
 3. Создаём строковый массив длиной вводимых ранее количеством элементов с клавиатуры.
 4. Создаём цикл, где вводим с клавиатуры элементы массива по порядку.
 5. Используем метод вывода созданного ранее массива на экран.
 6. Задаём переменной присвоив ей длину нового массива методом.
 7. Создаём результирующий строковый массив присвоив метод заполнения  фильтрации предыдущего массива.
 8. Создаём оператора "Если-иначе".
 9. Выводим результирующий массив согласно оператору в предыдущем пункте.

 ## Метод (PrintArray)
 1. Выводим заданный с клавиатуры массив на экран с помощью цикла перечисления каждого элемента.

 ## Метод (LengthSearchArray)
 1. Создаём новый счётчик.
 2. Создаём цикл перечисления элементов массива.
 3. В цикле создаём оператора "Если-иначе", при условии истины увеличивая новый счётчик на плюс один.
 4. Возвращаем новый счётчик, который будет длиной результирующего массива.

## Метод (GetNewArray)
1. Создаём результирующий массив с длинной предыдущего метода.
2. Создаём новый счётчик как индекс для результирующего массива.
3. Создаём цикл, перечисляя элементы первого массива.
4. Создаём оператора "Если", при условии которого если 
длина элемента первого массива короче или равно заданному числу, то этот элемент добавляем в результирующий массив. 
5. Возвращаем результирующий массив.