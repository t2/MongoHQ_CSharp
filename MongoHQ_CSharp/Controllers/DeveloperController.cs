using System.Linq;
using System.Web.Mvc;
using MongoHQ_CSharp.Models;
using MongoHQ_CSharp.Models.DTO;

namespace MongoHQ_CSharp.Controllers
{
    public class DeveloperController : BaseController
    {
        public ActionResult Developers()
        {
            return View(get_developer_view_model());
        }

        DeveloperModel get_developer_view_model()
        {
            /*
             * Document Configuration
             *    Name: developers
             *    Keys: _id, name, company and languages
             *    
             * Your documents will most likely be different. 
             * This is for demonstration purposes only.
            */
            
            var developers = database.GetCollection("developers").FindAll().AsEnumerable();
            return new DeveloperModel
            {
                developers = developers
                    .Select(d => new Developer
                    {
                        id = d["_id"].AsObjectId,
                        name = d["name"].AsString,
                        company = d["company"].AsString,
                        languages = d["languages"].AsBsonArray
                    }).ToList()
            };
        }
    }
}
