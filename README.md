# CleanMovie


1. Create a class library for CleanMovie.Domain and Name the solution CleanMovie
* What is a domain?
    * Things you do with/without having a software
    for a movie rental system, you are going to walk into the store and ask-" What are the movies you have?"
    They might show you a book that has a list of movies kept in the store. 
    Once you choose, they are going to take some details of you and give you the movie.
    Here the domains are-> movie, customer details etc.
2. Add a domain class named "Movie" into the project
3. Create another class library named "CleanMovie.Applicaton"
    * What's for Application -> for business logics
4. Add project reference of domain into application
5. Add a new interface named "IMovieRepository" and add the methods you are going to use to fetch from the repository
6. Add a new interface named "IMovieService" and this is going to be the use case for the domain movie
7. Add a new class named "MovieService" and implement the methods from "IMovieService"  and use IMovieRepository as an dependency injection
8. Add a new project named "CleanMovie.Infrastructure" 
    * Infrastructure is going to do the actual operations like
        * talking to database
        * talking to another api
        * talking to system clock
        * talking to file system
        * anything external to your domain

    * Domain does not depend on anything
    * Application depends on Domain, domain only talks to application
    * Infrastructure depends on Application
    * Presentation depends on Application layer
9. Add Application project referenct to CleanMovie.Infrastructure project
10. Add new class named "MovieRepository" and implement IMovieRepository from application project
11. Add presentation layer which is webAPI project in the same directory
12. Add Application project reference to the web api project
13. Add controller named "MoviesController.cs" and add api method for getting movies using service from application
14. Add dependency injection in the program for IMovieServie
15. Add dependency injection in the program for IMovieRepository(for that we have to add Infrastructure project reference to the presentation layer as IMovieRepository is not defined which one to implement)
* Reference: https://www.youtube.com/watch?v=OzZJqVQrVU0&list=PLBapd_vePld_986VHC2UbcPY4Q2j9-lpT&ab_channel=CodeUnparalleled


---------------------------------------


1. Add nuget package "EntityFrameworkCore", "EntityFrameworkCore.Design", "EntityFrameworkCore.Tools" "EntityFrameworkCore.SqlServer" into infrastructure
2. Add CreateMovie method into IMovieRepository
3. Implement the method CreateMovie with noImplementation in MovieRepository
4. Add CreateMovie method into IMovieService
5. Implement the method CreateMovie with noImplementation in MovieService
6. Add MovieDbContext class into Infrastructure and inherit DbContext and add Entity Movie
7. Add constructor and inject MovieDbContext into MovieRepository class
8. Rewrite the CreateMovie and GetAllMovies method with MovieDbContext and remove the static movie list
9. Rewrite the CreateMovie method with the help of IMovieRepository object in MovieService class
10. Add post api method in MoviesController.cs
11. Add ConnectionStrings in appsettings.json in the CleanMovie.API
12. Register Configurationmanager and add database service in the program file in the CleanMovie.API
13. Add nuget package "EntityFrameworkCore.Tools" into API project
14. Register the DbContext into services into program file
15. Open Package manager Console And write command for adding migration
- add-migration InitialMigration  // for vs
- dotnet ef migrations add InitialMigration  // for vscode
16. then update the database using this command
- dotnet ef database update
17. 





* Reference: https://www.youtube.com/watch?v=HCuoBwXS95o&list=PLBapd_vePld_986VHC2UbcPY4Q2j9-lpT&index=3&ab_channel=CodeUnparalleled

