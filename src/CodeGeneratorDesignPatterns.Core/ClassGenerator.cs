using CodeGeneratorDesignPatterns.Core.Models;
using CodeGeneratorDesignPatterns.Core.Strategies;

namespace CodeGeneratorDesignPatterns.Core
{
    public static class ClassGenerator
    {
        public static void Create(ClassModel model, IClassGenerationStrategyFactory factory) {

            factory.CreateFor(model);
        }
    }
}
