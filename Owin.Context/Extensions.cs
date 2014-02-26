namespace Owin.Context
{
    using System;

    public static class Extensions
    {
        public static IContextBuilder<T> Context<T>(this IAppBuilder app, Func<IContextBuilder<T>, IContextBuilder<T>> setup) where T : new()
        {
            return setup(new ContextBuilder<T>(app));
        }

        public static IContextBuilder<T> Use<T>(this IContextBuilder<T> builder, Func<IAppBuilder, T, IAppBuilder> setup)
        {
            return setup(builder, builder.Context) as IContextBuilder<T>;
        }
    }
}