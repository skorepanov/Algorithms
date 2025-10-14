var root = new Node(value: 1,
    children:
    [
        new Node(value: 2),
        new Node(value: 3,
            children:
            [
                new Node(value: 5),
                new Node(value: 6)
            ]),
        new Node(value: 4,
            children:
            [
                new Node(value: 7)
            ])
    ]);

var traversal = levelOrder(root);

foreach (var level in traversal)
{
    Console.WriteLine(string.Join(separator: ", ", level));
}
return;


List<List<int>> levelOrder(Node? root)
{
    if (root is null)
    {
        return new List<List<int>>();
    }

    var visited = new List<List<int>>();

    var pendingNodes = new Queue<Node>();
    pendingNodes.Enqueue(root);

    while (pendingNodes.Count > 0)
    {
        var levelTraversal = new List<int>();
        var levelNodeCount = pendingNodes.Count;

        for (var i = 0; i < levelNodeCount; i++)
        {
            var currentNode = pendingNodes.Dequeue();
            levelTraversal.Add(currentNode.Value);

            if (currentNode.Children is null || currentNode.Children.Count == 0)
            {
                continue;
            }

            foreach (var childNode in currentNode.Children)
            {
                pendingNodes.Enqueue(childNode);
            }
        }

        visited.Add(levelTraversal);
    }

    return visited;
}

public class Node
{
    public readonly int Value;
    public readonly List<Node>? Children;

    public Node(int value = 0, List<Node>? children = null)
    {
        Value = value;
        Children = children;
    }
}