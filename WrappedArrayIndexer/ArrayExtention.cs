using System;

namespace WrappedArrayIndexer
{
    public static class ArrayExtention
    {
        public static T Wrap<T>(this Array array, params int[] indices)
        {
            if (indices.Length != array.Rank) throw new ArgumentOutOfRangeException(indices.ToString(), $"{indices.Length} indices provided, but Array rank is {array.Rank}. These values should match.");

            int[] wrappedIndices = new int[indices.Length];
            for (int i = 0; i < indices.Length; i++)
            {
                int index = indices[i];
                int bound = array.GetLength(i);
                Console.WriteLine(bound);
                wrappedIndices[i] = ((index % bound) + bound) % bound;
            }   
            return (T)array.GetValue(wrappedIndices);
        }
    }
}
