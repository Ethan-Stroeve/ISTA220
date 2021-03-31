using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Lab19BinaryTree
{
    class TreeEnumerator<TItem> : IEnumerator<TItem> where TItem : IComparable<TItem>
    {
        private Tree<TItem> currentData = null;
        private TItem currentItem = default(TItem);
        private Queue<TItem> enumData = null;

        public TreeEnumerator(Tree<TItem> data)
        {
            currentData = data;
        }

        TItem IEnumerator<TItem>.Current
        {
            get
            {
                if (enumData == null)
                {
                    throw new InvalidOperationException("Use MoveNext before calling Current");
                }

                return currentItem;
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        void IDisposable.Dispose()
        {
            //throw new NotImplementedException();
        }

        bool IEnumerator.MoveNext()
        {
            if (enumData == null)
            {
                enumData = new Queue<TItem>();
                populate(enumData, currentData);
            }

            if (enumData.Count > 0)
            {
                currentItem = enumData.Dequeue();
                return true;
            }

            return false;
        }

        private void populate(Queue<TItem> enumQueue, Tree<TItem> tree)
        {
            if (tree.LeftTree != null)
            {
                populate(enumQueue, tree.LeftTree);
            }

            enumQueue.Enqueue(tree.NodeData);

            if (tree.RightTree != null)
            {
                populate(enumQueue, tree.RightTree);
            }
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
