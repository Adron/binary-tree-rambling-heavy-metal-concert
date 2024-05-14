namespace Tree;

public class TreeNode
{
    public int value;
    public TreeNode? left, right; // Make left and right nullable

    public TreeNode(int value, TreeNode? left = null, TreeNode? right = null) // Allow nulls
    {
        this.value = value;
        this.left = left;
        this.right = right;
    }

    public static TreeNode Leaf(int value)
    {
        return new TreeNode(value);
    }

    public TreeNode WithLeaves(int leftValue, int rightValue)
    {
        this.left = new TreeNode(leftValue);
        this.right = new TreeNode(rightValue);
        return this;
    }

    public TreeNode WithLeftLeaf(int leftValue)
    {
        this.left = new TreeNode(leftValue);
        return this;
    }

    public static TreeNode Join(int value, TreeNode? left, TreeNode? right) // Allow nulls
    {
        return new TreeNode(value, left, right);
    }
}