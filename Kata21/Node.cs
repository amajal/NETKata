namespace Kata21
{
    public class Node : INode
    {
        private string nodeValue;

        public Node(string nodeValue)
        {
            this.nodeValue = nodeValue;
        }

        public string GetValue()
        {
            throw new System.NotImplementedException();
        }
    }
}