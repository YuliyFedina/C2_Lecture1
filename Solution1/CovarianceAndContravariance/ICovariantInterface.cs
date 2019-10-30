namespace CovarianceAndContravariance
{
    internal interface ICovariantInterface<out T>
    {
        T this[int index] { get; }
    }
}
