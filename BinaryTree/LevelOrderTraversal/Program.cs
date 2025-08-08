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

var traversal = traverse(root);

foreach (var level in traversal)
{
    Console.WriteLine(string.Join(separator: ", ", level));
}
return;


IList<IList<int>> traverse(TreeNode root)
{
    var visited = new List<IList<int>>();
    var pendingNodes = new Queue<TreeNode>();

    pendingNodes.Enqueue(root);

    while (pendingNodes.Count > 0)
    {
        var queueLength = pendingNodes.Count;
        var currentLevelValues = new List<int>();
        TreeNode currentNode;

        while (queueLength > 0)
        {
            currentNode = pendingNodes.Dequeue();
            currentLevelValues.Add(currentNode.Value);

            if (currentNode.Left is not null)
            {
                pendingNodes.Enqueue(currentNode.Left);
            }

            if (currentNode.Right is not null)
            {
                pendingNodes.Enqueue(currentNode.Right);
            }

            queueLength--;
        }

        visited.Add(currentLevelValues);
    }

    return visited;
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
