using System.Configuration;
using System.Web.Mvc;
using MongoDB.Driver;

namespace MongoHQ_CSharp.Controllers
{
    public class BaseController : Controller
    {
        public MongoDatabase database
        {
            get { return MongoDatabase.Create(get_mongo_hq_connection_string()); }
        }

        private static string get_mongo_hq_connection_string()
        {
            return ConfigurationManager.AppSettings.Get("MongoHQ_URL") ?? ConfigurationManager.AppSettings.Get("MongoHQ_URI");
        }
    }
}
