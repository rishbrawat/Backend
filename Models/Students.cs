using Microsoft.AspNetCore.SignalR;


/*
    first we need to tell efcore that we are using sql server, then we can do things

    connection string: which database i should connect to and how
    Server, Database, Trusted_Connection(means windows authentication is being used), TrustServerCertificate(to deal with certificate issues)



    dbcontext class is a core component of the entity core framework that acts as a bridge between your app's (entities) classes and the underlying database, it manages database connections, performs CRUD operations, manages transactions and track changes to entities.

    dbcontext performs several tasks in efcore
    ________________________________________________
    entity tracking- it tracks the state of entities (added, modified, deleted, unchanged) and keeps record of changes that need to be persisted in the database.

    database interactions- executes queries, commands, and transaction against the database using the configured provider

    query execution- translates LINQ into SQL and executes them against the databse
    change detection
    transaction management
    lazy loading
    caching
    concurrency control
    managing relationships  - manages relationship between entities, including the loading and updating related data.

*/


// this is an entity class that we will map to database table


// an entity is a c# object that ef core treats as a part of the application's data model and maps to a database structure. in simple terms, an entity is a class that becomes part of ef core's model.

// model: ef core builds internal representation of those classes and their relationships, that internal representation is called the ef core model.



// entity: represents persistence/domain data

// dto : represnts the data we chose to send/receive throguh an API

// projection ---- for later

// one logical unit of db work -> one dbcontext instance

// migration: is a record of how your databse scheme changes from one model state to another.
// add-migration: looks at current ef core model and compares it with previous migration snapshot
// update-database: this takes the migrations that exist and applies them to the database

public class Student
{
    // this is a convention based configuration
    public int Id { get; set; } // ef core recognizes Id as primary key by convention, an entity needs a key to let ef core distinguish between entities.
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
}
