namespace binary_tree;

internal class Node(int value)
{
    public Node? Left;
    public Node? Right;
    public int Value = value;

    public bool IsLeaf() => Left == null && Right == null;
    public bool IsValid(){
        
        if(IsLeaf()) return true;

        if(Left == null || Right == null) return false;

        return Left!.IsValid() && Right!.IsValid();
    }

    public List<Node> PreOrder()
    {
        var preOrder = new List<Node>();
        preOrder.Add(this);
        if(Left != null)
            preOrder.AddRange(Left.PreOrder());
        if(Right != null) 
            preOrder.AddRange(Right.PreOrder());
        return preOrder;
    }
    public List<Node> InOrder()
    {
        var inOrder = new List<Node>();

        if(Left != null)
            inOrder.AddRange(Left.InOrder());

        inOrder.Add(this);

        if(Right != null) 
            inOrder.AddRange(Right.InOrder());
        return inOrder;
    }
    public List<Node> PostOrder()
    {
        var postOrder = new List<Node>();

        if(Left != null)
            postOrder.AddRange(Left.PostOrder());

        postOrder.Add(this);

        if(Right != null) 
            postOrder.AddRange(Right.PostOrder());
        return postOrder;
    }

    public override string ToString()
    {
        return this.Value.ToString();
    }
}


