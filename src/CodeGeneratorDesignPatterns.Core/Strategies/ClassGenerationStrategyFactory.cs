using CodeGeneratorDesignPatterns.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeGeneratorDesignPatterns.Core.Strategies
{
    public interface IClassGenerationStrategyFactory
    {
        void CreateFor(ClassModel model);
    }

    public class ClassGenerationStrategyFactory: IClassGenerationStrategyFactory
    {
        private readonly IList<IClassGenerationStrategy> _strategies;

        public ClassGenerationStrategyFactory()
        {
            _strategies = new List<IClassGenerationStrategy>()
            {
                new ModelGenerationStrategy(),
                new DtoGenerationStrategy()
            };
        }

        public void CreateFor(ClassModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var strategy = _strategies.Where(x => x.CanHandle(model)).FirstOrDefault();

            if (strategy == null)
            {
                throw new InvalidOperationException("Cannot find a strategy for generation for the type " + model.ClassName);
            }

            strategy.Create(model);
        }
    }
}
