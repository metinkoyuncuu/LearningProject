
using Core.DataAccess;
using Entities.Concrete;

namespace Business.Abstract;

public interface IBrandService
{
    GetAllModel<Brand> GetAll();
    Task<GetAllModel<Brand>> GetAllAsync();
    Brand Add(Brand brand);
    Task<Brand> AddAsync(Brand brand);
    ICollection<Brand> AddRange(ICollection<Brand> brands);
    Task<ICollection<Brand>> AddRangeAsync(ICollection<Brand> brands);
}
