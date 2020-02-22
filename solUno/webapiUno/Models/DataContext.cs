
namespace webapiUno.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<webapiUno.Models.Person> People { get; set; }
    }
}