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
    /// Order line items
    /// </summary>
    [DataContract]
    public partial class LineItemCreateRequest :  IEquatable<LineItemCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// The category for the order line item, to indicate a product sale or return.
        /// </summary>
        /// <value>The category for the order line item, to indicate a product sale or return.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum Sale for value: sale
            /// </summary>
            [EnumMember(Value = "sale")]
            Sale = 1,

            /// <summary>
            /// Enum Return for value: return
            /// </summary>
            [EnumMember(Value = "return")]
            Return = 2

        }

        /// <summary>
        /// The category for the order line item, to indicate a product sale or return.
        /// </summary>
        /// <value>The category for the order line item, to indicate a product sale or return.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? category { get; set; }
        /// <summary>
        /// The state of an order line item. If you want to generate billing documents for order line items, you must set this field to &#x60;sent_to_billing&#x60;. For invoice preview, you do not need to set this field.
        /// </summary>
        /// <value>The state of an order line item. If you want to generate billing documents for order line items, you must set this field to &#x60;sent_to_billing&#x60;. For invoice preview, you do not need to set this field.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,

            /// <summary>
            /// Enum Booked for value: booked
            /// </summary>
            [EnumMember(Value = "booked")]
            Booked = 2,

            /// <summary>
            /// Enum Senttobilling for value: sent_to_billing
            /// </summary>
            [EnumMember(Value = "sent_to_billing")]
            Senttobilling = 3,

            /// <summary>
            /// Enum Complete for value: complete
            /// </summary>
            [EnumMember(Value = "complete")]
            Complete = 4,

            /// <summary>
            /// Enum Canceled for value: canceled
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled = 5

        }

        /// <summary>
        /// The state of an order line item. If you want to generate billing documents for order line items, you must set this field to &#x60;sent_to_billing&#x60;. For invoice preview, you do not need to set this field.
        /// </summary>
        /// <value>The state of an order line item. If you want to generate billing documents for order line items, you must set this field to &#x60;sent_to_billing&#x60;. For invoice preview, you do not need to set this field.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? state { get; set; }
        /// <summary>
        /// The type of the order line item.
        /// </summary>
        /// <value>The type of the order line item.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Product for value: product
            /// </summary>
            [EnumMember(Value = "product")]
            Product = 1,

            /// <summary>
            /// Enum Fee for value: fee
            /// </summary>
            [EnumMember(Value = "fee")]
            Fee = 2,

            /// <summary>
            /// Enum Services for value: services
            /// </summary>
            [EnumMember(Value = "services")]
            Services = 3

        }

        /// <summary>
        /// The type of the order line item.
        /// </summary>
        /// <value>The type of the order line item.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum type { get; set; }
        /// <summary>
        /// The billing rule for the Order Line Item.
        /// </summary>
        /// <value>The billing rule for the Order Line Item.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BillingRuleEnum
        {
            /// <summary>
            /// Enum Withoutfulfillment for value: trigger_without_fulfillment
            /// </summary>
            [EnumMember(Value = "trigger_without_fulfillment")]
            Withoutfulfillment = 1,

            /// <summary>
            /// Enum Onfulfillment for value: trigger_on_fulfillment
            /// </summary>
            [EnumMember(Value = "trigger_on_fulfillment")]
            Onfulfillment = 2

        }

        /// <summary>
        /// The billing rule for the Order Line Item.
        /// </summary>
        /// <value>The billing rule for the Order Line Item.</value>
        [DataMember(Name="billing_rule", EmitDefaultValue=false)]
        public BillingRuleEnum? billing_rule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineItemCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemCreateRequest" /> class.
        /// </summary>
        /// <param name="unitOfMeasure">A configured unit of measure. This field is required for per-unit prices..</param>
        /// <param name="unitAmount">The unit amount of the price. Specify this field if you want to override the original price with a per-unit price..</param>
        /// <param name="targetDate">The target date for the order line item to be picked up by bill run for billing..</param>
        /// <param name="customFields">Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format..</param>
        /// <param name="deferredRevenueAccount">An active accounting code in your Zuora chart of accounts..</param>
        /// <param name="description">An arbitrary string attached to the object. Often useful for displaying to users..</param>
        /// <param name="revenue">revenue.</param>
        /// <param name="discountUnitAmount">Discount amount. Specify this field if you offer an amount-based discount..</param>
        /// <param name="discountPercent">Discount percent. Specify this field if you offer a percentage-based discount..</param>
        /// <param name="category">The category for the order line item, to indicate a product sale or return..</param>
        /// <param name="state">The state of an order line item. If you want to generate billing documents for order line items, you must set this field to &#x60;sent_to_billing&#x60;. For invoice preview, you do not need to set this field..</param>
        /// <param name="type">The type of the order line item. (required).</param>
        /// <param name="name">The name of the order line item. (required).</param>
        /// <param name="itemNumber">Human-readable identifier of the order item. It can be user-supplied..</param>
        /// <param name="listUnitPrice">The list price per unit for the order line item..</param>
        /// <param name="productCode">The product code for the order line item..</param>
        /// <param name="priceId">Identifier of the price..</param>
        /// <param name="purchaseOrderNumber">Used by customers to specify the Purchase Order Number provided by the buyer..</param>
        /// <param name="quantity">The quantity of units, such as the number of authors in a hosted wiki service..</param>
        /// <param name="recognizedRevenueAccount">An active accounting code in your Zuora chart of accounts..</param>
        /// <param name="revenueRecognitionRuleName">The revenue recognition rule for the order line item..</param>
        /// <param name="soldToId">Customer address used for calculating tax..</param>
        /// <param name="taxCode">A tax code identifier. If a &#x60;tax_code&#x60; of a price is not provided when you create or update a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly..</param>
        /// <param name="taxInclusive">If this field is set to &#x60;true&#x60;, it indicates that amounts are inclusive of tax..</param>
        /// <param name="startDate">The date a transaction starts. The default value of this field is the order date..</param>
        /// <param name="endDate">The date a transaction is completed. The default value of this field is the transaction start date. Also, the value of this field should always equal or be later than the value of the &#x60;start_date&#x60; field..</param>
        /// <param name="relatedSubscriptionNumber">Relates an order line item to a subscription when you create the order line item..</param>
        /// <param name="billingRule">The billing rule for the Order Line Item..</param>
        public LineItemCreateRequest(string unitOfMeasure = default(string), decimal unitAmount = default(decimal), DateTime targetDate = default(DateTime), Dictionary<string, Object> customFields = default(Dictionary<string, Object>), string deferredRevenueAccount = default(string), string description = default(string), Revenue revenue = default(Revenue), decimal discountUnitAmount = default(decimal), decimal discountPercent = default(decimal), CategoryEnum? category = default(CategoryEnum?), StateEnum? state = default(StateEnum?), TypeEnum type = default(TypeEnum), string name = default(string), string itemNumber = default(string), decimal listUnitPrice = default(decimal), string productCode = default(string), string priceId = default(string), string purchaseOrderNumber = default(string), decimal quantity = default(decimal), string recognizedRevenueAccount = default(string), string revenueRecognitionRuleName = default(string), string soldToId = default(string), string taxCode = default(string), bool taxInclusive = default(bool), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime), string relatedSubscriptionNumber = default(string), BillingRuleEnum? billingRule = default(BillingRuleEnum?))
        {
            this.revenue = revenue;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for LineItemCreateRequest and cannot be null");
            }
            else
            {
                this.type = type;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for LineItemCreateRequest and cannot be null");
            }
            else
            {
                this.name = name;
            }

            this.unit_of_measure = unitOfMeasure;
            this.unit_amount = unitAmount;
            this.target_date = targetDate;
            this.custom_fields = customFields;
            this.deferred_revenue_account = deferredRevenueAccount;
            this.description = description;
            this.revenue = revenue;
            this.discount_unit_amount = discountUnitAmount;
            this.discount_percent = discountPercent;
            this.category = category;
            this.state = state;
            this.item_number = itemNumber;
            this.list_unit_price = listUnitPrice;
            this.product_code = productCode;
            this.price_id = priceId;
            this.purchase_order_number = purchaseOrderNumber;
            this.quantity = quantity;
            this.recognized_revenue_account = recognizedRevenueAccount;
            this.revenue_recognition_rule_name = revenueRecognitionRuleName;
            this.sold_to_id = soldToId;
            this.tax_code = taxCode;
            this.tax_inclusive = taxInclusive;
            this.start_date = startDate;
            this.end_date = endDate;
            this.related_subscription_number = relatedSubscriptionNumber;
            this.billing_rule = billingRule;
        }

        /// <summary>
        /// A configured unit of measure. This field is required for per-unit prices.
        /// </summary>
        /// <value>A configured unit of measure. This field is required for per-unit prices.</value>
        [DataMember(Name="unit_of_measure", EmitDefaultValue=false)]
        public string unit_of_measure { get; set; }

        /// <summary>
        /// The unit amount of the price. Specify this field if you want to override the original price with a per-unit price.
        /// </summary>
        /// <value>The unit amount of the price. Specify this field if you want to override the original price with a per-unit price.</value>
        [DataMember(Name="unit_amount", EmitDefaultValue=false)]
        public decimal unit_amount { get; set; }

        /// <summary>
        /// The target date for the order line item to be picked up by bill run for billing.
        /// </summary>
        /// <value>The target date for the order line item to be picked up by bill run for billing.</value>
        [DataMember(Name="target_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime target_date { get; set; }

        /// <summary>
        /// Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.
        /// </summary>
        /// <value>Set of user-defined fields associated with this object. Useful for storing additional information about the object in a structured format.</value>
        [DataMember(Name="custom_fields", EmitDefaultValue=false)]
        public Dictionary<string, Object> custom_fields { get; set; }

        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name="deferred_revenue_account", EmitDefaultValue=false)]
        public string deferred_revenue_account { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        /// <value>An arbitrary string attached to the object. Often useful for displaying to users.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string description { get; set; }

        /// <summary>
        /// Gets or Sets revenue
        /// </summary>
        [DataMember(Name="revenue", EmitDefaultValue=true)]
        public Revenue revenue { get; set; }

        /// <summary>
        /// Discount amount. Specify this field if you offer an amount-based discount.
        /// </summary>
        /// <value>Discount amount. Specify this field if you offer an amount-based discount.</value>
        [DataMember(Name="discount_unit_amount", EmitDefaultValue=false)]
        public decimal discount_unit_amount { get; set; }

        /// <summary>
        /// Discount percent. Specify this field if you offer a percentage-based discount.
        /// </summary>
        /// <value>Discount percent. Specify this field if you offer a percentage-based discount.</value>
        [DataMember(Name="discount_percent", EmitDefaultValue=false)]
        public decimal discount_percent { get; set; }




        /// <summary>
        /// The name of the order line item.
        /// </summary>
        /// <value>The name of the order line item.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string name { get; set; }

        /// <summary>
        /// Human-readable identifier of the order item. It can be user-supplied.
        /// </summary>
        /// <value>Human-readable identifier of the order item. It can be user-supplied.</value>
        [DataMember(Name="item_number", EmitDefaultValue=false)]
        public string item_number { get; set; }

        /// <summary>
        /// The list price per unit for the order line item.
        /// </summary>
        /// <value>The list price per unit for the order line item.</value>
        [DataMember(Name="list_unit_price", EmitDefaultValue=false)]
        public decimal list_unit_price { get; set; }

        /// <summary>
        /// The product code for the order line item.
        /// </summary>
        /// <value>The product code for the order line item.</value>
        [DataMember(Name="product_code", EmitDefaultValue=false)]
        public string product_code { get; set; }

        /// <summary>
        /// Identifier of the price.
        /// </summary>
        /// <value>Identifier of the price.</value>
        [DataMember(Name="price_id", EmitDefaultValue=false)]
        public string price_id { get; set; }

        /// <summary>
        /// Used by customers to specify the Purchase Order Number provided by the buyer.
        /// </summary>
        /// <value>Used by customers to specify the Purchase Order Number provided by the buyer.</value>
        [DataMember(Name="purchase_order_number", EmitDefaultValue=false)]
        public string purchase_order_number { get; set; }

        /// <summary>
        /// The quantity of units, such as the number of authors in a hosted wiki service.
        /// </summary>
        /// <value>The quantity of units, such as the number of authors in a hosted wiki service.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal quantity { get; set; }

        /// <summary>
        /// An active accounting code in your Zuora chart of accounts.
        /// </summary>
        /// <value>An active accounting code in your Zuora chart of accounts.</value>
        [DataMember(Name="recognized_revenue_account", EmitDefaultValue=false)]
        public string recognized_revenue_account { get; set; }

        /// <summary>
        /// The revenue recognition rule for the order line item.
        /// </summary>
        /// <value>The revenue recognition rule for the order line item.</value>
        [DataMember(Name="revenue_recognition_rule_name", EmitDefaultValue=false)]
        public string revenue_recognition_rule_name { get; set; }

        /// <summary>
        /// Customer address used for calculating tax.
        /// </summary>
        /// <value>Customer address used for calculating tax.</value>
        [DataMember(Name="sold_to_id", EmitDefaultValue=false)]
        public string sold_to_id { get; set; }

        /// <summary>
        /// A tax code identifier. If a &#x60;tax_code&#x60; of a price is not provided when you create or update a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly.
        /// </summary>
        /// <value>A tax code identifier. If a &#x60;tax_code&#x60; of a price is not provided when you create or update a price, Zuora will treat the charged amount as non-taxable. If this code is provide, Zuora considers that this price is taxable and the charged amount will be handled accordingly.</value>
        [DataMember(Name="tax_code", EmitDefaultValue=false)]
        public string tax_code { get; set; }

        /// <summary>
        /// If this field is set to &#x60;true&#x60;, it indicates that amounts are inclusive of tax.
        /// </summary>
        /// <value>If this field is set to &#x60;true&#x60;, it indicates that amounts are inclusive of tax.</value>
        [DataMember(Name="tax_inclusive", EmitDefaultValue=false)]
        public bool tax_inclusive { get; set; }

        /// <summary>
        /// The date a transaction starts. The default value of this field is the order date.
        /// </summary>
        /// <value>The date a transaction starts. The default value of this field is the order date.</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime start_date { get; set; }

        /// <summary>
        /// The date a transaction is completed. The default value of this field is the transaction start date. Also, the value of this field should always equal or be later than the value of the &#x60;start_date&#x60; field.
        /// </summary>
        /// <value>The date a transaction is completed. The default value of this field is the transaction start date. Also, the value of this field should always equal or be later than the value of the &#x60;start_date&#x60; field.</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime end_date { get; set; }

        /// <summary>
        /// List of invoice items. EXPANDABLE
        /// </summary>
        /// <value>List of invoice items. EXPANDABLE</value>
        [DataMember(Name="invoice_items", EmitDefaultValue=true)]
        public InvoiceItemListResponse invoice_items { get; private set; }

        /// <summary>
        /// Relates an order line item to a subscription when you create the order line item.
        /// </summary>
        /// <value>Relates an order line item to a subscription when you create the order line item.</value>
        [DataMember(Name="related_subscription_number", EmitDefaultValue=false)]
        public string related_subscription_number { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItemCreateRequest {\n");
            sb.Append("  unit_of_measure: ").Append(unit_of_measure).Append("\n");
            sb.Append("  unit_amount: ").Append(unit_amount).Append("\n");
            sb.Append("  target_date: ").Append(target_date).Append("\n");
            sb.Append("  custom_fields: ").Append(custom_fields).Append("\n");
            sb.Append("  deferred_revenue_account: ").Append(deferred_revenue_account).Append("\n");
            sb.Append("  description: ").Append(description).Append("\n");
            sb.Append("  revenue: ").Append(revenue).Append("\n");
            sb.Append("  discount_unit_amount: ").Append(discount_unit_amount).Append("\n");
            sb.Append("  discount_percent: ").Append(discount_percent).Append("\n");
            sb.Append("  category: ").Append(category).Append("\n");
            sb.Append("  state: ").Append(state).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  item_number: ").Append(item_number).Append("\n");
            sb.Append("  list_unit_price: ").Append(list_unit_price).Append("\n");
            sb.Append("  product_code: ").Append(product_code).Append("\n");
            sb.Append("  price_id: ").Append(price_id).Append("\n");
            sb.Append("  purchase_order_number: ").Append(purchase_order_number).Append("\n");
            sb.Append("  quantity: ").Append(quantity).Append("\n");
            sb.Append("  recognized_revenue_account: ").Append(recognized_revenue_account).Append("\n");
            sb.Append("  revenue_recognition_rule_name: ").Append(revenue_recognition_rule_name).Append("\n");
            sb.Append("  sold_to_id: ").Append(sold_to_id).Append("\n");
            sb.Append("  tax_code: ").Append(tax_code).Append("\n");
            sb.Append("  tax_inclusive: ").Append(tax_inclusive).Append("\n");
            sb.Append("  start_date: ").Append(start_date).Append("\n");
            sb.Append("  end_date: ").Append(end_date).Append("\n");
            sb.Append("  invoice_items: ").Append(invoice_items).Append("\n");
            sb.Append("  related_subscription_number: ").Append(related_subscription_number).Append("\n");
            sb.Append("  billing_rule: ").Append(billing_rule).Append("\n");
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
            return this.Equals(input as LineItemCreateRequest);
        }

        /// <summary>
        /// Returns true if LineItemCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItemCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.unit_of_measure == input.unit_of_measure ||
                    (this.unit_of_measure != null &&
                    this.unit_of_measure.Equals(input.unit_of_measure))
                ) && 
                (
                    this.unit_amount == input.unit_amount ||
                    (this.unit_amount != null &&
                    this.unit_amount.Equals(input.unit_amount))
                ) && 
                (
                    this.target_date == input.target_date ||
                    (this.target_date != null &&
                    this.target_date.Equals(input.target_date))
                ) && 
                (
                    this.custom_fields == input.custom_fields ||
                    this.custom_fields != null &&
                    input.custom_fields != null &&
                    this.custom_fields.SequenceEqual(input.custom_fields)
                ) && 
                (
                    this.deferred_revenue_account == input.deferred_revenue_account ||
                    (this.deferred_revenue_account != null &&
                    this.deferred_revenue_account.Equals(input.deferred_revenue_account))
                ) && 
                (
                    this.description == input.description ||
                    (this.description != null &&
                    this.description.Equals(input.description))
                ) && 
                (
                    this.revenue == input.revenue ||
                    (this.revenue != null &&
                    this.revenue.Equals(input.revenue))
                ) && 
                (
                    this.discount_unit_amount == input.discount_unit_amount ||
                    (this.discount_unit_amount != null &&
                    this.discount_unit_amount.Equals(input.discount_unit_amount))
                ) && 
                (
                    this.discount_percent == input.discount_percent ||
                    (this.discount_percent != null &&
                    this.discount_percent.Equals(input.discount_percent))
                ) && 
                (
                    this.category == input.category ||
                    (this.category != null &&
                    this.category.Equals(input.category))
                ) && 
                (
                    this.state == input.state ||
                    (this.state != null &&
                    this.state.Equals(input.state))
                ) && 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
                ) && 
                (
                    this.name == input.name ||
                    (this.name != null &&
                    this.name.Equals(input.name))
                ) && 
                (
                    this.item_number == input.item_number ||
                    (this.item_number != null &&
                    this.item_number.Equals(input.item_number))
                ) && 
                (
                    this.list_unit_price == input.list_unit_price ||
                    (this.list_unit_price != null &&
                    this.list_unit_price.Equals(input.list_unit_price))
                ) && 
                (
                    this.product_code == input.product_code ||
                    (this.product_code != null &&
                    this.product_code.Equals(input.product_code))
                ) && 
                (
                    this.price_id == input.price_id ||
                    (this.price_id != null &&
                    this.price_id.Equals(input.price_id))
                ) && 
                (
                    this.purchase_order_number == input.purchase_order_number ||
                    (this.purchase_order_number != null &&
                    this.purchase_order_number.Equals(input.purchase_order_number))
                ) && 
                (
                    this.quantity == input.quantity ||
                    (this.quantity != null &&
                    this.quantity.Equals(input.quantity))
                ) && 
                (
                    this.recognized_revenue_account == input.recognized_revenue_account ||
                    (this.recognized_revenue_account != null &&
                    this.recognized_revenue_account.Equals(input.recognized_revenue_account))
                ) && 
                (
                    this.revenue_recognition_rule_name == input.revenue_recognition_rule_name ||
                    (this.revenue_recognition_rule_name != null &&
                    this.revenue_recognition_rule_name.Equals(input.revenue_recognition_rule_name))
                ) && 
                (
                    this.sold_to_id == input.sold_to_id ||
                    (this.sold_to_id != null &&
                    this.sold_to_id.Equals(input.sold_to_id))
                ) && 
                (
                    this.tax_code == input.tax_code ||
                    (this.tax_code != null &&
                    this.tax_code.Equals(input.tax_code))
                ) && 
                (
                    this.tax_inclusive == input.tax_inclusive ||
                    (this.tax_inclusive != null &&
                    this.tax_inclusive.Equals(input.tax_inclusive))
                ) && 
                (
                    this.start_date == input.start_date ||
                    (this.start_date != null &&
                    this.start_date.Equals(input.start_date))
                ) && 
                (
                    this.end_date == input.end_date ||
                    (this.end_date != null &&
                    this.end_date.Equals(input.end_date))
                ) && 
                (
                    this.invoice_items == input.invoice_items ||
                    (this.invoice_items != null &&
                    this.invoice_items.Equals(input.invoice_items))
                ) && 
                (
                    this.related_subscription_number == input.related_subscription_number ||
                    (this.related_subscription_number != null &&
                    this.related_subscription_number.Equals(input.related_subscription_number))
                ) && 
                (
                    this.billing_rule == input.billing_rule ||
                    (this.billing_rule != null &&
                    this.billing_rule.Equals(input.billing_rule))
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
                if (this.unit_of_measure != null)
                    hashCode = hashCode * 59 + this.unit_of_measure.GetHashCode();
                if (this.unit_amount != null)
                    hashCode = hashCode * 59 + this.unit_amount.GetHashCode();
                if (this.target_date != null)
                    hashCode = hashCode * 59 + this.target_date.GetHashCode();
                if (this.custom_fields != null)
                    hashCode = hashCode * 59 + this.custom_fields.GetHashCode();
                if (this.deferred_revenue_account != null)
                    hashCode = hashCode * 59 + this.deferred_revenue_account.GetHashCode();
                if (this.description != null)
                    hashCode = hashCode * 59 + this.description.GetHashCode();
                if (this.revenue != null)
                    hashCode = hashCode * 59 + this.revenue.GetHashCode();
                if (this.discount_unit_amount != null)
                    hashCode = hashCode * 59 + this.discount_unit_amount.GetHashCode();
                if (this.discount_percent != null)
                    hashCode = hashCode * 59 + this.discount_percent.GetHashCode();
                if (this.category != null)
                    hashCode = hashCode * 59 + this.category.GetHashCode();
                if (this.state != null)
                    hashCode = hashCode * 59 + this.state.GetHashCode();
                if (this.type != null)
                    hashCode = hashCode * 59 + this.type.GetHashCode();
                if (this.name != null)
                    hashCode = hashCode * 59 + this.name.GetHashCode();
                if (this.item_number != null)
                    hashCode = hashCode * 59 + this.item_number.GetHashCode();
                if (this.list_unit_price != null)
                    hashCode = hashCode * 59 + this.list_unit_price.GetHashCode();
                if (this.product_code != null)
                    hashCode = hashCode * 59 + this.product_code.GetHashCode();
                if (this.price_id != null)
                    hashCode = hashCode * 59 + this.price_id.GetHashCode();
                if (this.purchase_order_number != null)
                    hashCode = hashCode * 59 + this.purchase_order_number.GetHashCode();
                if (this.quantity != null)
                    hashCode = hashCode * 59 + this.quantity.GetHashCode();
                if (this.recognized_revenue_account != null)
                    hashCode = hashCode * 59 + this.recognized_revenue_account.GetHashCode();
                if (this.revenue_recognition_rule_name != null)
                    hashCode = hashCode * 59 + this.revenue_recognition_rule_name.GetHashCode();
                if (this.sold_to_id != null)
                    hashCode = hashCode * 59 + this.sold_to_id.GetHashCode();
                if (this.tax_code != null)
                    hashCode = hashCode * 59 + this.tax_code.GetHashCode();
                if (this.tax_inclusive != null)
                    hashCode = hashCode * 59 + this.tax_inclusive.GetHashCode();
                if (this.start_date != null)
                    hashCode = hashCode * 59 + this.start_date.GetHashCode();
                if (this.end_date != null)
                    hashCode = hashCode * 59 + this.end_date.GetHashCode();
                if (this.invoice_items != null)
                    hashCode = hashCode * 59 + this.invoice_items.GetHashCode();
                if (this.related_subscription_number != null)
                    hashCode = hashCode * 59 + this.related_subscription_number.GetHashCode();
                if (this.billing_rule != null)
                    hashCode = hashCode * 59 + this.billing_rule.GetHashCode();
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
            // deferred_revenue_account (string) maxLength
            if(this.deferred_revenue_account != null && this.deferred_revenue_account.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for deferred_revenue_account, length must be less than 100.", new [] { "deferred_revenue_account" });
            }


            // recognized_revenue_account (string) maxLength
            if(this.recognized_revenue_account != null && this.recognized_revenue_account.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for recognized_revenue_account, length must be less than 100.", new [] { "recognized_revenue_account" });
            }


            yield break;
        }
    }

}