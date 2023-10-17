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
    ///  Class for testing SubscriptionPreviewAccountRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SubscriptionPreviewAccountRequestTests
    {
        // TODO uncomment below to declare an instance variable for SubscriptionPreviewAccountRequest
        //private SubscriptionPreviewAccountRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SubscriptionPreviewAccountRequest
            //instance = new SubscriptionPreviewAccountRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubscriptionPreviewAccountRequest
        /// </summary>
        [Test]
        public void SubscriptionPreviewAccountRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" SubscriptionPreviewAccountRequest
            //Assert.IsInstanceOf(typeof(SubscriptionPreviewAccountRequest), instance);
        }


        /// <summary>
        /// Test the property 'sold_to'
        /// </summary>
        [Test]
        public void sold_toTest()
        {
            // TODO unit test for the property 'sold_to'
        }
        /// <summary>
        /// Test the property 'tax_certificate'
        /// </summary>
        [Test]
        public void tax_certificateTest()
        {
            // TODO unit test for the property 'tax_certificate'
        }
        /// <summary>
        /// Test the property 'bill_cycle_day'
        /// </summary>
        [Test]
        public void bill_cycle_dayTest()
        {
            // TODO unit test for the property 'bill_cycle_day'
        }
        /// <summary>
        /// Test the property 'currency'
        /// </summary>
        [Test]
        public void currencyTest()
        {
            // TODO unit test for the property 'currency'
        }
        /// <summary>
        /// Test the property 'tax_identifier'
        /// </summary>
        [Test]
        public void tax_identifierTest()
        {
            // TODO unit test for the property 'tax_identifier'
        }
        /// <summary>
        /// Test the property 'custom_fields'
        /// </summary>
        [Test]
        public void custom_fieldsTest()
        {
            // TODO unit test for the property 'custom_fields'
        }

    }

}