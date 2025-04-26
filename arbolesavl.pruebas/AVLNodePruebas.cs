using arbolesavl;
namespace arbolesavl.pruebas
{
    [TestClass]
    public sealed class AVLNodePruebas
    {
        [TestMethod]
        public void GetValuePruebas()
        {
            AVLNode node = new AVLNode(10);
            Assert.AreEqual(10, node.Value);
        }
        [TestMethod]
        public void SetValuePruebas()
        {
            AVLNode node = new AVLNode(10);
            node.Value = 20;
            Assert.AreEqual(20, node.Value);
        }
        [TestMethod]
        public void GetLeftPruebas()
        {
            AVLNode node = new AVLNode(10);
            node.Left = new AVLNode(5);
            Assert.AreEqual(5, node.Left.Value);
        }
        [TestMethod]
        public void SetLeftPruebas()
        {
            AVLNode node = new AVLNode(10);
            node.Left = new AVLNode(5);
            node.Left.Value = 15;
            Assert.AreEqual(15, node.Left.Value);
        }
        [TestMethod]
        public void GetRightPruebas()
        {
            AVLNode node = new AVLNode(10);
            node.Right = new AVLNode(15);
            Assert.AreEqual(15, node.Right.Value);
        }
        [TestMethod]
        public void SetRightPruebas()
        {
            AVLNode node = new AVLNode(10);
            node.Right = new AVLNode(15);
            node.Right.Value = 25;
            Assert.AreEqual(25, node.Right.Value);
        }
        [TestMethod]
        public void GetHeightPruebas()
        {
            AVLNode node = new AVLNode(10);
            AVLNode leftChild = new AVLNode(5);
            AVLNode rightChild = new AVLNode(15);
            node.Left = leftChild;
            node.Right = rightChild;
            node.Height = Math.Max(leftChild.Height, rightChild.Height) + 1;
            Assert.AreEqual(2, node.Height);
        }
        [TestMethod]
        public void SetHeightPruebas()
        {
            AVLNode node = new AVLNode(10);
            node.Height = 5;
            Assert.AreEqual(5, node.Height);
        }
        [TestMethod]
        public void ConstructorPruebas()
        {
            AVLNode node = new AVLNode(10);
            Assert.AreEqual(10, node.Value);
            Assert.IsNull(node.Left);
            Assert.IsNull(node.Right);
            Assert.AreEqual(1, node.Height);
        }
    }
}
