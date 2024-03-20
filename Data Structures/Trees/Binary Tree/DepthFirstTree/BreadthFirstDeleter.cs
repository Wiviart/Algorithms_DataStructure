public class DepthFirstDeleter : IDeletable<Node, Node, string>
{
    public Node Delete(Node? root, string value)
    {
        return DeleteNode(root, null, value);
    }

    Node? DeleteNode(Node? currentNode, Node? previousNode, string value)
    {
        if (currentNode == null) return null;

        // Console.WriteLine($"currentNode: {currentNode.Value}, left: {currentNode?.Left?.Value}, right: {currentNode?.Right?.Value}, previousNode: {previousNode?.Value}");

        if (currentNode.Value != value)
        {
            DeleteNode(currentNode.Left, currentNode, value);
            DeleteNode(currentNode.Right, currentNode, value);
            return null;
        }

        if (previousNode == null)
        {
            Console.WriteLine("Deleted root node");
            return new Node("");
        }

        if (previousNode.Left == currentNode)
        {
            if (currentNode.Left != null)
            {
                previousNode.Left = currentNode.Left;
                if (currentNode.Right != null)
                    GetNewParentNode(previousNode.Left, currentNode.Right, 0);
            }
            else if (currentNode.Right != null)
            {
                previousNode.Left = currentNode.Right;
            }
        }
        else if (previousNode.Right == currentNode)
        {
            if (currentNode.Left != null)
            {
                previousNode.Right = currentNode.Left;
                if (currentNode.Right != null)
                    GetNewParentNode(previousNode.Right, currentNode.Right, 0);
            }
            else if (currentNode.Right != null)
            {
                previousNode.Right = currentNode.Right;
            }
        }

        Console.WriteLine($"Deleted {value}");
        return null;
    }

    void GetNewParentNode(Node parent, Node child, int side)
    {
        switch (side)
        {
            case 0:
                if (parent.Left == null)
                    parent.Left = child;
                else
                    GetNewParentNode(parent.Left, child, side);
                break;
            case 1:
                if (parent.Right == null)
                    parent.Right = child;
                else
                    GetNewParentNode(parent.Right, child, side);
                break;
        }
    }
}