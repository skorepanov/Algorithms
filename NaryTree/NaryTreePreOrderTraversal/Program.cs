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

var traversal = new List<int>();
traverseRecursively(root, traversal);
Console.WriteLine(string.Join(separator: ", ", traversal));
return;

void traverseRecursively(Node? node, List<int> visited)
{
    if (node is null)
    {
        return;
    }

    visited.Add(node.Value);

    if (node.Children is null || node.Children.Count == 0)
    {
        return;
    }

    foreach (var nodeChild in node.Children)
    {
        traverseRecursively(nodeChild, visited);
    }
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
