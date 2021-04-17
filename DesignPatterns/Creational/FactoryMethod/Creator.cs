namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOtherOperation()
        {
            var product = FactoryMethod();

            return $"This is some other operation to make this product: {product.Operation()}";
        }
    }
}