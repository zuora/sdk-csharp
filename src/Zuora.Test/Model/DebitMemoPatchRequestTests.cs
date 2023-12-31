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
    ///  Class for testing DebitMemoPatchRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DebitMemoPatchRequestTests
    {
        // TODO uncomment below to declare an instance variable for DebitMemoPatchRequest
        //private DebitMemoPatchRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DebitMemoPatchRequest
            //instance = new DebitMemoPatchRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DebitMemoPatchRequest
        /// </summary>
        [Test]
        public void DebitMemoPatchRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" DebitMemoPatchRequest
            //Assert.IsInstanceOf(typeof(DebitMemoPatchRequest), instance);
        }


        /// <summary>
        /// Test the property 'pay'
        /// </summary>
        [Test]
        public void payTest()
        {
            // TODO unit test for the property 'pay'
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
        /// Test the property 'due_date'
        /// </summary>
        [Test]
        public void due_dateTest()
        {
            // TODO unit test for the property 'due_date'
        }
        /// <summary>
        /// Test the property 'document_date'
        /// </summary>
        [Test]
        public void document_dateTest()
        {
            // TODO unit test for the property 'document_date'
        }
        /// <summary>
        /// Test the property 'reason_code'
        /// </summary>
        [Test]
        public void reason_codeTest()
        {
            // TODO unit test for the property 'reason_code'
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
