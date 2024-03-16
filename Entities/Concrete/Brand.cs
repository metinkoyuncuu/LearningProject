
using Core.Entities.Concrete;

namespace Entities.Concrete;

public class Brand:Entity<int>
{
    public string Name { get; set; }
    public Brand()
    {
        Name= string.Empty;
    }
    public Brand(string name)
    {
        Name = name;
    }

}
