namespace Tree;



public static class Climber
{
    public static int MaxSum(TreeNode root)
    {
        if (root == null) return 0;

        int maxSum = int.MinValue;
        FindMaxSum(root, 0, ref maxSum);
        return maxSum;  
    }

    private static void FindMaxSum(TreeNode? node, int currentSum, ref int maxSum) // Allow null node
    {
        if (node == null) return;

        currentSum += node.value; 
        if (node.left == null && node.right == null)
        {
            if (currentSum > maxSum)
            {
                maxSum = currentSum; 
            }
        }

        FindMaxSum(node.left, currentSum, ref maxSum);
        FindMaxSum(node.right, currentSum, ref maxSum);
    }
}