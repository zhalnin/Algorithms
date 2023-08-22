namespace Algorithm.DataStructures;

public class Node<T> where T : IComparable<T>, IComparable
{
    public T Data { get; set; }
    public Node<T> Left { get; private set; }
    public Node<T> Right { get; private set; }
    public int Index { get; set; }

    public Node(T data) =>
        Data = data;

    public Node(T data, int index) =>
        (Data, Index) = (data, index);

    public void Add(Node<T> node, Node<T> newNode)
    {
        if (node.Data.CompareTo(newNode.Data) > 0)
        {
            if (Left is null)
            {
                Left = newNode;
            }
            else
            {
                Left.Add(node.Left, newNode);
            }
        }
        else
        {
            if (Right is null)
            {
                Right = newNode;
            }
            else
            {
                Right.Add(node.Right, newNode);
            }
        }
    }

    public int CompareTo(T? other)
    {
        if (other is Node<T> item)
        {
            return Data.CompareTo(item.Data);
        }
        else
        {
            throw new ArgumentException("The types are not equals");
        }
    }

    public int CompareTo(object? obj)
    {
        if (obj is Node<T> item)
        {
            return Data.CompareTo(item.Data);
        }
        else
        {
            throw new ArgumentException("The types are not equals");
        }
    }

    public override string ToString()
    {
        return $"Node: {Data.ToString()}";
    }
}