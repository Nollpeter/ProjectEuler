using System;
using System.Collections.ObjectModel;

namespace ProjectEuler.Model
{
    public class Node<T>
    {
        // Private member-variables

        public Node()
        {
        }

        public Node(T data) : this(data, null)
        {
        }

        public Node(T data, NodeList<T> neighbors)
        {
            this.Value = data;
            
        }

        public T Value { get; set; }

        public Node<T> Parent { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> RIght { get; set; }
    }

    public class NodeList<T> : Collection<Node<T>>
    {
        public NodeList() : base()
        {
        }

        public NodeList(int initialSize)
        {
            // Add the specified number of items
            for (int i = 0; i < initialSize; i++)
                base.Items.Add(default(Node<T>));
        }

        public Node<T> FindByValue(T value)
        {
            // search the list for the value
            foreach (Node<T> node in Items)
                if (node.Value.Equals(value))
                    return node;

            // if we reached here, we didn't find a matching node
            return null;
        }

        
    }

    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        public void InOrder(Action<Node<T>> visit)
        {
            InOrder(Root,visit);
        }
        public void PreOrder(Action<Node<T>> visit)
        {
            PreOrder(Root, visit);
        }
        public void PostOrder(Action<Node<T>> visit)
        {
            PostOrder(Root, visit);
        }
        protected void InOrder(Node<T> node, Action<Node<T>> visit)
        {
            if (node == null) return;

            InOrder(node.Left, visit);
            visit(node);
            InOrder(node.RIght, visit);
        }
        protected void PreOrder(Node<T> node, Action<Node<T>> visit)
        {
            if (node == null) return;

            PreOrder(node.Left, visit);
            visit(node);
            PreOrder(node.RIght, visit);
        }
        protected void PostOrder(Node<T> node, Action<Node<T>> visit)
        {
            if (node == null) return;

            PostOrder(node.Left, visit);
            visit(node);
            PostOrder(node.RIght, visit);
        }

    }
}

