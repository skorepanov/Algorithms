var list = new List<int> { 1, 2, 3, 5, 10, 15, 20 };
var itemToSearch = 3;

var index = interpolationSearch(list, itemToSearch);

Console.WriteLine($"Индекс элемента {itemToSearch}: {index ?? -1}");

int? interpolationSearch(List<int> list, int item)
{
    var low = 0;
    var high = list.Count - 1;

    while (list[low] < item && list[high] > item)
    {
        // защита от деления на 0
        if (list[high] == list[low])
        {
            break;
        }

        var mid = low + ((item - list[low]) * (high - low)) / (list[high] - list[low]);

        if (list[mid] == item)
        {
            return mid;
        }

        if (list[mid] < item)
        {
            low = mid + 1;
        }
        else if (list[mid] > item)
        {
            high = mid - 1;
        }
    }

    if (list[low] == item)
    {
        return low;
    }

    if (list[high] == item)
    {
        return high;
    }

    return null;
}