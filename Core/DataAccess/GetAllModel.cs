using Core.Entities.Concrete;

namespace Core.DataAccess;

public class GetAllModel<TEntity> : IGetAllModel<TEntity>
{
    public ICollection<TEntity> Items { get; set; }
    public int Count { get; set; }
    public GetAllModel()
    {
        Items = Array.Empty<TEntity>();
        Count = 0;
    }
    public GetAllModel(ICollection<TEntity> items, int count)
    {
        Items = items;
        Count= count;
    }
}
public interface IGetAllModel<TEntity>
{
    ICollection<TEntity> Items { get; set; }
    int Count { get; set; }
}
