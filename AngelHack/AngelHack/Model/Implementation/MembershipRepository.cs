using AngelHack.Model.Contract;

namespace AngelHack.Model.Implementation
{
    public class MembershipRepository : IMembershipRepository
    {      
        public bool VerifyLogin(string userName, string password)
        {
            return true;
        }
    }
}