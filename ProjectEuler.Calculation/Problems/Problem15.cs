using System;
using System.Drawing;
using ProjectEuler.Model;

namespace ProjectEuler.Calculation.Problems
{
    public class Problem15 :IProblem
    {
        #region Implementation of IProblem

        public void Run()
        {

            // We need the (2*dimension)th row in the pascal triangle and its middle element
            Console.WriteLine(Factorial.FactBig(40)/(Factorial.FactBig(20)*Factorial.FactBig(20)));
        }

        public void RunFor2()
        {
            
        }

        public void RunFor3()
        {
            
        }
        #endregion
        public void RunOld()
        {
            
            Int32 dimension = 1;

            BinaryTree<Point> tree = new BinaryTree<Point>();
            tree.Root = new Node<Point>(new Point(0,0));
            Node<Point> currentNode = tree.Root;
            while (true)
            {

                Boolean canGoUp = currentNode.Parent != null;
                Int32 prevSum = -1;
                Int32 currSum = currentNode.Value.X + currentNode.Value.Y+1;
                if (canGoUp) prevSum = currentNode.Parent.Value.X + currentNode.Parent.Value.Y;
                else prevSum = 0;
                var value = currentNode.Value;
                if ( value.Y < dimension && prevSum < currSum && currentNode.Left == null)
                {
                    // GO left, we can go left
                    Node<Point> newNode = new Node<Point>(new Point(value.X,value.Y+1));
                    newNode.Parent = currentNode;
                    currentNode.Left = newNode;
                    currentNode = newNode;
                }
                else if (value.X < dimension  && prevSum < currSum && currentNode.RIght == null)
                {
                    //Go Right, we can go right
                    Node<Point> newNode = new Node<Point>(new Point(value.X+1, value.Y ));
                    newNode.Parent = currentNode;
                    currentNode.RIght = newNode;
                    currentNode = newNode;
                }
                else
                {
                    if(currentNode.Parent == null) break;
                    else
                    {
                        currentNode = currentNode.Parent;
                    }
                }

            }

            Int32 sum = 0;

            tree.InOrder(node =>
            {
                if (node.Left == null && node.RIght == null) sum++;
            });
            Console.WriteLine(sum);
        }

        
    }
}