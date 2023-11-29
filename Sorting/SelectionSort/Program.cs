/*
Selection sort - Сортировка выбором

Алгоритм неустойчивой сортировки.

Шаги алгоритма:
1. Найти номер минимального элемента в списке.
2. Обменять это значение со значением первой неотсортированной позиции.
3. Отсортировать хвост списка, исключив уже отсортированные элементы.

Сложность алгоритма: O(n^2)
*/

var list = new List<int> { 20, 10, 15, 5, 1, 3, 2 };
var sortedList = new List<int>();

for (var i = list.Count - 1; i >= 0; i--)
{
    var smallestIndex = FindSmallestIndex(list);
    sortedList.Add(list[smallestIndex]);
    list.RemoveAt(smallestIndex);
}

foreach (var item in sortedList)
{
    Console.WriteLine(item);
}

int FindSmallestIndex(List<int> list)
{
    var smallest = list[0];
    var smallestIndex = 0;

    for (var i = 1; i < list.Count; i++)
    {
        if (list[i] < smallest)
        {
            smallest = list[i];
            smallestIndex = i;
        }
    }

    return smallestIndex;
}
