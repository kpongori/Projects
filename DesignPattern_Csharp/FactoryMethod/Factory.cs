namespace FactoryMethod
{
    public abstract class Factory
    {
        // Product生成処理の流れは上書きされないように
        public Product Create (string owner)
        {
            Product p = CreateProduct (owner);
            RegisterProduct (p);
            return p;
        }

        protected abstract Product CreateProduct (string owner);
        protected abstract void RegisterProduct (Product product);

    }
}