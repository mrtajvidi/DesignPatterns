namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IAbstractFactory
    {
        public IAbstractProductA CreateProductA();

        public IAbstractProductB CreateProductB();
    }
}