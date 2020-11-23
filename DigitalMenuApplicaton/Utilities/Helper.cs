using DigitalMenuApplicaton.Models;
using MongoDB.Driver;
using System.Configuration;

namespace DigitalMenuApplicaton.Utilities
{
    public class Helper
    {
        public static IMongoCollection<Dish> ConnectToDBAndRetrieveCollection()
        {
            string constr = ConfigurationManager.AppSettings["connectionString"];
            var Client = new MongoClient(constr);
            var DB = Client.GetDatabase("Sample");
            IMongoCollection<Dish> collection = DB.GetCollection<Dish>("Digital Menu");

            return collection;
        }
    }
}