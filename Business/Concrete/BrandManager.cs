

using Business.Abstract;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class BrandManager : IBrandService
{
    readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public Brand Add(Brand brand)
    {
        var result = _brandDal.Add(brand);
        return result;
    }

    public async Task<Brand> AddAsync(Brand brand)
    {
        var result = await _brandDal.AddAsync(brand);
        return result;
    }

    public ICollection<Brand> AddRange(ICollection<Brand> brands)
    {
        var result =_brandDal.AddRange(brands);
        return result;
    }

    public async Task<ICollection<Brand>> AddRangeAsync(ICollection<Brand> brands)
    {
        var result =await _brandDal.AddRangeAsync(brands);
        return result;
    }

    public async Task<GetAllModel<Brand>> GetAllAsync()
    {
        var result = await _brandDal.GetAllAsync(predicate:b=>b.Name.StartsWith("a"));
        return result;
    }

    public GetAllModel<Brand> GetAll()
    {
        GetAllModel<Brand> result = _brandDal.GetAll(predicate: b => b.Name.StartsWith("a"));
        return result;
    }

}
