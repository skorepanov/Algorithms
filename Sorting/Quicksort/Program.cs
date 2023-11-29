/*
Quicksort - Быстрая сортировка

Алгоритм неустойчивой сортировки.
Алгоритм "разделяй и властвуй".

Шаги алгоритма:
1. Выбрать элемент, называемый опорным.
Он может быть любым, но от его выбора зависит скорость алгоритма.
2. Найти элементы, меньшие опорного, и элементы, большие опорного.
Этот процесс называется разделением.
3. Применить алгоритм быстрой сортировки к обоим подмассивам.
4. Объединить результаты:
Подмассив с меньшими элементами + опорный элемент + подмассив с большими элементами.

Сложность алгоритма
- в среднем: O(n*log(n))
- в худшем случае: O(n^2)
*/

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
    var pivot = list[0];

    var less = list.Where(i => i < pivot).ToList();
    var greater = list.Where(i => i > pivot).ToList();

    var sortedLess = Quicksort(less);
    var sortedGreater = Quicksort(greater);

    return sortedLess
        .Union(new[] { pivot })
        .Union(sortedGreater)
        .ToList();
}