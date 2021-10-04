using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace ProyBaseMuestra.Shared.Entity
{
    public class Movie
    {
        public int Id {get;set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Name {get;set;}
        public bool EnCartelera {get;set;}
        public string Poster {get;set;}
        public string Trailer {get;set;}
        public string Sinopsis {get;set;}
        public int Score {get;set;}
        [Required(ErrorMessage ="La {0} es requerida")]
        public DateTime? Premier {get;set;}
        public List<CategoryMovie> CategoriesMovie{get;set;} = new List<CategoryMovie>();
        public string ShortName {
            get{
                if (string.IsNullOrWhiteSpace(Name))
                {
                    return null;
                }
                if (Name.Length > 60)
                {
                    return Name.Substring(0, 60) + "...";
                }else{
                    return Name;
                }
            }
        }
    }
}