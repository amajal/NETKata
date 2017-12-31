using System;
namespace Kata21
{
    public interface ILinkedList
    {
        void Append(Node node);
        Node Contains(string value);
        void Remove(Node node);
        Node[] ToArray();
    }
}
