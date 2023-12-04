/*
Breadth-First Search (BFS) - Поиск в ширину

Позволяет найти кратчайшее расстояние между двумя объектами.
Задачи такого типа называются задачами поиска кратчайшего пути.

Также алгоритм позволяет выяснить, существует ли путь от узла А к узлу Б?

Примеры использования:
- Найти ближайшего врача.
- Вычислить кратчайший путь к победе в игре в шашки.
- Реализовать проверку правописания - найти минимальное количество изменений
для преобразования ошибочного слова в правильное.

Время выполнения: O(кол-во вершин + кол-во рёбер).
Другая запись: O(V+E), где V - кол-во вершин, E - кол-во рёбер.
*/

var graph = new Dictionary<int, int[]>
{
    [1] = new[] { 2, 3, 4 },
    [2] = new[] { 5 },
    [3] = new [] { 6, 7 },
    [4] = new [] { 8 },
    [5] = new [] { 9 },
    [6] = new [] { 10 }
};

var desiredElement = findElement(graph);


int? findElement(Dictionary<int, int[]> intsMap)
{
    var coveredElements = new HashSet<int>();

    var queue = new Queue<int>();
    queue.Enqueue(intsMap.ElementAt(0).Key);

    while (queue.Any())
    {
        var element = queue.Dequeue();

        if (coveredElements.Contains(element))
        {
            continue;
        }

        Console.WriteLine($"Visit {element}");

        coveredElements.Add(element);

        #region Если задача: найти элемент, удовлетворяющий некоторому условию
        if (element == 9)
        {
            return element;
        }
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

    return null;
}
