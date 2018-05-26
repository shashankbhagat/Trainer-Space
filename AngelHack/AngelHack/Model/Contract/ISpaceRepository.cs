using AngelHack.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AngelHack.Model.Contract
{
    public interface ISpaceRepository
    {
        IEnumerable<SelectListItem> GetLocations();
        IEnumerable<SelectListItem> GetSpaceTypes();
        IEnumerable<SpaceViewModel> GetAlailableSpaces(int spaceTypeId, int locationId);
    }
}
