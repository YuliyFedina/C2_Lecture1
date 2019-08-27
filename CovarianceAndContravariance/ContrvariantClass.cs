using System.Collections.Generic;

namespace CovarianceAndContravariance
{
    internal class ContrvariantClass<T> : IContravariantInterface<T>
    {
        private readonly List<T> _list = new List<T>();

        public T this[int index]
        {
            set { _list[index] = value; }
        }

        public void Add(T item)
        {
            _list.Add(item);
        }
    }
}
