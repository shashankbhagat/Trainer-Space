namespace AngelHack.Model.Contract
{
    public interface IMembershipRepository
    {
        bool VerifyLogin(string userName, string password);
    }
}
