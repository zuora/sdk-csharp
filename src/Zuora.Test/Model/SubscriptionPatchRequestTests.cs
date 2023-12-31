/*
 * Quickstart API Reference
 *
 * Zuora Quickstart API is recommended for new customers and integrators, allowing new integrators to swiftly integrate with Zuora. It supports essential business use cases.   To use the Quickstart API, you must have the following features enabled on your tenant:   * [Orders](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders) or [Orders Harmonization](https://knowledgecenter.zuora.com/Billing/Subscriptions/Orders/Orders_Harmonization)  * [Invoice Settlement](https://knowledgecenter.zuora.com/Billing/Billing_and_Payments/Invoice_Settlement)  To find the latest changes made to the Zuora Quickstart API, check the [Quickstart API Changelog](https://www.zuora.com/developer/quickstart-api/changelog/2022q4-changelog/).  We recommend that you subscribe to [Developers Community](https://community.zuora.com/communities/community-home?communitykey=e2a932b4-50c4-4019-a3e8-362e38714df3) to get notifications when a new version is released.  
 *
 * The version of the OpenAPI document: 2023-09-25
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Zuora.Api;
using Zuora.Model;
using Zuora.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Zuora.Test
{
    /// <summary>
    ///  Class for testing SubscriptionPatchRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SubscriptionPatchRequestTests
    {
        // TODO uncomment below to declare an instance variable for SubscriptionPatchRequest
        //private SubscriptionPatchRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SubscriptionPatchRequest
            //instance = new SubscriptionPatchRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubscriptionPatchRequest
        /// </summary>
        [Test]
        public void SubscriptionPatchRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" SubscriptionPatchRequest
            //Assert.IsInstanceOf(typeof(SubscriptionPatchRequest), instance);
        }


        /// <summary>
        /// Test the property 'description'
        /// </summary>
        [Test]
        public void descriptionTest()
        {
            // TODO unit test for the property 'description'
        }
        /// <summary>
        /// Test the property 'custom_fields'
        /// </summary>
        [Test]
        public void custom_fieldsTest()
        {
            // TODO unit test for the property 'custom_fields'
        }
        /// <summary>
        /// Test the property 'terms'
        /// </summary>
        [Test]
        public void termsTest()
        {
            // TODO unit test for the property 'terms'
        }
        /// <summary>
        /// Test the property 'invoice_owner_account_id'
        /// </summary>
        [Test]
        public void invoice_owner_account_idTest()
        {
            // TODO unit test for the property 'invoice_owner_account_id'
        }
        /// <summary>
        /// Test the property 'invoice_owner_account_number'
        /// </summary>
        [Test]
        public void invoice_owner_account_numberTest()
        {
            // TODO unit test for the property 'invoice_owner_account_number'
        }
        /// <summary>
        /// Test the property 'account_id'
        /// </summary>
        [Test]
        public void account_idTest()
        {
            // TODO unit test for the property 'account_id'
        }
        /// <summary>
        /// Test the property 'account_number'
        /// </summary>
        [Test]
        public void account_numberTest()
        {
            // TODO unit test for the property 'account_number'
        }
        /// <summary>
        /// Test the property 'add_subscription_plans'
        /// </summary>
        [Test]
        public void add_subscription_plansTest()
        {
            // TODO unit test for the property 'add_subscription_plans'
        }
        /// <summary>
        /// Test the property 'remove_subscription_plans'
        /// </summary>
        [Test]
        public void remove_subscription_plansTest()
        {
            // TODO unit test for the property 'remove_subscription_plans'
        }
        /// <summary>
        /// Test the property 'replace_subscription_plans'
        /// </summary>
        [Test]
        public void replace_subscription_plansTest()
        {
            // TODO unit test for the property 'replace_subscription_plans'
        }
        /// <summary>
        /// Test the property 'update_subscription_plans'
        /// </summary>
        [Test]
        public void update_subscription_plansTest()
        {
            // TODO unit test for the property 'update_subscription_plans'
        }
        /// <summary>
        /// Test the property 'renew'
        /// </summary>
        [Test]
        public void renewTest()
        {
            // TODO unit test for the property 'renew'
        }
        /// <summary>
        /// Test the property 'cancel'
        /// </summary>
        [Test]
        public void cancelTest()
        {
            // TODO unit test for the property 'cancel'
        }
        /// <summary>
        /// Test the property 'pause'
        /// </summary>
        [Test]
        public void pauseTest()
        {
            // TODO unit test for the property 'pause'
        }
        /// <summary>
        /// Test the property 'resume'
        /// </summary>
        [Test]
        public void resumeTest()
        {
            // TODO unit test for the property 'resume'
        }
        /// <summary>
        /// Test the property 'bill_to_id'
        /// </summary>
        [Test]
        public void bill_to_idTest()
        {
            // TODO unit test for the property 'bill_to_id'
        }
        /// <summary>
        /// Test the property 'payment_terms'
        /// </summary>
        [Test]
        public void payment_termsTest()
        {
            // TODO unit test for the property 'payment_terms'
        }
        /// <summary>
        /// Test the property 'billing_document_settings'
        /// </summary>
        [Test]
        public void billing_document_settingsTest()
        {
            // TODO unit test for the property 'billing_document_settings'
        }
        /// <summary>
        /// Test the property 'sold_to_id'
        /// </summary>
        [Test]
        public void sold_to_idTest()
        {
            // TODO unit test for the property 'sold_to_id'
        }
        /// <summary>
        /// Test the property 'invoice_separately'
        /// </summary>
        [Test]
        public void invoice_separatelyTest()
        {
            // TODO unit test for the property 'invoice_separately'
        }

    }

}
