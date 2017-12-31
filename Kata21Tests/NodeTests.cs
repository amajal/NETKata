using System;
using NUnit.Framework;
using NFluent;
using Kata21;

namespace Kata21Tests
{
    [TestFixture]
    public class UnitTest1
    {
        public void OnNodeCreationValueMatchesAssigned()
        {
            var nodeValue = "newNode";
            var node = new Node(nodeValue);

            Check.That(node).IsNotNull();
            Check.That(node.GetValue()).Equals(nodeValue);
        }
    }
}
