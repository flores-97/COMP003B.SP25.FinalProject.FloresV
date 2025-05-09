using COMP003B.SP25.FinalProject.FloresV.Models;

namespace COMP003B.SP25.FinalProject.FloresV.Data
{
    public static class ServicesData
    {
        public static List<Services> Services { get; } = new()
        {
            new Services{ ServiceId = 1, ServiceBranch = "USN" },
            new Services{ ServiceId = 2, ServiceBranch = "USMC" },
            new Services{ ServiceId = 3, ServiceBranch = "USAF" },
            new Services{ ServiceId = 4, ServiceBranch = "USSF" },
            new Services{ ServiceId = 5, ServiceBranch = "USCG" },
            new Services{ ServiceId = 6, ServiceBranch = "USARMY" },
        };
    }
}
