namespace NewsPortal.Domain.Common.Interface
{
    public interface IEntity<TId>
    {
        TId Id { get; }
    }
}
