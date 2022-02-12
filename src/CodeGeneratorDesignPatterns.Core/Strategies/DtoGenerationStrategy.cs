using CodeGeneratorDesignPatterns.Core.Models;

namespace CodeGeneratorDesignPatterns.Core.Strategies
{
    public class DtoGenerationStrategy : IClassGenerationStrategy
    {
        public bool CanHandle(ClassModel model)
        {
            return model.ClassName.EndsWith("Dto");
        }

        public void Create(ClassModel model)
        {
            
        }
    }
}
