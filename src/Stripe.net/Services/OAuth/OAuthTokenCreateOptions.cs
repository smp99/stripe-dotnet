namespace Stripe
{
    using Newtonsoft.Json;

    public class OAuthTokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// The secret API key. When converting an authorization code to an access token, you must
        /// use an API key that matches the mode—live or test—of the authorization code (which
        /// depends on whether the <c>client_id</c> used was production or development).
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; } = StripeConfiguration.ApiKey;

        /// <summary>The value of the <c>code</c>, depending on the <c>grant_type</c>.</summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// <c>authorization_code</c> when turning an authorization code into an access token, or
        /// <c>refresh_token</c> when using a refresh token to get a new access token.
        /// </summary>
        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

        /// <summary>The value of the <c>refresh_token</c>, depending on the <c>grant_type</c>.</summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// <para>
        /// When requesting a new access token from a refresh token, any scope that has an equal or
        /// lesser scope as the refresh token. Has no effect when requesting an access token from an
        /// authorization code.
        /// </para>
        /// <para>Defaults to the scope of the refresh token.</para>
        /// </summary>
        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}
