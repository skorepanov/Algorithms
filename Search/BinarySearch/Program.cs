var sourceList = new List<int> { 1, 2, 3, 5, 10, 15, 20 };
var itemToSearch = 3;

var index1 = binarySearchTemplate1(sourceList, itemToSearch);
var index2 = binarySearchTemplate2(sourceList, itemToSearch);
var index3 = binarySearchTemplate3(sourceList, itemToSearch);

Console.WriteLine($"Вариант 1. Индекс элемента {itemToSearch}: {index1 ?? -1}");
Console.WriteLine($"Вариант 2. Индекс элемента {itemToSearch}: {index2 ?? -1}");
Console.WriteLine($"Вариант 3. Индекс элемента {itemToSearch}: {index3 ?? -1}");
return;

// Вариант 1 - Наиболее базовый и элементарный
int? binarySearchTemplate1(List<int> list, int target)
{
    if (list.Count == 0)
    {
        return null;
    }

    var left = 0;
    var right = list.Count - 1;

    while (left <= right)
    {
        var middle = left + (right - left) / 2;

        if (list[middle] == target)
        {
            return middle;
        }

        if (list[middle] > target)
        {
            right = middle - 1;
        }
        else
        {
            left = middle + 1;
        }
    }

    // left == right + 1
    // кандидатов больше нет
    return null;
}

// Вариант 2 - Усовершенствованная версия варианта 1
int? binarySearchTemplate2(List<int> list, int target)
{
    if (list.Count == 0)
    {
        return null;
    }

    var left = 0;
    var right = list.Count - 1;

    while (left < right)
    {
        var middle = left + (right - left) / 2;

        if (list[middle] == target)
        {
            return middle;
        }

        if (list[middle] > target)
        {
            right = middle;
        }
        else
        {
            left = middle + 1;
        }
    }

    // left == right
    // есть ещё 1 кандидат
    if (list[left] == target)
    {
        return left;
    }

    return null;
}

// Вариант 3 - Альтернативный способ
int? binarySearchTemplate3(List<int> list, int target)
{
    if (list.Count == 0)
    {
        return null;
    }

    var left = 0;
    var right = list.Count - 1;

    while (left + 1 < right)
    {
        var middle = left + (right - left) / 2;

        if (list[middle] == target)
        {
            return middle;
        }

        if (list[middle] > target)
        {
            right = middle;
        }
        else
        {
            left = middle;
        }
    }

    // left + 1 == right
    // есть ещё 2 кандидата
    if (list[left] == target)
    {
        return left;
    }

    if (list[right] == target)
    {
        return right;
    }

    return null;
}