using System.Collections.Generic;
using DesignPatterns.Creational.Builder;
using Xunit;

namespace DesignPatterns.Tests.Creational.Builder
{
    public class BuilderTests
    {
        [Fact]
        public void Test1()
        {
            var director = new Director();
            var builder = new ConcreteBuilderA();
            director.Builder = builder;

            // product 1
            director.BuildProduct1();
            var parts1 = builder.GetProduct().ListParts();

            Assert.Equal("PartA,PartC", parts1);
        }

        [Fact]
        public void Test2()
        {
            var director = new Director();
            var builder = new ConcreteBuilderA();
            director.Builder = builder;

            // product 1
            director.BuildProduct2();
            var parts1 = builder.GetProduct().ListParts();

            Assert.Equal("PartB", parts1);
        }
    }
}