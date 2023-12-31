/*
 * Quickstart API Reference
 *
 * Zuora Quickstart API is recommended for new customers and integrators, allowing new integrators to swiftly integrate with Zuora. It supports essential business use cases.   To use the Quickstart API, you must have the following features enabled on your tenant:   * [Orders](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders) or [Orders Harmonization](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders/Orders_Harmonization)  * [Invoice Settlement](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/Invoice_Settlement)  To find the latest changes made to the Zuora Quickstart API, check the [Quickstart API Changelog](https://www.zuora.com/developer/quickstart-api/changelog/2022q4-changelog/).  We recommend that you subscribe to [Developers Community](https://community.zuora.com/communities/community-home?communitykey=e2a932b4-50c4-4019-a3e8-362e38714df3) to get notifications when a new version is released.  
 *
 * The version of the OpenAPI document: 2023-09-25
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Zuora.Client.OpenAPIDateConverter;

namespace Zuora.Model
{
    /// <summary>
    /// FilfillmentItemListResponse
    /// </summary>
    [DataContract]
    public partial class FilfillmentItemListResponse :  IEquatable<FilfillmentItemListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilfillmentItemListResponse" /> class.
        /// </summary>
        /// <param name="nextPage">nextPage.</param>
        /// <param name="data">data.</param>
        public FilfillmentItemListResponse(string nextPage = default(string), List<FulfillmentItem> data = default(List<FulfillmentItem>))
        {
            this.next_page = nextPage;
            this.next_page = nextPage;
            this.data = data;
        }

        /// <summary>
        /// Gets or Sets next_page
        /// </summary>
        [DataMember(Name="next_page", EmitDefaultValue=true)]
        public string next_page { get; set; }

        /// <summary>
        /// Gets or Sets data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<FulfillmentItem> data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilfillmentItemListResponse {\n");
            sb.Append("  next_page: ").Append(next_page).Append("\n");
            sb.Append("  data: ").Append(data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FilfillmentItemListResponse);
        }

        /// <summary>
        /// Returns true if FilfillmentItemListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FilfillmentItemListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilfillmentItemListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.next_page == input.next_page ||
                    (this.next_page != null &&
                    this.next_page.Equals(input.next_page))
                ) && 
                (
                    this.data == input.data ||
                    this.data != null &&
                    input.data != null &&
                    this.data.SequenceEqual(input.data)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.next_page != null)
                    hashCode = hashCode * 59 + this.next_page.GetHashCode();
                if (this.data != null)
                    hashCode = hashCode * 59 + this.data.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
