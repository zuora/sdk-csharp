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
    ///  Class for testing PaymentRun
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PaymentRunTests
    {
        // TODO uncomment below to declare an instance variable for PaymentRun
        //private PaymentRun instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PaymentRun
            //instance = new PaymentRun();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentRun
        /// </summary>
        [Test]
        public void PaymentRunInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" PaymentRun
            //Assert.IsInstanceOf(typeof(PaymentRun), instance);
        }


        /// <summary>
        /// Test the property 'id'
        /// </summary>
        [Test]
        public void idTest()
        {
            // TODO unit test for the property 'id'
        }
        /// <summary>
        /// Test the property 'updated_by_id'
        /// </summary>
        [Test]
        public void updated_by_idTest()
        {
            // TODO unit test for the property 'updated_by_id'
        }
        /// <summary>
        /// Test the property 'updated_time'
        /// </summary>
        [Test]
        public void updated_timeTest()
        {
            // TODO unit test for the property 'updated_time'
        }
        /// <summary>
        /// Test the property 'created_by_id'
        /// </summary>
        [Test]
        public void created_by_idTest()
        {
            // TODO unit test for the property 'created_by_id'
        }
        /// <summary>
        /// Test the property 'created_time'
        /// </summary>
        [Test]
        public void created_timeTest()
        {
            // TODO unit test for the property 'created_time'
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
        /// Test the property 'custom_objects'
        /// </summary>
        [Test]
        public void custom_objectsTest()
        {
            // TODO unit test for the property 'custom_objects'
        }
        /// <summary>
        /// Test the property 'apply_credit_memos'
        /// </summary>
        [Test]
        public void apply_credit_memosTest()
        {
            // TODO unit test for the property 'apply_credit_memos'
        }
        /// <summary>
        /// Test the property 'apply_unapplied_payments'
        /// </summary>
        [Test]
        public void apply_unapplied_paymentsTest()
        {
            // TODO unit test for the property 'apply_unapplied_payments'
        }
        /// <summary>
        /// Test the property 'batch'
        /// </summary>
        [Test]
        public void batchTest()
        {
            // TODO unit test for the property 'batch'
        }
        /// <summary>
        /// Test the property 'consolidate_payment'
        /// </summary>
        [Test]
        public void consolidate_paymentTest()
        {
            // TODO unit test for the property 'consolidate_payment'
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
        /// Test the property 'bill_run_id'
        /// </summary>
        [Test]
        public void bill_run_idTest()
        {
            // TODO unit test for the property 'bill_run_id'
        }
        /// <summary>
        /// Test the property 'collect_payment'
        /// </summary>
        [Test]
        public void collect_paymentTest()
        {
            // TODO unit test for the property 'collect_payment'
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
        /// Test the property 'state_transitions'
        /// </summary>
        [Test]
        public void state_transitionsTest()
        {
            // TODO unit test for the property 'state_transitions'
        }
        /// <summary>
        /// Test the property 'payment_gateway_id'
        /// </summary>
        [Test]
        public void payment_gateway_idTest()
        {
            // TODO unit test for the property 'payment_gateway_id'
        }
        /// <summary>
        /// Test the property 'payment_collection_date'
        /// </summary>
        [Test]
        public void payment_collection_dateTest()
        {
            // TODO unit test for the property 'payment_collection_date'
        }
        /// <summary>
        /// Test the property 'payment_run_number'
        /// </summary>
        [Test]
        public void payment_run_numberTest()
        {
            // TODO unit test for the property 'payment_run_number'
        }
        /// <summary>
        /// Test the property 'payment_run_date'
        /// </summary>
        [Test]
        public void payment_run_dateTest()
        {
            // TODO unit test for the property 'payment_run_date'
        }
        /// <summary>
        /// Test the property 'target_date'
        /// </summary>
        [Test]
        public void target_dateTest()
        {
            // TODO unit test for the property 'target_date'
        }
        /// <summary>
        /// Test the property 'state'
        /// </summary>
        [Test]
        public void stateTest()
        {
            // TODO unit test for the property 'state'
        }
        /// <summary>
        /// Test the property 'summary'
        /// </summary>
        [Test]
        public void summaryTest()
        {
            // TODO unit test for the property 'summary'
        }

    }

}
