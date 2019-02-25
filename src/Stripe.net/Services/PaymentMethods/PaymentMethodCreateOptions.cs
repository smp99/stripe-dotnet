namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentMethodCreateOptions : BaseOptions
    {
        [JsonProperty("application_fee")]
        public long? ApplicationFee { get; set; }

        [JsonProperty("card")]
        public PaymentMethodCardOptions Card { get; set; }

        [JsonProperty("ideal")]
        public PaymentMethodIdealOptions Ideal { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("sepa_debit")]
        public PaymentMethodSepaDebitOptions SepaDebit { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
