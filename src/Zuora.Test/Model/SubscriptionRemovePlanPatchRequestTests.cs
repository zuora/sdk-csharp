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
    ///  Class for testing SubscriptionRemovePlanPatchRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SubscriptionRemovePlanPatchRequestTests
    {
        // TODO uncomment below to declare an instance variable for SubscriptionRemovePlanPatchRequest
        //private SubscriptionRemovePlanPatchRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of SubscriptionRemovePlanPatchRequest
            //instance = new SubscriptionRemovePlanPatchRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SubscriptionRemovePlanPatchRequest
        /// </summary>
        [Test]
        public void SubscriptionRemovePlanPatchRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" SubscriptionRemovePlanPatchRequest
            //Assert.IsInstanceOf(typeof(SubscriptionRemovePlanPatchRequest), instance);
        }


        /// <summary>
        /// Test the property 'subscription_plan_id'
        /// </summary>
        [Test]
        public void subscription_plan_idTest()
        {
            // TODO unit test for the property 'subscription_plan_id'
        }
        /// <summary>
        /// Test the property 'start_on'
        /// </summary>
        [Test]
        public void start_onTest()
        {
            // TODO unit test for the property 'start_on'
        }

    }

}
