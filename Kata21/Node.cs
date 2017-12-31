namespace Kata21
{
    public class Node : INode
    {
        string _nodeValue;

        public Node(string nodeValue)
        {
            _nodeValue = nodeValue;
        }

        public string GetValue()
        {
            return _nodeValue;
        }

        public INode Next { get; set;}

        public INode Previous { get; set; }
    }
}