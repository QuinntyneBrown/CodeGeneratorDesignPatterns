using CodeGeneratorDesignPatterns.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeGeneratorDesignPatterns.Core.Strategies
{

    public class ClassGenerationStrategyFactory: IClassGenerationStrategyFactory
    {
        private readonly IList<IClassGenerationStrategy> _strategies;

        public ClassGenerationStrategyFactory()
        {
            _strategies = new List<IClassGenerationStrategy>()
            {
                new EntityGenerationStrategy(),
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
                throw new InvalidOperationException("Cannot find a strategy for generation for the type " + model.GetType());
            }

            strategy.Create(model);
        }
    }
}
