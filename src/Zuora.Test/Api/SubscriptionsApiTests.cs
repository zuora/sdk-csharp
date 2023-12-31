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
    ///  Class for testing SubscriptionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SubscriptionsApiTests
    {
        private SubscriptionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SubscriptionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubscriptionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' SubscriptionsApi
            //Assert.IsInstanceOf(typeof(SubscriptionsApi), instance);
        }

        
        /// <summary>
        /// Test ActivateSubscription
        /// </summary>
        [Test]
        public void ActivateSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //SubscriptionActivateRequest subscriptionActivateRequest = null;
            //List<string> fields = null;
            //List<string> subscriptionPlansFields = null;
            //List<string> subscriptionItemsFields = null;
            //List<string> accountFields = null;
            //List<string> invoiceOwnerAccountFields = null;
            //List<string> planFields = null;
            //List<string> productFields = null;
            //List<string> priceFields = null;
            //List<string> billToFields = null;
            //List<string> prepaidBalanceFields = null;
            //List<string> transactionsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.ActivateSubscription(subscriptionId, subscriptionActivateRequest, fields, subscriptionPlansFields, subscriptionItemsFields, accountFields, invoiceOwnerAccountFields, planFields, productFields, priceFields, billToFields, prepaidBalanceFields, transactionsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Subscription), response, "response is Subscription");
        }
        
        /// <summary>
        /// Test CancelSubscription
        /// </summary>
        [Test]
        public void CancelSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //CancelSubscriptionRequest cancelSubscriptionRequest = null;
            //List<string> fields = null;
            //List<string> subscriptionPlansFields = null;
            //List<string> subscriptionItemsFields = null;
            //List<string> accountFields = null;
            //List<string> invoiceOwnerAccountFields = null;
            //List<string> planFields = null;
            //List<string> productFields = null;
            //List<string> priceFields = null;
            //List<string> billToFields = null;
            //List<string> prepaidBalanceFields = null;
            //List<string> transactionsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.CancelSubscription(subscriptionId, cancelSubscriptionRequest, fields, subscriptionPlansFields, subscriptionItemsFields, accountFields, invoiceOwnerAccountFields, planFields, productFields, priceFields, billToFields, prepaidBalanceFields, transactionsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Subscription), response, "response is Subscription");
        }
        
        /// <summary>
        /// Test CreateSubscription
        /// </summary>
        [Test]
        public void CreateSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubscriptionCreateRequest subscriptionCreateRequest = null;
            //List<string> fields = null;
            //List<string> subscriptionPlansFields = null;
            //List<string> subscriptionItemsFields = null;
            //List<string> accountFields = null;
            //List<string> invoiceOwnerAccountFields = null;
            //List<string> planFields = null;
            //List<string> productFields = null;
            //List<string> priceFields = null;
            //List<string> billToFields = null;
            //List<string> prepaidBalanceFields = null;
            //List<string> transactionsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.CreateSubscription(subscriptionCreateRequest, fields, subscriptionPlansFields, subscriptionItemsFields, accountFields, invoiceOwnerAccountFields, planFields, productFields, priceFields, billToFields, prepaidBalanceFields, transactionsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Subscription), response, "response is Subscription");
        }
        
        /// <summary>
        /// Test GetSubscriptionByKey
        /// </summary>
        [Test]
        public void GetSubscriptionByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //List<string> fields = null;
            //List<string> subscriptionPlansFields = null;
            //List<string> subscriptionItemsFields = null;
            //List<string> accountFields = null;
            //List<string> invoiceOwnerAccountFields = null;
            //List<string> planFields = null;
            //List<string> productFields = null;
            //List<string> priceFields = null;
            //List<string> billToFields = null;
            //List<string> prepaidBalanceFields = null;
            //List<string> transactionsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.GetSubscriptionByKey(subscriptionId, fields, subscriptionPlansFields, subscriptionItemsFields, accountFields, invoiceOwnerAccountFields, planFields, productFields, priceFields, billToFields, prepaidBalanceFields, transactionsFields, expand, filter, pageSize, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Subscription), response, "response is Subscription");
        }
        
        /// <summary>
        /// Test GetSubscriptionByVersion
        /// </summary>
        [Test]
        public void GetSubscriptionByVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //List<string> fields = null;
            //List<string> subscriptionPlansFields = null;
            //List<string> subscriptionItemsFields = null;
            //List<string> accountFields = null;
            //List<string> invoiceOwnerAccountFields = null;
            //List<string> planFields = null;
            //List<string> productFields = null;
            //List<string> priceFields = null;
            //List<string> billToFields = null;
            //List<string> prepaidBalanceFields = null;
            //List<string> transactionsFields = null;
            //List<string> actionsFields = null;
            //string cursor = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //List<string> sort = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.GetSubscriptionByVersion(subscriptionId, fields, subscriptionPlansFields, subscriptionItemsFields, accountFields, invoiceOwnerAccountFields, planFields, productFields, priceFields, billToFields, prepaidBalanceFields, transactionsFields, actionsFields, cursor, expand, filter, sort, pageSize, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(SubscriptionVersionListResponse), response, "response is SubscriptionVersionListResponse");
        }
        
        /// <summary>
        /// Test GetSubscriptions
        /// </summary>
        [Test]
        public void GetSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cursor = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //List<string> sort = null;
            //int? pageSize = null;
            //List<string> fields = null;
            //List<string> subscriptionPlansFields = null;
            //List<string> subscriptionItemsFields = null;
            //List<string> accountFields = null;
            //List<string> invoiceOwnerAccountFields = null;
            //List<string> planFields = null;
            //List<string> productFields = null;
            //List<string> priceFields = null;
            //List<string> billToFields = null;
            //List<string> prepaidBalanceFields = null;
            //List<string> transactionsFields = null;
            //string zuoraTrackId = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.GetSubscriptions(cursor, expand, filter, sort, pageSize, fields, subscriptionPlansFields, subscriptionItemsFields, accountFields, invoiceOwnerAccountFields, planFields, productFields, priceFields, billToFields, prepaidBalanceFields, transactionsFields, zuoraTrackId, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(SubscriptionListResponse), response, "response is SubscriptionListResponse");
        }
        
        /// <summary>
        /// Test PatchSubscription
        /// </summary>
        [Test]
        public void PatchSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //SubscriptionPatchRequest subscriptionPatchRequest = null;
            //List<string> fields = null;
            //List<string> subscriptionPlansFields = null;
            //List<string> subscriptionItemsFields = null;
            //List<string> accountFields = null;
            //List<string> invoiceOwnerAccountFields = null;
            //List<string> planFields = null;
            //List<string> productFields = null;
            //List<string> priceFields = null;
            //List<string> billToFields = null;
            //List<string> prepaidBalanceFields = null;
            //List<string> transactionsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.PatchSubscription(subscriptionId, subscriptionPatchRequest, fields, subscriptionPlansFields, subscriptionItemsFields, accountFields, invoiceOwnerAccountFields, planFields, productFields, priceFields, billToFields, prepaidBalanceFields, transactionsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Subscription), response, "response is Subscription");
        }
        
        /// <summary>
        /// Test PauseSubscription
        /// </summary>
        [Test]
        public void PauseSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //PauseSubscriptionRequest pauseSubscriptionRequest = null;
            //List<string> fields = null;
            //List<string> subscriptionPlansFields = null;
            //List<string> subscriptionItemsFields = null;
            //List<string> accountFields = null;
            //List<string> invoiceOwnerAccountFields = null;
            //List<string> planFields = null;
            //List<string> productFields = null;
            //List<string> priceFields = null;
            //List<string> billToFields = null;
            //List<string> prepaidBalanceFields = null;
            //List<string> transactionsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.PauseSubscription(subscriptionId, pauseSubscriptionRequest, fields, subscriptionPlansFields, subscriptionItemsFields, accountFields, invoiceOwnerAccountFields, planFields, productFields, priceFields, billToFields, prepaidBalanceFields, transactionsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Subscription), response, "response is Subscription");
        }
        
        /// <summary>
        /// Test PreviewExistingSubscription
        /// </summary>
        [Test]
        public void PreviewExistingSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //SubscriptionPreviewExistingRequest subscriptionPreviewExistingRequest = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.PreviewExistingSubscription(subscriptionId, subscriptionPreviewExistingRequest, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(SubscriptionPreviewResponse), response, "response is SubscriptionPreviewResponse");
        }
        
        /// <summary>
        /// Test PreviewSubscription
        /// </summary>
        [Test]
        public void PreviewSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubscriptionPreviewRequest subscriptionPreviewRequest = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.PreviewSubscription(subscriptionPreviewRequest, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(SubscriptionPreviewResponse), response, "response is SubscriptionPreviewResponse");
        }
        
        /// <summary>
        /// Test ResumeSubscription
        /// </summary>
        [Test]
        public void ResumeSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //ResumeSubscriptionRequest resumeSubscriptionRequest = null;
            //List<string> fields = null;
            //List<string> subscriptionPlansFields = null;
            //List<string> subscriptionItemsFields = null;
            //List<string> accountFields = null;
            //List<string> invoiceOwnerAccountFields = null;
            //List<string> planFields = null;
            //List<string> productFields = null;
            //List<string> priceFields = null;
            //List<string> billToFields = null;
            //List<string> prepaidBalanceFields = null;
            //List<string> transactionsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.ResumeSubscription(subscriptionId, resumeSubscriptionRequest, fields, subscriptionPlansFields, subscriptionItemsFields, accountFields, invoiceOwnerAccountFields, planFields, productFields, priceFields, billToFields, prepaidBalanceFields, transactionsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Subscription), response, "response is Subscription");
        }
        
        /// <summary>
        /// Test UncancelSubscription
        /// </summary>
        [Test]
        public void UncancelSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //SubscriptionPatchRequest subscriptionPatchRequest = null;
            //List<string> fields = null;
            //List<string> subscriptionPlansFields = null;
            //List<string> subscriptionItemsFields = null;
            //List<string> accountFields = null;
            //List<string> invoiceOwnerAccountFields = null;
            //List<string> planFields = null;
            //List<string> productFields = null;
            //List<string> priceFields = null;
            //List<string> billToFields = null;
            //List<string> prepaidBalanceFields = null;
            //List<string> transactionsFields = null;
            //List<string> expand = null;
            //List<string> filter = null;
            //int? pageSize = null;
            //string zuoraTrackId = null;
            //bool? async = null;
            //string zuoraEntityIds = null;
            //string idempotencyKey = null;
            //string acceptEncoding = null;
            //string contentEncoding = null;
            //var response = instance.UncancelSubscription(subscriptionId, subscriptionPatchRequest, fields, subscriptionPlansFields, subscriptionItemsFields, accountFields, invoiceOwnerAccountFields, planFields, productFields, priceFields, billToFields, prepaidBalanceFields, transactionsFields, expand, filter, pageSize, zuoraTrackId, async, zuoraEntityIds, idempotencyKey, acceptEncoding, contentEncoding);
            //Assert.IsInstanceOf(typeof(Subscription), response, "response is Subscription");
        }
        
    }

}
