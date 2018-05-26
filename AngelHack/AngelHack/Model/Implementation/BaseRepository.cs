using AngelHack.Model.Contract;

namespace AngelHack.Model.Implementation
{
    public class BaseRepository
    {
        protected readonly IAppDbContex _appDbContext;

        public BaseRepository(IAppDbContex appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}