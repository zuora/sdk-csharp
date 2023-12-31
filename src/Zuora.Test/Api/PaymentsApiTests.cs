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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Zuora.Client;
using Zuora.Api;
using Zuora.Model;

namespace Zuora.Test
{
    /// <summary>
    ///  Class for testing PaymentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PaymentsApiTests
    {
        private PaymentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PaymentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' PaymentsApi
            //Assert.IsInstanceOf(typeof(PaymentsApi), instance);
        }

        
        /// <summary>
        /// Test ApplyPayment
        /// </summary>
        [Test]
        public void ApplyPaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string paymentId = null;
            //PaymentApplyUnapplyRequest paymentApplyUnapplyRequest = null;
            //List<string> fields = null;
            //List<string> accountFields = null;
            //List<string> paymentMethodFields = null;
            //List<string> paymentAppliedToFields = null;
            //List<string> paymentAppliedToItemsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.ApplyPayment(paymentId, paymentApplyUnapplyRequest, fields, accountFields, paymentMethodFields, paymentAppliedToFields, paymentAppliedToItemsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Payment), response, "response is Payment");
        }
        
        /// <summary>
        /// Test CancelPayment
        /// </summary>
        [Test]
        public void CancelPaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string paymentId = null;
            //List<string> fields = null;
            //List<string> accountFields = null;
            //List<string> paymentMethodFields = null;
            //List<string> paymentAppliedToFields = null;
            //List<string> paymentAppliedToItemsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityId = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.CancelPayment(paymentId, fields, accountFields, paymentMethodFields, paymentAppliedToFields, paymentAppliedToItemsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityId, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Payment), response, "response is Payment");
        }
        
        /// <summary>
        /// Test CreatePayment
        /// </summary>
        [Test]
        public void CreatePaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PaymentCreateRequest paymentCreateRequest = null;
            //List<string> fields = null;
            //List<string> accountFields = null;
            //List<string> paymentMethodFields = null;
            //List<string> paymentAppliedToFields = null;
            //List<string> paymentAppliedToItemsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.CreatePayment(paymentCreateRequest, fields, accountFields, paymentMethodFields, paymentAppliedToFields, paymentAppliedToItemsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Payment), response, "response is Payment");
        }
        
        /// <summary>
        /// Test GetPayment
        /// </summary>
        [Test]
        public void GetPaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string paymentId = null;
            //List<string> fields = null;
            //List<string> accountFields = null;
            //List<string> paymentMethodFields = null;
            //List<string> paymentAppliedToFields = null;
            //List<string> paymentAppliedToItemsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.GetPayment(paymentId, fields, accountFields, paymentMethodFields, paymentAppliedToFields, paymentAppliedToItemsFields, expand, filter, pageSize, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Payment), response, "response is Payment");
        }
        
        /// <summary>
        /// Test GetPayments
        /// </summary>
        [Test]
        public void GetPaymentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cursor = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //List<string> sort = null;
            //int? pageSize = null;
            //List<string> fields = null;
            //List<string> accountFields = null;
            //List<string> paymentMethodFields = null;
            //List<string> paymentAppliedToFields = null;
            //List<string> paymentAppliedToItemsFields = null;
            //string zuoraTrackId = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.GetPayments(cursor, expand, filter, sort, pageSize, fields, accountFields, paymentMethodFields, paymentAppliedToFields, paymentAppliedToItemsFields, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(PaymentListResponse), response, "response is PaymentListResponse");
        }
        
        /// <summary>
        /// Test UnapplyPayment
        /// </summary>
        [Test]
        public void UnapplyPaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string paymentId = null;
            //PaymentApplyUnapplyRequest paymentApplyUnapplyRequest = null;
            //List<string> fields = null;
            //List<string> accountFields = null;
            //List<string> paymentMethodFields = null;
            //List<string> paymentAppliedToFields = null;
            //List<string> paymentAppliedToItemsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.UnapplyPayment(paymentId, paymentApplyUnapplyRequest, fields, accountFields, paymentMethodFields, paymentAppliedToFields, paymentAppliedToItemsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Payment), response, "response is Payment");
        }
        
        /// <summary>
        /// Test UpdatePayment
        /// </summary>
        [Test]
        public void UpdatePaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string paymentId = null;
            //PaymentPatchRequest paymentPatchRequest = null;
            //List<string> fields = null;
            //List<string> accountFields = null;
            //List<string> paymentMethodFields = null;
            //List<string> paymentAppliedToFields = null;
            //List<string> paymentAppliedToItemsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.UpdatePayment(paymentId, paymentPatchRequest, fields, accountFields, paymentMethodFields, paymentAppliedToFields, paymentAppliedToItemsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Payment), response, "response is Payment");
        }
        
    }

}
