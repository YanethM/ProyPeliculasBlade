using System;
using ProyBaseMuestra.Shared.Entity;
using System.Collections.Generic;

namespace ProyBaseMuestra.Client.Services
{
    public class ServiceMovie:IServiceMovie
    {
        public List<Movie> GetMovies(){
            return new List<Movie>{
                new Movie(){Name="Movie 2",Poster="/Images/Movies/Movie2.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Name="Movie 3",Poster="/Images/Movies/Movie3.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Name="Movie 4",Poster="/Images/Movies/Movie4.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Name="Movie 5",Poster="/Images/Movies/Movie5.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Name="Movie 6",Poster="/Images/Movies/Movie6.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Name="Movie 7",Poster="/Images/Movies/Movie7.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Name="Movie 8",Poster="/Images/Movies/Movie8.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Name="Movie 9",Poster="/Images/Movies/Movie9.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Name="Movie 10",Poster="/Images/Movies/Movie10.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){Name="Movie 11",Poster="/Images/Movies/Movie11.jpg",Sinopsis="Sinopsis movie",Score=100,Premier=new DateTime(2021,09,24)}
            };
        }
    }
}