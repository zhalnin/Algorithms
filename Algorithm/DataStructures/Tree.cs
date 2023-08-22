using Algorithm.Models;

namespace Algorithm.DataStructures
{
    public class Tree<T> : AlgorithmBase<T> 
        where T : IComparable<T>, IComparable
    {
        private Node<T>? Root { get; set; }
        public int Count { get; private set; }

        public Tree() { }

        public Tree(IEnumerable<T> items)
        {
            //foreach (var item in items)
            //{
            //    Add(item);
            //}

            var list = items.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                Items.Add(item);

                var node = new Node<T>(item, i);
                Add(node);
            }
        }

        public void Add(Node<T> node)
        {
            if (Root is null)
            {
                Root = node;
                Count++;
                return;
            }

            Root.Add(Root,node);
            Count++;
        }

        private List<Node<T>> InOrder(Node<T> node)
        {
            var list = new List<Node<T>>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(InOrder(node.Left));
                }
                list.Add(node);
                if (node.Right != null)
                {
                    list.AddRange(InOrder(node.Right));
                }
            }
            return list;
        }

        protected override void MakeSort()
        {
            var result = InOrder(Root).Select(r => r.Data).ToList();
            for (int i = 0; i < result.Count; i++)
            {
                Set(i, result[i]);
            }
        }
    }
}