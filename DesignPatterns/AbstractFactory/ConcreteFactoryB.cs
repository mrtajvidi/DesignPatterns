namespace DesignPatterns.AbstractFactory
{
    public class ConcreteFactoryB : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB();
        }
    }
}