namespace Tree;

public static class Climber
{
    public static int MaxSum(TreeNode root)
    {
        return root switch
        {
            null => 0,
            {left: null,  right: null,  value: var v} => v,
            {left: null,  right: var r, value: var v} => v + MaxSum(r),
            {left: var l, right: null,  value: var v} => v + MaxSum(l),
            {left: var l, right: var r, value: var v} => v + System.Math.Max(MaxSum(l), MaxSum(r)),
        };
    }
}