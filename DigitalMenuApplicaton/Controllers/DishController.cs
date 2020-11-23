using DigitalMenuApplicaton.Models;
using DigitalMenuApplicaton.Utilities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DigitalMenuApplicaton.Controllers
{
    public class DishController : ApiController
    {
        [Route("GetDigitalMenu")]
        [HttpGet]
        public HttpResponseMessage GetDigitalMenu()
        {
            HttpResponseMessage response = null;
            try
            {
                var collection = Helper.ConnectToDBAndRetrieveCollection().Find(new BsonDocument()).ToList();
                response = Request.CreateResponse(HttpStatusCode.OK, collection);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [Route("ServeDishById")]
        [HttpGet]
        public HttpResponseMessage ServeDish(string id)
        {
            HttpResponseMessage response = null;
            try
            {
                var collection = Helper.ConnectToDBAndRetrieveCollection();
                Dish selectedDish = collection.Find(Builders<Dish>.Filter.Where(d => d.Id == id)).FirstOrDefault();
                response = Request.CreateResponse(HttpStatusCode.OK, selectedDish);
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            return response;
        }

        [Route("AddOrUpdateDish")]
        [HttpPost]
        public HttpResponseMessage AddOrUpdateDish(Dish item)
        {
            HttpResponseMessage response = null;
            try
            {
                var collection = Helper.ConnectToDBAndRetrieveCollection();
                if (string.IsNullOrEmpty(item.Id))
                {
                    collection.InsertOne(item);
                    response = Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                {
                    var update = collection.FindOneAndUpdate(Builders<Dish>.Filter.Eq("Id", item.Id), Builders<Dish>.Update.Set("Name", item.Name)
                                                             .Set("Description", item.Description).Set("Price", item.Price)
                                                             .Set("Category", item.Category).Set("AvailableDuring", item.AvailableDuring)
                                                             .Set("AvailableOn", item.AvailableOn).Set("IsSoldOut", item.IsSoldOut)
                                                             .Set("ReadyToServeInMins", item.ReadyToServeInMins));
                    response = Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

            return response;
        }

    }
}
