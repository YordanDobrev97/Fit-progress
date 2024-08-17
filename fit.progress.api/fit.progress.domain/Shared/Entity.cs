namespace fit.progress.domain.Shared
{
    internal abstract class Entity<T>
        where T : struct
    {
        public T Id { get; private set; } = default(T);
    }
}
