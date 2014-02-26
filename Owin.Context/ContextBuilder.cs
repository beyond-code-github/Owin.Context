namespace Owin.Context
{
    using System;
    using System.Collections.Generic;

    public class ContextBuilder<T> : IContextBuilder<T>
    {
        private readonly IAppBuilder baseAppBuilder;

        public ContextBuilder(IAppBuilder baseAppBuilder)
        {
            this.baseAppBuilder = baseAppBuilder;
        }

        public IAppBuilder Use(object middleware, params object[] args)
        {
            return this.baseAppBuilder.Use(middleware, args);
        }

        public object Build(Type returnType)
        {
            return this.baseAppBuilder.Build(returnType);
        }

        public IAppBuilder New()
        {
            return this.baseAppBuilder.New();
        }

        public IDictionary<string, object> Properties
        {
            get
            {
                return baseAppBuilder.Properties;
            }
        }

        public T Context { get; set; }
    }

    public interface IContextBuilder<T> : IAppBuilder
    {
        T Context { get; set; }
    }
}
