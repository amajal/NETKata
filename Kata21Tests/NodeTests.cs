using NUnit.Framework;
using NFluent;
using Kata21;

namespace Kata21Tests
{
    [TestFixture]
    public class NodeTests
    {
        [Test]
        public void OnNodeCreationValueMatchesAssigned()
        {
            var nodeValue = "newNode";
            var node = new Node(nodeValue);

            Check.That(node).IsNotNull();
            Check.That(node.GetValue()).Equals(nodeValue);
        }

        [Test]
        public void OnNodeAssignToPreviousWorks()
        {
            var node = new Node("Current Node");
            var prevNode = new Node("Previous Node");
            node.Previous = prevNode;
        }

        [Test]
        public void OnNodeAssignToNextWorks()
        {
            var node = new Node("Current Node");
            var nextNode = new Node("Next Node");
            node.Next = nextNode;
        }

    }
}
