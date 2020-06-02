namespace Visitor
{
    public interface IElement
    {
        void Accept (Visitor visitor);
    }
}