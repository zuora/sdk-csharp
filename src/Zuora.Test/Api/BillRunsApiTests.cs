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
    ///  Class for testing BillRunsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BillRunsApiTests
    {
        private BillRunsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BillRunsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillRunsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' BillRunsApi
            //Assert.IsInstanceOf(typeof(BillRunsApi), instance);
        }

        
        /// <summary>
        /// Test CancelBillRun
        /// </summary>
        [Test]
        public void CancelBillRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string billRunId = null;
            //List<string> fields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityId = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.CancelBillRun(billRunId, fields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityId, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(BillRun), response, "response is BillRun");
        }
        
        /// <summary>
        /// Test CreateBillRun
        /// </summary>
        [Test]
        public void CreateBillRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BillRunCreateRequest billRunCreateRequest = null;
            //List<string> fields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.CreateBillRun(billRunCreateRequest, fields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(BillRun), response, "response is BillRun");
        }
        
        /// <summary>
        /// Test DeleteBillRun
        /// </summary>
        [Test]
        public void DeleteBillRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string billRunId = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //instance.DeleteBillRun(billRunId, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            
        }
        
        /// <summary>
        /// Test GetBillRun
        /// </summary>
        [Test]
        public void GetBillRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string billRunId = null;
            //List<string> fields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.GetBillRun(billRunId, fields, expand, filter, pageSize, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(BillRun), response, "response is BillRun");
        }
        
        /// <summary>
        /// Test GetBillRuns
        /// </summary>
        [Test]
        public void GetBillRunsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cursor = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //List<string> sort = null;
            //int? pageSize = null;
            //List<string> fields = null;
            //string zuoraTrackId = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.GetBillRuns(cursor, expand, filter, sort, pageSize, fields, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(BillRunListResponse), response, "response is BillRunListResponse");
        }
        
        /// <summary>
        /// Test PostBillRun
        /// </summary>
        [Test]
        public void PostBillRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string billRunId = null;
            //BillRunPostRequest billRunPostRequest = null;
            //List<string> fields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.PostBillRun(billRunId, billRunPostRequest, fields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(BillRun), response, "response is BillRun");
        }
        
    }

}