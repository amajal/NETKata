using System;
namespace Kata21
{
    public interface IKataList
    {
        void Append(Node node);
        Node Contains(string value);
        void Remove(Node node);
        Node[] ToArray();
    }
}
