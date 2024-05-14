namespace Tree;

public static class Climber
{
    public static int MaxSum(TreeNode root)
    {
        return root == null ? 0 : FindMaxSum(root);
    }

    private static int FindMaxSum(TreeNode? node)
    {
        if (node == null) return 0;
        if (node.left == null && node.right == null) return node.value;

        int leftMaxSum = node.left != null ? FindMaxSum(node.left) : int.MinValue;
        int rightMaxSum = node.right != null ? FindMaxSum(node.right) : int.MinValue;

        return node.value + Math.Max(leftMaxSum, rightMaxSum);
    }
}