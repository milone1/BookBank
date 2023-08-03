using System;
using MongoDB.Driver;
using Nueva_app.Models;

namespace Nueva_app.Services
{
	public class BeerService
	{
		private IMongoCollection<User> _users;

		public BeerService(IBarSettings settings)
		{
			var cliente = new MongoClient(settings.Server);
			var database = cliente.GetDatabase(settings.Database);
            _users = database.GetCollection<User>(settings.Collection);
		}

		public List<User> Get()
		{
			return _users.Find(d => true).ToList();
		}

		public User Create(User user)
		{
			_users.InsertOne(user);
			return user;
		}

		public void Update(string id, User user)
		{
			_users.ReplaceOne(user => user.Id == id, user);
		}

		public void Delete(string id)
		{
			_users.DeleteOne(d => d.Id == id);
		}


	}
}

