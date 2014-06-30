using Tonality.Services.Interfaces;
using Windows.Networking.Connectivity;

namespace Tonality.Services
{
    public class NetworkService : INetworkService
    {
        public bool IsConnectionAvailable
        {
            get
            {
                ConnectionProfile profile = NetworkInformation.GetInternetConnectionProfile();

                if (profile == null)
                {
                    return false;
                }

                return profile.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess;
            }
        }
    }
}
