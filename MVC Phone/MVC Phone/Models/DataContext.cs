namespace MVC_Phone.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC_Phone.Models.Phone> Phones { get; set; }
    }
}