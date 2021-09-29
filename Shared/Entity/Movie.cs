using System.Reflection.Metadata.Ecma335;
using System;
namespace ProyBaseMuestra.Shared.Entity
{
    public class Movie
    {
        /* Incluimos las siguientes validaciones al campo nombre pelicula:
        1. Que el campo no este vacío o contenga únicamente un espacio en blanco (IsNullOrWhiteSpace)
        2. Validamos la longitud de la cadena de texto, que NO supere los 60 caracteres */
        public string MovieName {get;set;}
        public string MovieImage {get;set;}
        public string Sinapsis {get;set;}
        public int Score {get;set;}
        public DateTime Premier {get;set;}
    }
}