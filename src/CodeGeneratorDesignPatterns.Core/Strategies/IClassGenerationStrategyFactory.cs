using CodeGeneratorDesignPatterns.Core.Models;

namespace CodeGeneratorDesignPatterns.Core.Strategies
{
    public interface IClassGenerationStrategyFactory
    {
        void CreateFor(ClassModel model);
    }
}
