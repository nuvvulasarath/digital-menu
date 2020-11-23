using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DigitalMenuApplicaton.Models
{
    public class Dish
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string AvailableDuring { get; set; }
        public string AvailableOn { get; set; }
        public bool IsSoldOut { get; set; }
        public int ReadyToServeInMins { get; set; }
    }
}