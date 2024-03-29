﻿using System.Linq.Expressions;

namespace Skinet.Core.Specification
{
    public interface ISpecification<T> 
    {
        Expression<Func<T, bool>> Criteria { get; }

        List<Expression<Func<T, object>>> Includes { get; }
    }
}
