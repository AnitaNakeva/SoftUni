namespace HouseRenting.Data
{
    public static class DataConstants
    {
        public static class Category
        {
            public const int NameMaxLength = 50;
        }

        public static class House
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 10;

            public const int AddressMaxLength = 150;
            public const int AddressMinLength = 30;

            public const int DescriptionMaxLength = 500;
            public const int DescriptionMinLength = 50;
        }
        public static class Agent
        {
            public const int PhoneNumberMaxLength = 15;
            public const int PhoneNumberMinLength = 7;
        }

        public static class ApplicationUser
        {
            public const int UserFirstNameMaxLength = 12;
            public const int UserFirstNameMinLength = 1;

            public const int UserLastNameMaxLength = 15;
            public const int UserLastNameMinLength = 3;
        }

        public class AdminUser
        {
            public const string AdminRoleName = "Administrator";
            public const string AdminEmail = "adminmail@abv.bg";
        }
    }
}
