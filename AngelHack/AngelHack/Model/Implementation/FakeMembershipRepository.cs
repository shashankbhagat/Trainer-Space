using AngelHack.Model.Contract;

namespace AngelHack.Model.Implementation
{
    public class FakeMembershipRepository : IMembershipRepository
    {      
        public bool VerifyLogin(string userName, string password)
        {
            return true;
        }
    }
}