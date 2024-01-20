namespace Bondr.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string CommentsEndpoint = $"{Prefix}/comments";
        public static readonly string GenresEndpoint = $"{Prefix}/genres";
        public static readonly string CommunityEndpoint = $"{Prefix}/communitys";
        public static readonly string PostEndpoint = $"{Prefix}/posts";
        public static readonly string StaffEndpoint = $"{Prefix}/staffs";
        public static readonly string SubscriptionEndpoint = $"{Prefix}/subscriptions";
        public static readonly string VisitorEndpoint = $"{Prefix}/visitors";

    }
}
