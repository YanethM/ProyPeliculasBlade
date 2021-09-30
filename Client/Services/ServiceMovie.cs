using System;
using ProyBaseMuestra.Shared.Entity;
using System.Collections.Generic;

namespace ProyBaseMuestra.Client.Services
{
    public class ServiceMovie:IServiceMovie
    {
        public List<Movie> GetMovies(){
            return new List<Movie>{
                new Movie(){MovieName="Movie 2",MovieImage="/Images/Movies/Movie2.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 3",MovieImage="/Images/Movies/Movie3.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 4",MovieImage="/Images/Movies/Movie4.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 5",MovieImage="/Images/Movies/Movie5.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 6",MovieImage="/Images/Movies/Movie6.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 7",MovieImage="/Images/Movies/Movie7.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 8",MovieImage="/Images/Movies/Movie8.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 9",MovieImage="/Images/Movies/Movie9.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 10",MovieImage="/Images/Movies/Movie10.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)},
                new Movie(){MovieName="Movie 11",MovieImage="/Images/Movies/Movie11.jpg",Sinapsis="Sinapsis movie",Score=100,Premier=new DateTime(2021,09,24)}
            };
        }
    }
}