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
traverse(root, traversal);
Console.WriteLine(string.Join(separator: ", ", traversal));
return;


void traverse(TreeNode? node, List<int> visited)
{
    if (node is null)
    {
        return;
    }

    traverse(node.Left, visited);
    traverse(node.Right, visited);
    visited.Add(node.Value);
}

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