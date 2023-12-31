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
    /// An object defining how overage charges are calculated.
    /// </summary>
    [DataContract]
    public partial class Overage :  IEquatable<Overage>, IValidatableObject
    {
        /// <summary>
        /// Represents the overage type: one of rolling_window or rollover.
        /// </summary>
        /// <value>Represents the overage type: one of rolling_window or rollover.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Rollingwindow for value: rolling_window
            /// </summary>
            [EnumMember(Value = "rolling_window")]
            Rollingwindow = 1,

            /// <summary>
            /// Enum Rollover for value: rollover
            /// </summary>
            [EnumMember(Value = "rollover")]
            Rollover = 2

        }

        /// <summary>
        /// Represents the overage type: one of rolling_window or rollover.
        /// </summary>
        /// <value>Represents the overage type: one of rolling_window or rollover.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Overage" /> class.
        /// </summary>
        /// <param name="intervalCount">Specifies the number of intervals used to calculate smoothed overage charges..</param>
        /// <param name="type">Represents the overage type: one of rolling_window or rollover..</param>
        /// <param name="includedUnits">Specifies the included units to which overage charges do not apply..</param>
        /// <param name="creditUnusedUnits">Specifies whether or not to credit unused units..</param>
        /// <param name="applyAtEndOfSmoothingPeriod">Indicates if the overage price is calculated at the end of the smoothing period..</param>
        public Overage(int intervalCount = default(int), TypeEnum? type = default(TypeEnum?), decimal includedUnits = default(decimal), bool creditUnusedUnits = default(bool), bool applyAtEndOfSmoothingPeriod = default(bool))
        {
            this.interval_count = intervalCount;
            this.type = type;
            this.included_units = includedUnits;
            this.credit_unused_units = creditUnusedUnits;
            this.apply_at_end_of_smoothing_period = applyAtEndOfSmoothingPeriod;
        }

        /// <summary>
        /// Specifies the number of intervals used to calculate smoothed overage charges.
        /// </summary>
        /// <value>Specifies the number of intervals used to calculate smoothed overage charges.</value>
        [DataMember(Name="interval_count", EmitDefaultValue=false)]
        public int interval_count { get; set; }


        /// <summary>
        /// Specifies the included units to which overage charges do not apply.
        /// </summary>
        /// <value>Specifies the included units to which overage charges do not apply.</value>
        [DataMember(Name="included_units", EmitDefaultValue=false)]
        public decimal included_units { get; set; }

        /// <summary>
        /// Specifies whether or not to credit unused units.
        /// </summary>
        /// <value>Specifies whether or not to credit unused units.</value>
        [DataMember(Name="credit_unused_units", EmitDefaultValue=false)]
        public bool credit_unused_units { get; set; }

        /// <summary>
        /// Indicates if the overage price is calculated at the end of the smoothing period.
        /// </summary>
        /// <value>Indicates if the overage price is calculated at the end of the smoothing period.</value>
        [DataMember(Name="apply_at_end_of_smoothing_period", EmitDefaultValue=false)]
        public bool apply_at_end_of_smoothing_period { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Overage {\n");
            sb.Append("  interval_count: ").Append(interval_count).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
            sb.Append("  included_units: ").Append(included_units).Append("\n");
            sb.Append("  credit_unused_units: ").Append(credit_unused_units).Append("\n");
            sb.Append("  apply_at_end_of_smoothing_period: ").Append(apply_at_end_of_smoothing_period).Append("\n");
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
            return this.Equals(input as Overage);
        }

        /// <summary>
        /// Returns true if Overage instances are equal
        /// </summary>
        /// <param name="input">Instance of Overage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Overage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.interval_count == input.interval_count ||
                    (this.interval_count != null &&
                    this.interval_count.Equals(input.interval_count))
                ) && 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
                ) && 
                (
                    this.included_units == input.included_units ||
                    (this.included_units != null &&
                    this.included_units.Equals(input.included_units))
                ) && 
                (
                    this.credit_unused_units == input.credit_unused_units ||
                    (this.credit_unused_units != null &&
                    this.credit_unused_units.Equals(input.credit_unused_units))
                ) && 
                (
                    this.apply_at_end_of_smoothing_period == input.apply_at_end_of_smoothing_period ||
                    (this.apply_at_end_of_smoothing_period != null &&
                    this.apply_at_end_of_smoothing_period.Equals(input.apply_at_end_of_smoothing_period))
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
                if (this.interval_count != null)
                    hashCode = hashCode * 59 + this.interval_count.GetHashCode();
                if (this.type != null)
                    hashCode = hashCode * 59 + this.type.GetHashCode();
                if (this.included_units != null)
                    hashCode = hashCode * 59 + this.included_units.GetHashCode();
                if (this.credit_unused_units != null)
                    hashCode = hashCode * 59 + this.credit_unused_units.GetHashCode();
                if (this.apply_at_end_of_smoothing_period != null)
                    hashCode = hashCode * 59 + this.apply_at_end_of_smoothing_period.GetHashCode();
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
