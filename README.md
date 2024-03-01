# CleanMovie


1. create a class library for CleanMovie.Domain
* What is a domain?
-> things you do with/without having a software
for a movie rental system, you are going to walk into the store and ask-" What are the movies you have?"
They might show you a book that has a list of movies kept in the store. 
Once you choose, they are going to take some details of you and give you the movie.
Here the domains are-> movie, customer details etc.
2. Add a domain class named "Movie" into the project
3. Create another class library named "CleanMovie.Applicaton"
* What's for Application -> for business logics
4. add project reference of domain into application
5. add a new interface named "IMovieRepository" and add the methods you are going to use to fetch from the repository
6. add a new interface named "IMovieService" and this is going to be the use case for the domain movie
7. add a new class named "MovieService" and implement the methods from "IMovieService"  and use IMovieRepository as an dependency injection
8. add a new project named "CleanMovie.Infrastructure" 
* Infrastructure is going to do the actual operations like
                                            - talking to database
                                            - talking to another api
                                            - talking to system clock
                                            - talking to file system
                                            - anything external to your domain

Domain does not depend on anything
Application depends on Domain, domain only talks to application
Infrastructure depends on Application
9. add Application project referenct to CleanMovie.Infrastructure project
10. Add new class named "MovieRepository" and implement IMovieRepository from application project
11. 











##### Reference: https://www.youtube.com/watch?v=OzZJqVQrVU0&list=PLBapd_vePld_986VHC2UbcPY4Q2j9-lpT&ab_channel=CodeUnparalleled