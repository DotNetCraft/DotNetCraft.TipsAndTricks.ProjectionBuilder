using System;

namespace DotNetCraft.TipsAndTricks.ProjectionBuilder.Implementation
{
    public interface IProjectionBuilder<TEntity> where TEntity : class
    {
        //ProjectionDefinition<TEntity> Build(Abstractions.Options.ProjectionDefinition<TEntity> projectionDefinition);
    }
}
