using AngelHack.Model.Contract;
using AngelHack.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AngelHack.Model.Implementation
{
    public class SpaceRepository : BaseRepository, ISpaceRepository
    {
        public SpaceRepository(IAppDbContex appDbContext) : base(appDbContext)
        {

        }

        public IEnumerable<SelectListItem> GetLocations()
        {
            return _appDbContext.Locations
                .Select(l => new SelectListItem() { Text = l.Name, Value = l.Id.ToString() })
                .ToList();
        }

        public IEnumerable<SelectListItem> GetSpaceTypes()
        {
            return _appDbContext.SpaceTypes
                .Select(l => new SelectListItem() { Text = l.Title, Value = l.Id.ToString() })
                .ToList();
        }

        IEnumerable<SpaceViewModel> ISpaceRepository.GetAlailableSpaces(int spaceTypeId, int locationId)
        {
            return _appDbContext.Spaces
                .Include("Location")
                .Include("SpaceType")
                .Where(s => locationId == 0 || s.Location.Id == locationId)
                .Where(s => spaceTypeId == 0 || s.SpaceType.Id == spaceTypeId)
                 .Select(s => new SpaceViewModel
                 {
                     Id = s.Id,
                     ImageUrl = s.ImageUrl,
                     Title = s.Title
                 })
                .ToList();
        }
    }
}