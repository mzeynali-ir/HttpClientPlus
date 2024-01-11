namespace IMustafa.Web
{
    public partial struct AuthorizationType
    {
        public string TokenKey { get; set; }
        public string TokenValue { get; set; }
    }

    public partial struct AuthorizationType
    {
        public static AuthorizationType Bearer(string token) => new AuthorizationType() { TokenKey = "Bearer", TokenValue = token };
        public static AuthorizationType Basic(string token) => new AuthorizationType() { TokenKey = "Basic", TokenValue = token };
    }
}