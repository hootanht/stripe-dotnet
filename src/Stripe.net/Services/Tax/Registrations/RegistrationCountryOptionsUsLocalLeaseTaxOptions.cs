// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationCountryOptionsUsLocalLeaseTaxOptions : INestedOptions
    {
        /// <summary>
        /// A <a href="https://www.census.gov/library/reference/code-lists/ansi.html">FIPS code</a>
        /// representing the local jurisdiction.
        /// </summary>
        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }
    }
}
