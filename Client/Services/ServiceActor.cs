using ProyBaseMuestra.Shared.Entity;
using System.Collections.Generic;
using System;
namespace ProyBaseMuestra.Client.Services
{
    public class ServiceActor: IServiceActor
    {
        public List <Actor> GetActors(){
            return new List<Actor>{
                new Actor(){Id =1,ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){Id =2,ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){Id =3,ActorName = "Actor 1", DocumentType=DocumentType.CedulaExtranjera,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){Id =4,ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){Id =5,ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){Id =6,ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){Id =7,ActorName = "Actor 1", DocumentType=DocumentType.CedulaExtranjera,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){Id =8,ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){Id =9,ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){Id =10,ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"}
            };
        }
    }
}