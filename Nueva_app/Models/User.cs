using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Nueva_app.Models
{
	public class User
	{
        [BsonId]
		[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("name")]
		public string name { get; set; } = null!;

	}
}

