
using binary_tree;
using System.ComponentModel.Design;

var root = new Node(10);

root.Left = new Node(5);
root.Right = new Node(15);

root.Left.Left = new Node(2);
root.Left.Right = new Node(7);

root.Right.Left = new Node(12);
root.Right.Right = new Node(17);

root.InOrder().ForEach(x => Console.Write(x + ", "));



int GetHeight(Node root)
{
    if (!root.IsValid())
        throw new InvalidOperationException("It is not a valid Binary Tree");
    int height = 0;
    if (root.IsLeaf())
        return height;
    else
        height++;
        height = height + GetHeight(root.Left);
    return height;
        
}