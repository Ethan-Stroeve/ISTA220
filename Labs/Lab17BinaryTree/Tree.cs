using System;

namespace Lab17BinaryTree
{
    public class Tree<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { get; set; }
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RightTree { get; set; }
        public Tree(TItem nodeValue)
        {
            NodeData = nodeValue;
            LeftTree = null;
            RightTree = null;
        }
        public void Insert(TItem newItem)
        {
            TItem currentNodeValue = NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                // Insert the item into the left subtree
                if (LeftTree == null)
                {
                    LeftTree = new Tree<TItem>(newItem);
                }
                else
                {
                    LeftTree.Insert(newItem);
                }
            }
            else
            {
                // Insert the new item into the right subtree
                if (RightTree == null)
                {
                    RightTree = new Tree<TItem>(newItem);
                }
                else
                {
                    RightTree.Insert(newItem);
                }
            }
        }
        public string WalkTree()
        {
            string result = "";

            if (this.LeftTree != null)
            {
                result = this.LeftTree.WalkTree();
            }

            result += $" {this.NodeData.ToString()} ";

            if (this.RightTree != null)
            {
                result += this.RightTree.WalkTree();
            }

            return result;
        }
    }
}
