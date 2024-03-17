using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework;

public class EfBrandDal:EfEntityRepositoryBase<Brand,int,LearningContext>,IBrandDal
{
    public EfBrandDal(LearningContext learningContext):base(learningContext)
    {
        
    }
}
