namespace Constraints
{
    internal static class ArrayExtensions
    {
        public static T[] Generate<T>(int n)
        {
            var array = new T[n];

            for (var i = 0; i < n; i++)
            {
                array[i] = default;
            }

            return array;
        }
    }
}
