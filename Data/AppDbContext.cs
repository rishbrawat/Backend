using Microsoft.EntityFrameworkCore;

public class AppDbContext: DbContext
{

    // dbcontextoptions<appdbcontext> contains configurations information that ef core needs to construct the context;
    public AppDbContext(DbContextOptions<AppDbContext> options) :  base(options) // then  options are passed
    {
        
    }

    // a DbSet  represents collection of all entities in the context, that can be queried from the database, of a given type, DbSet objects are created from a dbcontext using dbcontext.set method
    public DbSet<Student> Students {get; set;} // the context works with Student entities through a set called students, we can think of it as ef core entry point for querying and working with student, its not sql table!
    // here Student is a entity type, Students is a DbSet<Student> instance, it provides a context with an entity that we can query or modify


    
}