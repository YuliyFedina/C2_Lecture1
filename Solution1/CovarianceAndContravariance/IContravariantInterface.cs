namespace CovarianceAndContravariance
{
    internal interface IContravariantInterface<in T>
    {
        T this[int index] { set; }
        void Add(T item);
    }
}
