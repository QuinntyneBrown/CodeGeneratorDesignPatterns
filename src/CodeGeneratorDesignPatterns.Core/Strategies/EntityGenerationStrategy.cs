using CodeGeneratorDesignPatterns.Core.Models;

namespace CodeGeneratorDesignPatterns.Core.Strategies
{
    public class EntityGenerationStrategy : IClassGenerationStrategy
    {
        public bool CanHandle(ClassModel model) => model is EntityClassModel;

        public void Create(dynamic model) => Create(model);

        private void Create(EntityClassModel model)
        {
            // Do something
        }
    }
}
