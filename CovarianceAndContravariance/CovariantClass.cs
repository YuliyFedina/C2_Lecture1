using System.Collections.Generic;

namespace CovarianceAndContravariance
{
    internal class CovariantClass<T> : ICovariantInterface<T>
    {
        private readonly List<T> _list = new List<T>();

        public T this[int index]
        {
            get { return _list[index]; }
        }
    }
}
