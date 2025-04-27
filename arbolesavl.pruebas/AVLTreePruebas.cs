using arbolesavl;
namespace arbolesavl.pruebas;

[TestClass]
public class AVLTreePruebas
{
    [TestMethod]
    public void heightPruebas()
    {
        AVLTree tree = new AVLTree();
        tree.insert(10);
        tree.insert(20);
        tree.insert(30);
        Assert.AreEqual(2, tree.height(tree.root));
    }
    [TestMethod]
    public void getBalancePruebas()
    {
        AVLTree tree = new AVLTree();
        tree.insert(10);
        tree.insert(20);
        tree.insert(30);
        Assert.AreEqual(0, tree.getBalace(tree.root));
    }
    [TestMethod]
    public void rightRotatePruebas()
    {
        AVLTree tree = new AVLTree();
        tree.insert(30);
        tree.insert(20);
        tree.insert(10);
        Assert.AreEqual(20, tree.root.Value);
    }
    [TestMethod]
    public void leftRotatePruebas()
    {
        AVLTree tree = new AVLTree();
        tree.insert(10);
        tree.insert(20);
        tree.insert(30);
        Assert.AreEqual(20, tree.root.Value);
    }
    [TestMethod]
    public void insertPruebas()
    {
        AVLTree tree = new AVLTree();
        tree.insert(10);
        tree.insert(20);
        tree.insert(30);
        Assert.AreEqual(20, tree.root.Value);
    }
    [TestMethod]
    public void insertRecursivePruebas()
    {
        AVLTree tree = new AVLTree();
        tree.insert(10);
        tree.insert(20);
        tree.insert(30);
        Assert.AreEqual(20, tree.root.Value);
    }
    [TestMethod]
    public void deletePruebas()
    {
        AVLTree tree = new AVLTree();
        tree.insert(10);
        tree.insert(20);
        tree.insert(30);
        tree.delete(20);
        Assert.AreEqual(30, tree.root.Value);
    }
    [TestMethod]
    public void deleteRecursivePruebas()
    {
        AVLTree tree = new AVLTree();
        tree.insert(10);
        tree.insert(20);
        tree.insert(30);
        tree.delete(20);
        Assert.AreEqual(30, tree.root.Value);
    }
}
