using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            if (context.Movie.Any())
            {
                return;
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    Director = "Frank Darabont",
                    Rating = 9
                },
                new Movie
                {
                    Title = "The Godfather",
                    Director = "Francis Ford Coppola",
                    Rating = 10
                },
                new Movie
                {
                    Title = "Inception",
                    Director = "Christopher Nolan",
                    Rating = 9
                },
                new Movie
                {
                    Title = "Pulp Fiction",
                    Director = "Quentin Tarantino",
                    Rating = 8
                }
            );

            context.SaveChanges();
        }
    }
}