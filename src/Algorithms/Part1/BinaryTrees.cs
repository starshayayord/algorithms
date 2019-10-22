using System;

namespace Part1
{
    public class BinaryTrees
    {
        public class Node<T> where T : IComparable<T>
        {
            public Node(T value)
            {
                Value = value;
            }

            public T Value { get; }

            public Node<T> Left { get; set; }

            public Node<T> Right { get; set; }
        }

        public class BinaryTree<T> where T : IComparable<T>
        {
            public Node<T> Root { get; set; }

            public void Add(T value)
            {
                if (Root == null)
                {
                    Root = new Node<T>(value);
                }
                else
                {
                    AddRecursive(Root, value);
                }
            }

            //рекурсивная реализации
            private void AddRecursive(Node<T> currentNode, T value)
            {
                if (currentNode.Value.CompareTo(value) > 0)
                {
                    if (currentNode.Left == null)
                    {
                        currentNode.Left = new Node<T>(value);
                    }
                    else
                    {
                        AddRecursive(currentNode.Left, value);
                    }
                }
                else
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = new Node<T>(value);
                    }
                    else
                    {
                        AddRecursive(currentNode.Right, value);
                    }
                }
            }

            //итерационная реализация
            private void AddIteration(Node<T> currentNode, T value)
            {
                while (true)
                {
                    if (currentNode.Value.CompareTo(value) > 0)
                    {
                        if (currentNode.Left == null)
                        {
                            currentNode.Left = new Node<T>(value);
                        }
                        else
                        {
                            currentNode = currentNode.Left;
                            continue;
                        }
                    }
                    else
                    {
                        if (currentNode.Right == null)
                        {
                            currentNode.Right = new Node<T>(value);
                        }
                        else
                        {
                            currentNode = currentNode.Right;
                            continue;
                        }
                    }

                    break;
                }
            }
        }
    }
}
