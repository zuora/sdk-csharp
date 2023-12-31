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
    ///  Class for testing InvoicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InvoicesApiTests
    {
        private InvoicesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InvoicesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvoicesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' InvoicesApi
            //Assert.IsInstanceOf(typeof(InvoicesApi), instance);
        }

        
        /// <summary>
        /// Test CancelInvoice
        /// </summary>
        [Test]
        public void CancelInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceId = null;
            //List<string> fields = null;
            //List<string> invoiceItemsFields = null;
            //List<string> taxationItemsFields = null;
            //List<string> accountFields = null;
            //List<string> billToFields = null;
            //List<string> lineItemFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityId = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.CancelInvoice(invoiceId, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityId, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Invoice), response, "response is Invoice");
        }
        
        /// <summary>
        /// Test CreateInvoice
        /// </summary>
        [Test]
        public void CreateInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvoiceCreateRequest invoiceCreateRequest = null;
            //List<string> fields = null;
            //List<string> invoiceItemsFields = null;
            //List<string> taxationItemsFields = null;
            //List<string> accountFields = null;
            //List<string> billToFields = null;
            //List<string> lineItemFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.CreateInvoice(invoiceCreateRequest, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Invoice), response, "response is Invoice");
        }
        
        /// <summary>
        /// Test DeleteInvoice
        /// </summary>
        [Test]
        public void DeleteInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceId = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //instance.DeleteInvoice(invoiceId, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            
        }
        
        /// <summary>
        /// Test EmailInvoice
        /// </summary>
        [Test]
        public void EmailInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceId = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityId = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //instance.EmailInvoice(invoiceId, zuoraTrackId, async, zuoraEntityId, idempotencyKey, acceptEncoding, contentEncoding);
            
        }
        
        /// <summary>
        /// Test GetInvoice
        /// </summary>
        [Test]
        public void GetInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceId = null;
            //List<string> fields = null;
            //List<string> invoiceItemsFields = null;
            //List<string> taxationItemsFields = null;
            //List<string> accountFields = null;
            //List<string> billToFields = null;
            //List<string> lineItemFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.GetInvoice(invoiceId, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Invoice), response, "response is Invoice");
        }
        
        /// <summary>
        /// Test GetInvoiceItems
        /// </summary>
        [Test]
        public void GetInvoiceItemsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cursor = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //List<string> sort = null;
            //int? pageSize = null;
            //List<string> fields = null;
            //List<string> taxationItemsFields = null;
            //List<string> lineItemFields = null;
            //string zuoraTrackId = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.GetInvoiceItems(cursor, expand, filter, sort, pageSize, fields, taxationItemsFields, lineItemFields, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(InvoiceItemListResponse), response, "response is InvoiceItemListResponse");
        }
        
        /// <summary>
        /// Test GetInvoices
        /// </summary>
        [Test]
        public void GetInvoicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cursor = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //List<string> sort = null;
            //int? pageSize = null;
            //List<string> fields = null;
            //List<string> invoiceItemsFields = null;
            //List<string> taxationItemsFields = null;
            //List<string> accountFields = null;
            //List<string> billToFields = null;
            //List<string> lineItemFields = null;
            //string zuoraTrackId = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.GetInvoices(cursor, expand, filter, sort, pageSize, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(InvoiceListResponse), response, "response is InvoiceListResponse");
        }
        
        /// <summary>
        /// Test PatchInvoice
        /// </summary>
        [Test]
        public void PatchInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceId = null;
            //InvoicePatchRequest invoicePatchRequest = null;
            //List<string> fields = null;
            //List<string> invoiceItemsFields = null;
            //List<string> taxationItemsFields = null;
            //List<string> accountFields = null;
            //List<string> billToFields = null;
            //List<string> lineItemFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.PatchInvoice(invoiceId, invoicePatchRequest, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Invoice), response, "response is Invoice");
        }
        
        /// <summary>
        /// Test PayInvoice
        /// </summary>
        [Test]
        public void PayInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceId = null;
            //PayInvoiceRequest payInvoiceRequest = null;
            //List<string> fields = null;
            //List<string> invoiceItemsFields = null;
            //List<string> taxationItemsFields = null;
            //List<string> accountFields = null;
            //List<string> billToFields = null;
            //List<string> lineItemFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.PayInvoice(invoiceId, payInvoiceRequest, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Invoice), response, "response is Invoice");
        }
        
        /// <summary>
        /// Test PostInvoice
        /// </summary>
        [Test]
        public void PostInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceId = null;
            //List<string> fields = null;
            //List<string> invoiceItemsFields = null;
            //List<string> taxationItemsFields = null;
            //List<string> accountFields = null;
            //List<string> billToFields = null;
            //List<string> lineItemFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityId = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.PostInvoice(invoiceId, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityId, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Invoice), response, "response is Invoice");
        }
        
        /// <summary>
        /// Test ReverseInvoice
        /// </summary>
        [Test]
        public void ReverseInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceId = null;
            //InvoiceReverseRequest invoiceReverseRequest = null;
            //List<string> fields = null;
            //List<string> invoiceItemsFields = null;
            //List<string> taxationItemsFields = null;
            //List<string> accountFields = null;
            //List<string> billToFields = null;
            //List<string> lineItemFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.ReverseInvoice(invoiceId, invoiceReverseRequest, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Invoice), response, "response is Invoice");
        }
        
        /// <summary>
        /// Test UnpostInvoice
        /// </summary>
        [Test]
        public void UnpostInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceId = null;
            //List<string> fields = null;
            //List<string> invoiceItemsFields = null;
            //List<string> taxationItemsFields = null;
            //List<string> accountFields = null;
            //List<string> billToFields = null;
            //List<string> lineItemFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityId = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.UnpostInvoice(invoiceId, fields, invoiceItemsFields, taxationItemsFields, accountFields, billToFields, lineItemFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityId, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Invoice), response, "response is Invoice");
        }
        
        /// <summary>
        /// Test WriteOffInvoice
        /// </summary>
        [Test]
        public void WriteOffInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string invoiceId = null;
            //WriteOffRequest writeOffRequest = null;
            //List<string> fields = null;
            //List<string> appliedToFields = null;
            //List<string> creditMemoItemsFields = null;
            //List<string> taxationItemsFields = null;
            //List<string> accountFields = null;
            //List<string> billToFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.WriteOffInvoice(invoiceId, writeOffRequest, fields, appliedToFields, creditMemoItemsFields, taxationItemsFields, accountFields, billToFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(CreditMemo), response, "response is CreditMemo");
        }
        
    }

}
