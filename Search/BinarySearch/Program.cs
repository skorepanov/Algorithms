var list = new List<int> { 1, 2, 3, 5, 10, 15, 20 };
var itemToSearch = 3;

var index = binarySearch(list, itemToSearch);

Console.WriteLine($"Индекс элемента {itemToSearch}: {index}");

int? binarySearch(List<int> list, int item)
{
    var lowIndex = 0;
    var highIndex = list.Count - 1;

    while (lowIndex <= highIndex)
    {
        var middleIndex = lowIndex + (highIndex - lowIndex) / 2;
        var guess = list[middleIndex];

        if (guess == item)
        {
            return middleIndex;
        }

        if (guess > item)
        {
            highIndex = middleIndex - 1;
        }
        else
        {
            lowIndex = middleIndex + 1;
        }
    }

    return null;
}