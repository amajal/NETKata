using Kata21;
using NUnit.Framework;

namespace Kata21Tests
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void OnAppendNodeGetsAddedToList()
        {
            var list = new SinglyLinkedList();
            var node = new Node("Node1");
            list.Append(node);

        }
    }
}
