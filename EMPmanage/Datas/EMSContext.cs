using Microsoft.EntityFrameworkCore;
namespace EMPmanage.Datas
{
public class EMSContext : DbContext
{
    public  EMSContext(){
        
    }
    public EMSContext(DbContextOptions<EMSContext> options) : base(options)
    {

    }
    public DbSet<People> Staffs { get; set; }
}
}
