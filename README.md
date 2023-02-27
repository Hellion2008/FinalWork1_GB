# FinalWork1_GB

Данная программа формирует из имеющегося массива строк новый массив строк, в котором элементы менеше либо равны 3 символам. 

## Основной блок.

С клавиатуры пользователем вводится натуральное число для определения длины изначального массива. Далее пользователем поочередно вводятся все элементы массива. После этого с помощью написанного метода GetArrayWithThreeSymbols высчитывается новый массив и как результат в консоль выводятся поочередно все элементы старого и нового массива. 
Были использованы 3 метода: GetNumber, GetArray, GetArrayWithThreeSymbols.

## int GetNumber(string text)

В консоль выводтся вспомогательная строка text. Далее с клавиатуры пользователь вводит натуриальное целое число, которое данный метод возвращает.

## string[] GetArray(int size)

Как аргумент вводится натуральное число size. Сначала объявляется новый строковый массив arr с длиной, равной числу size. Далее с помощью цикла заполняем массив arr элементами. Массив заполняется строковыми данными, введенными пользователем с клавиатуры. Из метода возвращаем строковый массив arr.

## string[] GetArrayWithThreeSymbols(string[] arr)

Как аргумент вводится строковый массив arr. Сначала объявляется новый строковый массив secondArr с длиной, равной длине массива arr, и инициализируется счетчик count нулевым значением. Далее создаем цикл от 0 до длины массива arr, где проверяем каждый элемент-строку какой он длины. Если элемент меньше или равен 3 символам, то этот элемент добавляем в массив secondArr на позицию count, счетчик count увеличиваем на единицу. Если элемент больше 3 символов, то пропускаем. После выхода из цикла с помощью оператора Array.Resize уменьшаем, если надо, длину массива secondArr, тем самым удаляя null значения. Из метода возвращаем secondArr.