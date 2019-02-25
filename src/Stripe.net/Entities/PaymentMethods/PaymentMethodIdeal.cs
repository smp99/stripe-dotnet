namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodIdeal : StripeEntity
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("bic")]
        public string Bic { get; set; }
    }
}
