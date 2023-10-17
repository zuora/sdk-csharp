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
    /// Tier information for tiered prices.
    /// </summary>
    [DataContract]
    public partial class Tier :  IEquatable<Tier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tier" /> class.
        /// </summary>
        /// <param name="upTo">The upper bound of a tier. The lower bound of a tier is the upper bound of the previous tier plus one or some fraction of one, depending on the precision of the unit of measure..</param>
        /// <param name="amounts">The amount of the price. Specify this field if you want to override the original price with a flat-fee price..</param>
        /// <param name="unitAmounts">The unit amount of the price. Specify this field if you want to override the original price with a per-unit price..</param>
        public Tier(decimal upTo = default(decimal), Dictionary<String,decimal> amounts = default(Dictionary<String,decimal>), Dictionary<String,decimal> unitAmounts = default(Dictionary<String,decimal>))
        {
            this.amounts = amounts;
            this.unit_amounts = unitAmounts;
            this.up_to = upTo;
            this.amounts = amounts;
            this.unit_amounts = unitAmounts;
        }

        /// <summary>
        /// The upper bound of a tier. The lower bound of a tier is the upper bound of the previous tier plus one or some fraction of one, depending on the precision of the unit of measure.
        /// </summary>
        /// <value>The upper bound of a tier. The lower bound of a tier is the upper bound of the previous tier plus one or some fraction of one, depending on the precision of the unit of measure.</value>
        [DataMember(Name="up_to", EmitDefaultValue=false)]
        public decimal up_to { get; set; }

        /// <summary>
        /// The amount of the price. Specify this field if you want to override the original price with a flat-fee price.
        /// </summary>
        /// <value>The amount of the price. Specify this field if you want to override the original price with a flat-fee price.</value>
        [DataMember(Name="amounts", EmitDefaultValue=true)]
        public Dictionary<String,decimal> amounts { get; set; }

        /// <summary>
        /// The unit amount of the price. Specify this field if you want to override the original price with a per-unit price.
        /// </summary>
        /// <value>The unit amount of the price. Specify this field if you want to override the original price with a per-unit price.</value>
        [DataMember(Name="unit_amounts", EmitDefaultValue=true)]
        public Dictionary<String,decimal> unit_amounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tier {\n");
            sb.Append("  up_to: ").Append(up_to).Append("\n");
            sb.Append("  amounts: ").Append(amounts).Append("\n");
            sb.Append("  unit_amounts: ").Append(unit_amounts).Append("\n");
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
            return this.Equals(input as Tier);
        }

        /// <summary>
        /// Returns true if Tier instances are equal
        /// </summary>
        /// <param name="input">Instance of Tier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.up_to == input.up_to ||
                    (this.up_to != null &&
                    this.up_to.Equals(input.up_to))
                ) && 
                (
                    this.amounts == input.amounts ||
                    (this.amounts != null &&
                    this.amounts.Equals(input.amounts))
                ) && 
                (
                    this.unit_amounts == input.unit_amounts ||
                    (this.unit_amounts != null &&
                    this.unit_amounts.Equals(input.unit_amounts))
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
                if (this.up_to != null)
                    hashCode = hashCode * 59 + this.up_to.GetHashCode();
                if (this.amounts != null)
                    hashCode = hashCode * 59 + this.amounts.GetHashCode();
                if (this.unit_amounts != null)
                    hashCode = hashCode * 59 + this.unit_amounts.GetHashCode();
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