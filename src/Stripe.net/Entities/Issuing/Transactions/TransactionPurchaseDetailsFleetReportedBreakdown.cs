// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TransactionPurchaseDetailsFleetReportedBreakdown : StripeEntity<TransactionPurchaseDetailsFleetReportedBreakdown>
    {
        /// <summary>
        /// Breakdown of fuel portion of the purchase.
        /// </summary>
        [JsonProperty("fuel")]
        public TransactionPurchaseDetailsFleetReportedBreakdownFuel Fuel { get; set; }

        /// <summary>
        /// Breakdown of non-fuel portion of the purchase.
        /// </summary>
        [JsonProperty("non_fuel")]
        public TransactionPurchaseDetailsFleetReportedBreakdownNonFuel NonFuel { get; set; }

        /// <summary>
        /// Information about tax included in this transaction.
        /// </summary>
        [JsonProperty("tax")]
        public TransactionPurchaseDetailsFleetReportedBreakdownTax Tax { get; set; }
    }
}
