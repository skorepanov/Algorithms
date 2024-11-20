var graph = new Dictionary<int, int[]>
{
    [1] = new[] { 2, 3, 4 },
    [2] = new[] { 5 },
    [3] = new [] { 6, 7 },
    [4] = new [] { 8 },
    [5] = new [] { 9 },
    [6] = new [] { 10 }
};

breadthFirstTraverse(graph);


void breadthFirstTraverse(IReadOnlyDictionary<int, int[]> intsMap)
{
    var coveredElements = new HashSet<int>();

    var queue = new Queue<int>();
    var firstKey = intsMap.ElementAt(0).Key;
    queue.Enqueue(firstKey);

    while (queue.Any())
    {
        var element = queue.Dequeue();

        if (coveredElements.Contains(element))
        {
            continue;
        }

        Console.WriteLine($"Visit {element}");

        coveredElements.Add(element);

        #region Если надо найти элемент, удовлетворяющий некоторому условию
        // if (element == valueToFind)
        // {
        //     return element;
        // }
        #endregion

        intsMap.TryGetValue(element, out var neighbours);

        if (neighbours is null)
        {
            continue;
        }

        foreach (var neighbour in neighbours)
        {
            queue.Enqueue(neighbour);
        }
    }
}
