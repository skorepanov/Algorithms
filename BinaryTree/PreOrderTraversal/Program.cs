var root = new TreeNode(1,
    left: new TreeNode(2,
        left: new TreeNode(4),
        right: new TreeNode(5,
            left: new TreeNode(6),
            right: new TreeNode(7))),
    right: new TreeNode(3,
        left: null,
        right: new TreeNode(8,
            left: new TreeNode(9))));

var traversal = new List<int>();
//traverseRecursively(root, traversal);
traversal = traverseIteratively(root);
Console.WriteLine(string.Join(separator: ", ", traversal));
return;

#region Вариант 1 - Рекурсивный обход
void traverseRecursively(TreeNode? node, List<int> visited)
{
    if (node is null)
    {
        return;
    }

    visited.Add(node.Value);
    traverseRecursively(node.Left, visited);
    traverseRecursively(node.Right, visited);
}
#endregion

#region Вариант 2 - Итеративный обход
List<int> traverseIteratively(TreeNode root)
{
    var visited = new List<int>();

    var pendingNodes = new Stack<TreeNode>();
    pendingNodes.Push(root);

    TreeNode currentNode;

    while (pendingNodes.Count > 0)
    {
        currentNode = pendingNodes.Pop();
        visited.Add(currentNode.Value);

        if (currentNode.Right is not null)
        {
            pendingNodes.Push(currentNode.Right);
        }

        if (currentNode.Left is not null)
        {
            pendingNodes.Push(currentNode.Left);
        }
    }

    return visited;
}
#endregion

public class TreeNode
{
    public readonly int Value;
    public readonly TreeNode? Left;
    public readonly TreeNode? Right;

    public TreeNode(int value = 0, TreeNode? left = null, TreeNode? right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}