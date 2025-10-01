# ASP.NETCoreRazorPagesMovieApp

# ASP.NET Core Razor Pages Movie App

This is a simple **ASP.NET Core Razor Pages application** that demonstrates the fundamentals of Razor Pages development: routing, dependency injection, tag helpers, and layout views.  

##  Features

- **Movie Overview Page** – Displays a list of movies (title, year, rating).  
- **Movie Details Page** – Shows complete information for a selected movie.  
- **Navigation** – Click from overview to movie details using route templates.  
- **Seed Data** – Loads at least 10 movies at startup from a custom service.  
- **Dependency Injection** – A `MovieService` is injected into Razor Page models.  
- **Movie Form** – Add new movies using ASP.NET Core Tag Helpers (data is temporary, cleared on restart).  
- **Extras** – Uses layout pages, partial views, and clean Razor syntax.  

## Technologies

- ASP.NET Core 8.0 (Razor Pages)  
- C#  
- Dependency Injection  
- Tag Helpers  
- Bootstrap (optional for styling)  

## Project Structure
RazorPagesMovieApp/
│-- Pages/
│ │-- Index.cshtml # Overview page
│ │-- MovieDetails.cshtml # Movie details page
│ │-- Shared/ # Layout & partial views
│
│-- Services/
│ │-- MovieService.cs # Handles movie data & seed logic
│
│-- Models/
│ │-- Movie.cs # Movie model
│
│-- wwwroot/ # Static files (css, js, images)
│
│-- Program.cs # Configures services & middleware

