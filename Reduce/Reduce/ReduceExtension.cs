namespace Reduce
{
    using System;
    using System.Collections.Generic;
    public static class ReduceExtension
    {
        public static T Reduce<T>(this IList<T> source, Func<T, T, T> reducer, T seed)
        {
            var accumulator = seed == null ? Activator.CreateInstance<T>() : seed;
            (source as List<T>).ForEach(currentValue => {
                accumulator = reducer(accumulator, currentValue);
            });
            return accumulator;
        }

        public static P ReduceTo<T, P>(this IList<T> source, Func<P, T, P> reducer, P seed)
        {
            var accumulator = seed == null ? Activator.CreateInstance<P>() : seed;
            (source as List<T>).ForEach(currentValue => {
                accumulator = reducer(accumulator, currentValue);
            });
            return accumulator;
        }

    }
}
