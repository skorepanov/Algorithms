#region Простая сортировка
// var sourceArray = new[] { 5, 4, 5, 5, 1, 1, 3 };
// countingSortSimple(sourceArray);
//
// foreach (var item in sourceArray)
// {
//     Console.WriteLine(item);
// }
#endregion

#region Сортировка со сдвигом
var sourceArray = new[] { -5, 5, 4, 5, 5, 1, 1, 3, 10 };
countingSortWithShift(sourceArray);

foreach (var item in sourceArray)
{
    Console.WriteLine(item);
}
#endregion


// Простая сортировка - когда элементы от 0 до k
void countingSortSimple(int[] array)
{
    // создать и заполнить массив counts
    var k = array.Max();
    var counts = new int[k + 1];

    foreach (var element in array)
    {
        counts[element]++;
    }

    // переписать массив counts начальным индексом каждого элемента
    // для итогового отсортированного массива
    var startingIndex = 0;

    for (var i = 0; i <= k; i++)
    {
        var count = counts[i];
        counts[i] = startingIndex;
        startingIndex += count;
    }

    // заполнить итоговый отсортированный массив
    var sortedArray = new int[array.Length];

    foreach (var element in array)
    {
        sortedArray[counts[element]] = element;
        counts[element]++;
    }

    // переписать исходный массив отсортированным
    // (как вариант - просто вернуть sortedArray из метода)
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = sortedArray[i];
    }
}

// Сортировка со сдвигом - когда элементы в другом диапазоне
void countingSortWithShift(int[] array)
{
    // создать и заполнить массив counts с учётом сдвига
    var shift = array.Min();
    var k = array.Max() - shift;
    var counts = new int[k + 1];

    foreach (var element in array)
    {
        counts[element - shift]++;
    }

    // переписать массив counts начальным индексом каждого элемента
    // для итогового отсортированного массива
    var startingIndex = 0;

    for (var i = 0; i <= k; i++)
    {
        var count = counts[i];
        counts[i] = startingIndex;
        startingIndex += count;
    }

    // заполнить итоговый отсортированный массив
    var sortedArray = new int[array.Length];

    foreach (var element in array)
    {
        sortedArray[counts[element - shift]] = element;
        counts[element - shift]++;
    }

    // переписать исходный массив отсортированным
    // (как вариант - просто вернуть sortedArray из метода)
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = sortedArray[i];
    }
}