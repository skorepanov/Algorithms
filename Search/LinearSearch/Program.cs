var sourceList = new List<int> { 1, 2, 3, 5, 10, 15, 20 };
var itemToSearch = 3;

var index = linearSearch(sourceList, itemToSearch);

Console.WriteLine($"Индекс элемента {itemToSearch}: {index ?? -1}");

int? linearSearch(List<int> list, int item)
{
    for (var i = 0; i < list.Count; i++)
    {
        if (list[i] == item)
        {
            return i;
        }

        // проверка, прошли ли мы возможную позицию целевого элемента
        if (list[i] > item)
        {
            return null;
        }
    }

    return null;
}