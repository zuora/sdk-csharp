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
    /// Drawdown
    /// </summary>
    [DataContract]
    public partial class Drawdown :  IEquatable<Drawdown>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Drawdown" /> class.
        /// </summary>
        /// <param name="conversionRate">The conversion rate between usage unit of measure (UOM) and drawdown unit of measure for a drawdown charge.        **Note**:    &lt;ul&gt;    &lt;li&gt;Must be a positive number (&gt;0).&lt;/li&gt;    &lt;li&gt;Must be &#x60;1&#x60; when usage UOM and drawdown UOM are the same.&lt;/li&gt;     &lt;li&gt;If both &#x60;conversion_rate&#x60; and &#x60;unit_of_measure&#x60; for the drawdown are empty, the system will set default values respectively: &lt;ul&gt;      &lt;li&gt; &#x60;conversion_rate&#x60;: 1 &lt;/li&gt;      &lt;li&gt; &#x60;unit_of_measure&#x60;: Same as the usage UOM of this drawdown charge. &lt;/li&gt;&lt;/ul&gt;&lt;/li&gt;&lt;/ul&gt;        The &#x60;conversion_rate&#x60; and &#x60;unit_of_measure&#x60; fields need to have values or be empty at the same time.     .</param>
        /// <param name="unitOfMeasure">Unit of measurement for a drawdown charge..</param>
        public Drawdown(decimal conversionRate = default(decimal), string unitOfMeasure = default(string))
        {
            this.conversion_rate = conversionRate;
            this.unit_of_measure = unitOfMeasure;
        }

        /// <summary>
        /// The conversion rate between usage unit of measure (UOM) and drawdown unit of measure for a drawdown charge.        **Note**:    &lt;ul&gt;    &lt;li&gt;Must be a positive number (&gt;0).&lt;/li&gt;    &lt;li&gt;Must be &#x60;1&#x60; when usage UOM and drawdown UOM are the same.&lt;/li&gt;     &lt;li&gt;If both &#x60;conversion_rate&#x60; and &#x60;unit_of_measure&#x60; for the drawdown are empty, the system will set default values respectively: &lt;ul&gt;      &lt;li&gt; &#x60;conversion_rate&#x60;: 1 &lt;/li&gt;      &lt;li&gt; &#x60;unit_of_measure&#x60;: Same as the usage UOM of this drawdown charge. &lt;/li&gt;&lt;/ul&gt;&lt;/li&gt;&lt;/ul&gt;        The &#x60;conversion_rate&#x60; and &#x60;unit_of_measure&#x60; fields need to have values or be empty at the same time.     
        /// </summary>
        /// <value>The conversion rate between usage unit of measure (UOM) and drawdown unit of measure for a drawdown charge.        **Note**:    &lt;ul&gt;    &lt;li&gt;Must be a positive number (&gt;0).&lt;/li&gt;    &lt;li&gt;Must be &#x60;1&#x60; when usage UOM and drawdown UOM are the same.&lt;/li&gt;     &lt;li&gt;If both &#x60;conversion_rate&#x60; and &#x60;unit_of_measure&#x60; for the drawdown are empty, the system will set default values respectively: &lt;ul&gt;      &lt;li&gt; &#x60;conversion_rate&#x60;: 1 &lt;/li&gt;      &lt;li&gt; &#x60;unit_of_measure&#x60;: Same as the usage UOM of this drawdown charge. &lt;/li&gt;&lt;/ul&gt;&lt;/li&gt;&lt;/ul&gt;        The &#x60;conversion_rate&#x60; and &#x60;unit_of_measure&#x60; fields need to have values or be empty at the same time.     </value>
        [DataMember(Name="conversion_rate", EmitDefaultValue=false)]
        public decimal conversion_rate { get; set; }

        /// <summary>
        /// Unit of measurement for a drawdown charge.
        /// </summary>
        /// <value>Unit of measurement for a drawdown charge.</value>
        [DataMember(Name="unit_of_measure", EmitDefaultValue=false)]
        public string unit_of_measure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Drawdown {\n");
            sb.Append("  conversion_rate: ").Append(conversion_rate).Append("\n");
            sb.Append("  unit_of_measure: ").Append(unit_of_measure).Append("\n");
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
            return this.Equals(input as Drawdown);
        }

        /// <summary>
        /// Returns true if Drawdown instances are equal
        /// </summary>
        /// <param name="input">Instance of Drawdown to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Drawdown input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.conversion_rate == input.conversion_rate ||
                    (this.conversion_rate != null &&
                    this.conversion_rate.Equals(input.conversion_rate))
                ) && 
                (
                    this.unit_of_measure == input.unit_of_measure ||
                    (this.unit_of_measure != null &&
                    this.unit_of_measure.Equals(input.unit_of_measure))
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
                if (this.conversion_rate != null)
                    hashCode = hashCode * 59 + this.conversion_rate.GetHashCode();
                if (this.unit_of_measure != null)
                    hashCode = hashCode * 59 + this.unit_of_measure.GetHashCode();
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
