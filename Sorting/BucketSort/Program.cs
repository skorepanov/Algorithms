var sourceArray = new [] { 20, 10, 15, 5, 1, 3, 2 };
bucketSort(sourceArray, k: 4);

foreach (var item in sourceArray)
{
    Console.WriteLine(item);
}


void bucketSort(int[] array, int k)
{
    var buckets = Enumerable
        .Range(1, k)
        .Select(_ => new List<int>())
        .ToArray();

    var shift = array.Min();
    var maxValue = array.Max() - shift;

    // разместить элементы по корзинам
    var bucketSize = (decimal)maxValue / k;

    if (bucketSize < 1)
    {
        bucketSize = 1;
    }

    foreach (var elem in array)
    {
        // определить номер корзины по формуле: floor(k * A[i] / max(A))
        var index = (int)((elem - shift) / bucketSize);

        if (index == k)
        {
            // поместить максимальное значение в последнюю корзину
            buckets[k - 1].Add(elem);
        }
        else
        {
            buckets[index].Add(elem);
        }
    }

    // отсортировать каждую корзину по-отдельности
    foreach (var bucket in buckets)
    {
        bucket.Sort();
    }

    // собрать элементы из корзин
    var sortedArray = buckets.SelectMany(elem => elem).ToArray();

    // переписать исходный массив отсортированным
    // (как вариант - просто вернуть sortedArray из метода)
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = sortedArray[i];
    }
}