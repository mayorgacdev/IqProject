using EconomicMF.Domain.Entities.Flows;

namespace EconomicEF.Common.UserCache
{
    public static class DataOnMemory
    {
        public static int UserId { get; set; }
        public static string Password { get; set; }
        public static string FirstName { get; set; }
        public static string PhoneNumber { get; set; }
        public static string Email { get; set; }
        public static string Path { get; set; }
        public static string ProfileImage { get; set; }
        public static int SolutionId { get; set; }
        public static int ProjectId { get; set; }
        public static int ActivoId { get; set; }
        public static User userDto { get; set; }
        
    }
}
