namespace hacker_rank_tree_level_order_traversal
{
    public class Node
    {
        public Node(int data)
        {
            Data = data;
        }

        public Node Left
        {
            get;
            private set;
        }

        public Node Right
        {
            get;
            private set;
        }

        public int Data
        {
            get;
            private set;
        }


        public void SetRightNode(Node node)
        {
            Right = node;
        }

        public void SetLeftNode(Node node)
        {
            Left = node;
        }
    }
}
