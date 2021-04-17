namespace DesignPatterns.Creational.Builder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set => _builder = value;
        }

        public void BuildProduct1()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartC();
        }

        public void BuildProduct2()
        {
            this._builder.BuildPartB();
        }
    }
}