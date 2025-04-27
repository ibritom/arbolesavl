namespace arbolesavl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AVLTree tree = new AVLTree();
            tree.insert(10);
            tree.insert(20);
            tree.insert(30);
            tree.insert(40);
            tree.insert(50);

            Console.WriteLine("Root value: " + tree.root.Value);
        }
    }
}
