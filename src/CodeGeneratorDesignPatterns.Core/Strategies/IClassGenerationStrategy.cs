using CodeGeneratorDesignPatterns.Core.Models;

namespace CodeGeneratorDesignPatterns.Core.Strategies
{
    public interface IClassGenerationStrategy
    {
        bool CanHandle(ClassModel model);

        void Create(dynamic model);
    }
}
