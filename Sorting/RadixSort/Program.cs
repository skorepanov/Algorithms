// LSD - Least Significant Digit
var sourceArray = new [] { 20, 10, 15, 5, 1, 3, 2 };
radixSortByLsd(sourceArray);

foreach (var item in sourceArray)
{
    Console.WriteLine(item);
}


const int NUM_DIGITS = 10;

void radixSortByLsd(int[] array)
{
    var maxElement = array.Max();
    var placeVal = 1;

    while (maxElement / placeVal > 0)
    {
        countingSort(array, placeVal);
        placeVal *= 10;
    }
}

// Используется сортировка подсчётом (простая)
void countingSort(int[] array, int placeVal)
{
    // создать и заполнить массив counts
    var counts = new int[NUM_DIGITS];

    foreach (var element in array)
    {
        var current = element / placeVal;
        counts[current % NUM_DIGITS]++;
    }

    // переписать массив counts начальным индексом каждого элемента
    // для итогового отсортированного массива
    var startingIndex = 0;

    for (var i = 0; i < counts.Length; i++)
    {
        var count = counts[i];
        counts[i] = startingIndex;
        startingIndex += count;
    }

    // заполнить итоговый отсортированный массив
    var sortedArray = new int[array.Length];

    foreach (var element in array)
    {
        var current = element / placeVal;
        sortedArray[counts[current % NUM_DIGITS]] = element;
        counts[current % NUM_DIGITS]++;
    }

    // переписать исходный массив отсортированным
    // (как вариант - просто вернуть sortedArray из метода)
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = sortedArray[i];
    }
}