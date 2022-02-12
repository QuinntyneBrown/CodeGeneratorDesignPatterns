using CodeGeneratorDesignPatterns.Core.Models;

namespace CodeGeneratorDesignPatterns.Core.Strategies
{
    public class ModelGenerationStrategy : IClassGenerationStrategy
    {
        public bool CanHandle(ClassModel model)
        {
            return true;
        }

        public void Create(ClassModel model)
        {
            
        }
    }
}
