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
    public class SongListItemController : TableController<SongListItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            StandBandContext context = new StandBandContext();
            DomainManager = new EntityDomainManager<SongListItem>(context, Request);
        }

        // GET tables/Item
        public IQueryable<SongListItem> GetAllSongListItem()
        {
            return Query();
        }

        // GET tables/Item/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<SongListItem> GetItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Item/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<SongListItem> PatchItem(string id, Delta<SongListItem> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Item
        public async Task<IHttpActionResult> PostItem(SongListItem item)
        {
            SongListItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Item/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}