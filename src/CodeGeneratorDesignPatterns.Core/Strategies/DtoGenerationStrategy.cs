using CodeGeneratorDesignPatterns.Core.Models;

namespace CodeGeneratorDesignPatterns.Core.Strategies
{
    public class DtoGenerationStrategy : IClassGenerationStrategy
    {
        public bool CanHandle(ClassModel model)
        {
            return model is DtoClassModel;
        }

        public void Create(dynamic model) => Create(model);

        private void Create(DtoClassModel model)
        {

        }
    }
}
