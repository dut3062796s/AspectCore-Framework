﻿using System;
using AspectCore.Abstractions;

namespace AspectCore.Core
{
    [NonAspect]
    public sealed class AspectActivatorFactory : IAspectActivatorFactory
    {
        private readonly IAspectContextFactory _aspectContextFactory;
        private readonly IAspectBuilderFactory _aspectBuilderFactory;

        public AspectActivatorFactory(IAspectContextFactory aspectContextFactory, IAspectBuilderFactory aspectBuilderFactory)
        {
            _aspectContextFactory = aspectContextFactory ?? throw new ArgumentNullException(nameof(aspectContextFactory));
            _aspectBuilderFactory = aspectBuilderFactory ?? throw new ArgumentNullException(nameof(aspectBuilderFactory));
        }

        public IAspectActivator Create()
        {
            return new AspectActivator(_aspectContextFactory, _aspectBuilderFactory);
        }
    }
}
