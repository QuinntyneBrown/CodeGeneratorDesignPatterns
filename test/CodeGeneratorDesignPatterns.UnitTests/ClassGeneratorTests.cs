using CodeGeneratorDesignPatterns.Core;
using CodeGeneratorDesignPatterns.Core.Models;
using CodeGeneratorDesignPatterns.Core.Strategies;
using Xunit;

namespace CodeGeneratorDesignPatterns.UnitTests
{
    public class ClassGeneratorTests
    {
        [Fact]
        public void Should_Resolve()
        {
            var strategyFactory = new ClassGenerationStrategyFactory();

            var model = new EntityClassModel() { IdPropertyName = "Id" };

            ClassGenerator.Create(model, strategyFactory);
        }
    }
}
