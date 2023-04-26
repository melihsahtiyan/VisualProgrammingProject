namespace Core.Persistence.EntityFramework;

public interface IQuery<T>
{
    IQueryable<T> Query();
}
