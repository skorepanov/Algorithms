var list = new List<int> { 20, 10, 15, 5, 1, 3, 2 };
var sortedList = Quicksort(list);

foreach (var item in sortedList)
{
    Console.WriteLine(item);
}


List<int> Quicksort(List<int> list)
{
    if (list.Count <= 1)
    {
        // базовый случай - массивы с 0 и 1 элементом уже отсортированы
        return list;
    }

    // рекурсивный случай
    var pivot = list[0]; // опорный элемент

    var less = list.Where(i => i < pivot).ToList();
    var greater = list.Where(i => i > pivot).ToList();

    var sortedLess = Quicksort(less);
    var sortedGreater = Quicksort(greater);

    return sortedLess
        .Union(new[] { pivot })
        .Union(sortedGreater)
        .ToList();
}