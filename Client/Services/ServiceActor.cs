using ProyBaseMuestra.Shared.Entity;
using System.Collections.Generic;
using System;
namespace ProyBaseMuestra.Client.Services
{
    public class ServiceActor: IServiceActor
    {
        public List <Actor> GetActors(){
            return new List<Actor>{
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaExtranjera,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaExtranjera,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"},
                new Actor(){ActorName = "Actor 1", DocumentType=DocumentType.CedulaCiudadana,Document="105381142",Gender = Gender.Masculino,BirthDate= new DateTime(1990,12,03),KnowCredits=12, Nominations = 3,Biography="Biografía...", Photo="/Images/Actors/actor1.jpg"}
            };
        }
    }
}