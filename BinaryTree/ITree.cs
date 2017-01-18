using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    interface ITree<T>
    {
        /// <summary>
        /// Inserts an item of type T into the tree
        /// </summary>
        /// <param name="item"></param>
        void Insert(T item);
    }
}
