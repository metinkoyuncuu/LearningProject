

using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract; 

public interface IBrandDal:IAsyncRepository<Brand,int>,IRepository<Brand,int>
{
}
