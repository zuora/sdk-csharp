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
    /// WorkflowRun
    /// </summary>
    [DataContract]
    public partial class WorkflowRun :  IEquatable<WorkflowRun>, IValidatableObject
    {
        /// <summary>
        /// The type of the active version. Currently the only valid value is &#x60;Workflow::Setup&#x60;.
        /// </summary>
        /// <value>The type of the active version. Currently the only valid value is &#x60;Workflow::Setup&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Setup for value: setup
            /// </summary>
            [EnumMember(Value = "setup")]
            Setup = 1,

            /// <summary>
            /// Enum Instance for value: instance
            /// </summary>
            [EnumMember(Value = "instance")]
            Instance = 2

        }

        /// <summary>
        /// The type of the active version. Currently the only valid value is &#x60;Workflow::Setup&#x60;.
        /// </summary>
        /// <value>The type of the active version. Currently the only valid value is &#x60;Workflow::Setup&#x60;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? type { get; set; }
        /// <summary>
        /// The status of an active version.
        /// </summary>
        /// <value>The status of an active version.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Queued for value: queued
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued = 1,

            /// <summary>
            /// Enum Processing for value: processing
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing = 2

        }

        /// <summary>
        /// The status of an active version.
        /// </summary>
        /// <value>The status of an active version.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? state { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRun" /> class.
        /// </summary>
        /// <param name="id">The unique ID of an active version..</param>
        /// <param name="type">The type of the active version. Currently the only valid value is &#x60;Workflow::Setup&#x60;..</param>
        /// <param name="state">The status of an active version..</param>
        /// <param name="originalWorkflowId">Identifier of the original Workflow version..</param>
        /// <param name="name">The name of the workflow definition..</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="updatedTime">updatedTime.</param>
        public WorkflowRun(int id = default(int), TypeEnum? type = default(TypeEnum?), StateEnum? state = default(StateEnum?), int originalWorkflowId = default(int), string name = default(string), DateTime createdTime = default(DateTime), DateTime updatedTime = default(DateTime))
        {
            this.id = id;
            this.type = type;
            this.state = state;
            this.original_workflow_id = originalWorkflowId;
            this.name = name;
            this.created_time = createdTime;
            this.updated_time = updatedTime;
        }

        /// <summary>
        /// The unique ID of an active version.
        /// </summary>
        /// <value>The unique ID of an active version.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int id { get; set; }



        /// <summary>
        /// Identifier of the original Workflow version.
        /// </summary>
        /// <value>Identifier of the original Workflow version.</value>
        [DataMember(Name="original_workflow_id", EmitDefaultValue=false)]
        public int original_workflow_id { get; set; }

        /// <summary>
        /// The name of the workflow definition.
        /// </summary>
        /// <value>The name of the workflow definition.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string name { get; set; }

        /// <summary>
        /// Gets or Sets created_time
        /// </summary>
        [DataMember(Name="created_time", EmitDefaultValue=false)]
        public DateTime created_time { get; set; }

        /// <summary>
        /// Gets or Sets updated_time
        /// </summary>
        [DataMember(Name="updated_time", EmitDefaultValue=false)]
        public DateTime updated_time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowRun {\n");
            sb.Append("  id: ").Append(id).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
            sb.Append("  state: ").Append(state).Append("\n");
            sb.Append("  original_workflow_id: ").Append(original_workflow_id).Append("\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  created_time: ").Append(created_time).Append("\n");
            sb.Append("  updated_time: ").Append(updated_time).Append("\n");
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
            return this.Equals(input as WorkflowRun);
        }

        /// <summary>
        /// Returns true if WorkflowRun instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkflowRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowRun input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.id == input.id ||
                    (this.id != null &&
                    this.id.Equals(input.id))
                ) && 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
                ) && 
                (
                    this.state == input.state ||
                    (this.state != null &&
                    this.state.Equals(input.state))
                ) && 
                (
                    this.original_workflow_id == input.original_workflow_id ||
                    (this.original_workflow_id != null &&
                    this.original_workflow_id.Equals(input.original_workflow_id))
                ) && 
                (
                    this.name == input.name ||
                    (this.name != null &&
                    this.name.Equals(input.name))
                ) && 
                (
                    this.created_time == input.created_time ||
                    (this.created_time != null &&
                    this.created_time.Equals(input.created_time))
                ) && 
                (
                    this.updated_time == input.updated_time ||
                    (this.updated_time != null &&
                    this.updated_time.Equals(input.updated_time))
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
                if (this.id != null)
                    hashCode = hashCode * 59 + this.id.GetHashCode();
                if (this.type != null)
                    hashCode = hashCode * 59 + this.type.GetHashCode();
                if (this.state != null)
                    hashCode = hashCode * 59 + this.state.GetHashCode();
                if (this.original_workflow_id != null)
                    hashCode = hashCode * 59 + this.original_workflow_id.GetHashCode();
                if (this.name != null)
                    hashCode = hashCode * 59 + this.name.GetHashCode();
                if (this.created_time != null)
                    hashCode = hashCode * 59 + this.created_time.GetHashCode();
                if (this.updated_time != null)
                    hashCode = hashCode * 59 + this.updated_time.GetHashCode();
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