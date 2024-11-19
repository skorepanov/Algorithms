var sourceList = new List<int> { 1, 2, 3, 5, 10, 15, 20 };
var itemToSearch = 3;

var index = interpolationSearch(sourceList, itemToSearch);

Console.WriteLine($"Индекс элемента {itemToSearch}: {index ?? -1}");

int? interpolationSearch(List<int> list, int item)
{
    var lowIndex = 0;
    var highIndex = list.Count - 1;

    while (list[lowIndex] < item && list[highIndex] > item)
    {
        // защита от деления на 0
        if (list[highIndex] == list[lowIndex])
        {
            break;
        }

        var middleIndex = lowIndex
            + ((item - list[lowIndex]) * (highIndex - lowIndex))
                / (list[highIndex] - list[lowIndex]);

        if (list[middleIndex] == item)
        {
            return middleIndex;
        }

        if (list[middleIndex] < item)
        {
            lowIndex = middleIndex + 1;
        }
        else if (list[middleIndex] > item)
        {
            highIndex = middleIndex - 1;
        }
    }

    if (list[lowIndex] == item)
    {
        return lowIndex;
    }

    if (list[highIndex] == item)
    {
        return highIndex;
    }

    return null;
}