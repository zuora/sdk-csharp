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
    ///  Class for testing PaymentRunsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PaymentRunsApiTests
    {
        private PaymentRunsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PaymentRunsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentRunsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' PaymentRunsApi
            //Assert.IsInstanceOf(typeof(PaymentRunsApi), instance);
        }

        
        /// <summary>
        /// Test CreatePaymentRuns
        /// </summary>
        [Test]
        public void CreatePaymentRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PaymentRunCreateRequest paymentRunCreateRequest = null;
            //List<string> fields = null;
            //List<string> summaryFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.CreatePaymentRuns(paymentRunCreateRequest, fields, summaryFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(PaymentRun), response, "response is PaymentRun");
        }
        
        /// <summary>
        /// Test DeletePaymentRuns
        /// </summary>
        [Test]
        public void DeletePaymentRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string paymentRunId = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //instance.DeletePaymentRuns(paymentRunId, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            
        }
        
        /// <summary>
        /// Test GetPaymentRun
        /// </summary>
        [Test]
        public void GetPaymentRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string paymentRunId = null;
            //List<string> fields = null;
            //List<string> summaryFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.GetPaymentRun(paymentRunId, fields, summaryFields, expand, filter, pageSize, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(PaymentRun), response, "response is PaymentRun");
        }
        
        /// <summary>
        /// Test GetPaymentRuns
        /// </summary>
        [Test]
        public void GetPaymentRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cursor = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //List<string> sort = null;
            //int? pageSize = null;
            //List<string> fields = null;
            //List<string> summaryFields = null;
            //string zuoraTrackId = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.GetPaymentRuns(cursor, expand, filter, sort, pageSize, fields, summaryFields, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(PaymentRunListResponse), response, "response is PaymentRunListResponse");
        }
        
        /// <summary>
        /// Test UpdatePaymentRuns
        /// </summary>
        [Test]
        public void UpdatePaymentRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string paymentRunId = null;
            //PaymentRunPatchRequest paymentRunPatchRequest = null;
            //List<string> fields = null;
            //List<string> summaryFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.UpdatePaymentRuns(paymentRunId, paymentRunPatchRequest, fields, summaryFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(PaymentRun), response, "response is PaymentRun");
        }
        
    }

}
