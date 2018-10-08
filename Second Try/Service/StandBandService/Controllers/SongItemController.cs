using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using StandBandService.DataObjects;
using StandBandService.Models;

namespace StandBandService.Controllers
{
    public class SongItemController : TableController<SongItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            StandBandContext context = new StandBandContext();
            DomainManager = new EntityDomainManager<SongItem>(context, Request);
        }

        // GET tables/Item
        public IQueryable<SongItem> GetAllSongItem()
        {
            return Query();
        }

        // GET tables/Item/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<SongItem> GetItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Item/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<SongItem> PatchItem(string id, Delta<SongItem> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Item
        public async Task<IHttpActionResult> PostItem(SongItem item)
        {
            SongItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Item/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}