namespace DesignPatterns.Creational.Builder
{
    public class ConcreteBuilderA : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilderA()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }

        public Product GetProduct()
        {
            Product result = _product;

            this.Reset();

            return result;
        }

        public void BuildPartA()
        {
            _product.Add("PartA");
        }

        public void BuildPartB()
        {
            _product.Add("PartB");
        }

        public void BuildPartC()
        {
            _product.Add("PartC");
        }
    }
}