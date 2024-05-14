using Tree;

namespace binary_tree_things_tests;

[TestFixture]
public class TreeTests
{
    /**
     * null
     */
    [Test]
    public void MaxSumInNullTree()
    {
        TreeNode root = null;
        Assert.AreEqual(0, Climber.MaxSum(root));
    }

    /**
     *      5
     *    /   \
     *  -22    11
     *  / \    / \
     * 9  50  9   2
     */
    [Test]
    public void MaxSumInPerfectTree()
    {
        TreeNode left = TreeNode.Leaf(-22).WithLeaves(9, 50);
        TreeNode right = TreeNode.Leaf(11).WithLeaves(9, 2);
        TreeNode root = TreeNode.Join(5, left, right);
        Assert.AreEqual(33, Climber.MaxSum(root));
    }
    
    /**
     *         5
     *       /   \
     *    4        10
     *   /  \     /
     * -143 -132 -110 
     */
    [Test]
    public void ShouldStopOnlyAtLeaves()
    {
        TreeNode left = TreeNode.Leaf(4).WithLeaves(-143, -132);
        TreeNode right = TreeNode.Leaf(10).WithLeftLeaf(-110);
        TreeNode root = TreeNode.Join(5, left, right);
        Assert.AreEqual(-95, Climber.MaxSum(root));
    }

    /**
     *       1
     *        \
     *         2
     *          \
     *           3
     *            \
     *             4
     */
    [Test]
    public void MaxSumInRightSkewedTree()
    {
        TreeNode root = new TreeNode(1, null, new TreeNode(2, null, new TreeNode(3, null, new TreeNode(4))));
        Assert.AreEqual(10, Climber.MaxSum(root));
    }

    /**
     *       1
     *      /
     *     2
     *    /
     *   3
     *  /
     * 4
     */
    [Test]
    public void MaxSumInLeftSkewedTree()
    {
        TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(3, new TreeNode(4))));
        Assert.AreEqual(10, Climber.MaxSum(root));
    }

    /**
     *       -10
     *      /    \
     *    9       20
     *          /   \
     *         15    7
     */
    [Test]
    public void MaxSumInTreeWithMixedValues()
    {
        TreeNode left = TreeNode.Leaf(9);
        TreeNode right = TreeNode.Leaf(20).WithLeaves(15, 7);
        TreeNode root = TreeNode.Join(-10, left, right);
        Assert.AreEqual(25, Climber.MaxSum(root));
    }

    /**
     *         0
     *       /   \
     *     1       1
     *    / \     / \
     *   0   0   0   0
     */
    [Test]
    public void MaxSumInZeroValueTree()
    {
        TreeNode left = TreeNode.Leaf(1).WithLeaves(0, 0);
        TreeNode right = TreeNode.Leaf(1).WithLeaves(0, 0);
        TreeNode root = TreeNode.Join(0, left, right);
        Assert.AreEqual(1, Climber.MaxSum(root));
    }

    /**
     *       5
     */
    [Test]
    public void MaxSumInSingleNodeTree()
    {
        TreeNode root = new TreeNode(5);
        Assert.AreEqual(5, Climber.MaxSum(root));
    }

    /**
     *          -3
     *         /   \
     *       -2    -5
     *      / \   / \
     *    -1  -4 -6  -7
     */
    [Test]
    public void MaxSumInAllNegativeValuesTree()
    {
        TreeNode left = TreeNode.Leaf(-2).WithLeaves(-1, -4);
        TreeNode right = TreeNode.Leaf(-5).WithLeaves(-6, -7);
        TreeNode root = TreeNode.Join(-3, left, right);
        Assert.AreEqual(-6, Climber.MaxSum(root));
    }
}
