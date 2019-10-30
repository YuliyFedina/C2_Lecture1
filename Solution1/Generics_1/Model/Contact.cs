namespace Generics_1.Model
{
    internal class Contact : IEntity
    {
        public long Id { get; set; }
        public virtual string Value { get; set; }

        public override string ToString()
        {
            return string.Format($"Id={Id}, Value={Value}");
        }
    }
}
