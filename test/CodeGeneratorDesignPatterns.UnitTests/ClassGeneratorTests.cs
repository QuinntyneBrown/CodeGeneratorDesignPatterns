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
            ClassGenerator.Create(new EntityClassModel() {  IdPropertyName = "Id" }, new ClassGenerationStrategyFactory());
        }
    }
}
