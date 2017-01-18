using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree<T> : ITree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public Tree<T> LeftTree { get; set; }
        public Tree<T> RightTree { get; set; }

        public Tree(T nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;         
        }


        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;

            if (currentNodeValue.CompareTo(item) > 0)
            {
                //Insert into the left subtree
                if(this.LeftTree == null)
                {
                    this.LeftTree = new Tree<T>(item);
                }
                else
                {
                    this.LeftTree.Insert(item);
                }
            }
            else
            {
                //Insert into the right subtree
                if(this.RightTree == null)
                {
                    this.RightTree = new Tree<T>(item);
                }
                else
                {
                    this.RightTree.Insert(item);
                }
            }
        }

        public string Traverse()
        {
            string result = "";

            if(this.LeftTree != null)
            {
                result = this.LeftTree.Traverse();
            }

            result += $" {this.NodeData.ToString()} ";
            
            if(this.RightTree != null)
            {
                result = this.RightTree.Traverse();
            }
            return result;
        }
    }
}
