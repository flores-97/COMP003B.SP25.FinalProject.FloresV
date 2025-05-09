using COMP003B.SP25.FinalProject.FloresV.Models;

namespace COMP003B.SP25.FinalProject.FloresV.Data
{
    public static class ServiceData
    {
        public static List<Service> Services { get; } = new()
        {
            new Service{ ServiceId = 1, ServiceBranch = "USN" },
            new Service{ ServiceId = 2, ServiceBranch = "USMC" },
            new Service{ ServiceId = 3, ServiceBranch = "USAF" },
            new Service{ ServiceId = 4, ServiceBranch = "USSF" },
            new Service{ ServiceId = 5, ServiceBranch = "USCG" },
            new Service{ ServiceId = 6, ServiceBranch = "USARMY" },
        };
    }
}
