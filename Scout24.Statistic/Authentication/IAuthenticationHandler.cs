namespace Scout24.Statistic.Internal
{
    interface IAuthenticationHandler
    {
        void Authenticate(IRequest request, Credentials credentials);
    }
}