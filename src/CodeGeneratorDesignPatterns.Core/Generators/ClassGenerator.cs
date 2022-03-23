using CodeGeneratorDesignPatterns.Core.Models;
using CodeGeneratorDesignPatterns.Core.Strategies;

namespace CodeGeneratorDesignPatterns.Core.Generators
{
    public class ClassGenerator
    {
        public static void Generate(ClassModel model, ClassGenerationStrategyFactory factory)
        {
            factory.CreateFor(model);
        }
    }
}
