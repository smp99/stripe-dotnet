namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCardOptions : INestedOptions
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
