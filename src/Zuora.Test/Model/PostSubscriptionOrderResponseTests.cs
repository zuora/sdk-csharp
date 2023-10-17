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
    ///  Class for testing PostSubscriptionOrderResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PostSubscriptionOrderResponseTests
    {
        // TODO uncomment below to declare an instance variable for PostSubscriptionOrderResponse
        //private PostSubscriptionOrderResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PostSubscriptionOrderResponse
            //instance = new PostSubscriptionOrderResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PostSubscriptionOrderResponse
        /// </summary>
        [Test]
        public void PostSubscriptionOrderResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" PostSubscriptionOrderResponse
            //Assert.IsInstanceOf(typeof(PostSubscriptionOrderResponse), instance);
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
        /// Test the property 'subscription_number'
        /// </summary>
        [Test]
        public void subscription_numberTest()
        {
            // TODO unit test for the property 'subscription_number'
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
        /// Test the property 'version'
        /// </summary>
        [Test]
        public void versionTest()
        {
            // TODO unit test for the property 'version'
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
        /// Test the property 'account'
        /// </summary>
        [Test]
        public void accountTest()
        {
            // TODO unit test for the property 'account'
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
        /// Test the property 'invoice_owner_account'
        /// </summary>
        [Test]
        public void invoice_owner_accountTest()
        {
            // TODO unit test for the property 'invoice_owner_account'
        }
        /// <summary>
        /// Test the property 'auto_renew'
        /// </summary>
        [Test]
        public void auto_renewTest()
        {
            // TODO unit test for the property 'auto_renew'
        }
        /// <summary>
        /// Test the property 'latest_version'
        /// </summary>
        [Test]
        public void latest_versionTest()
        {
            // TODO unit test for the property 'latest_version'
        }
        /// <summary>
        /// Test the property 'initial_term'
        /// </summary>
        [Test]
        public void initial_termTest()
        {
            // TODO unit test for the property 'initial_term'
        }
        /// <summary>
        /// Test the property 'current_term'
        /// </summary>
        [Test]
        public void current_termTest()
        {
            // TODO unit test for the property 'current_term'
        }
        /// <summary>
        /// Test the property 'renewal_term'
        /// </summary>
        [Test]
        public void renewal_termTest()
        {
            // TODO unit test for the property 'renewal_term'
        }
        /// <summary>
        /// Test the property 'start_date'
        /// </summary>
        [Test]
        public void start_dateTest()
        {
            // TODO unit test for the property 'start_date'
        }
        /// <summary>
        /// Test the property 'end_date'
        /// </summary>
        [Test]
        public void end_dateTest()
        {
            // TODO unit test for the property 'end_date'
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
        /// Test the property 'contract_effective'
        /// </summary>
        [Test]
        public void contract_effectiveTest()
        {
            // TODO unit test for the property 'contract_effective'
        }
        /// <summary>
        /// Test the property 'service_activation'
        /// </summary>
        [Test]
        public void service_activationTest()
        {
            // TODO unit test for the property 'service_activation'
        }
        /// <summary>
        /// Test the property 'customer_acceptance'
        /// </summary>
        [Test]
        public void customer_acceptanceTest()
        {
            // TODO unit test for the property 'customer_acceptance'
        }
        /// <summary>
        /// Test the property 'invoice_separately'
        /// </summary>
        [Test]
        public void invoice_separatelyTest()
        {
            // TODO unit test for the property 'invoice_separately'
        }
        /// <summary>
        /// Test the property 'order_number'
        /// </summary>
        [Test]
        public void order_numberTest()
        {
            // TODO unit test for the property 'order_number'
        }
        /// <summary>
        /// Test the property 'subscription_plans'
        /// </summary>
        [Test]
        public void subscription_plansTest()
        {
            // TODO unit test for the property 'subscription_plans'
        }
        /// <summary>
        /// Test the property 'invoice_items'
        /// </summary>
        [Test]
        public void invoice_itemsTest()
        {
            // TODO unit test for the property 'invoice_items'
        }
        /// <summary>
        /// Test the property 'prepaid_balance'
        /// </summary>
        [Test]
        public void prepaid_balanceTest()
        {
            // TODO unit test for the property 'prepaid_balance'
        }
        /// <summary>
        /// Test the property 'contracted_mrr'
        /// </summary>
        [Test]
        public void contracted_mrrTest()
        {
            // TODO unit test for the property 'contracted_mrr'
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
        /// Test the property 'bill_to'
        /// </summary>
        [Test]
        public void bill_toTest()
        {
            // TODO unit test for the property 'bill_to'
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
        /// Test the property 'sold_to'
        /// </summary>
        [Test]
        public void sold_toTest()
        {
            // TODO unit test for the property 'sold_to'
        }
        /// <summary>
        /// Test the property 'actions'
        /// </summary>
        [Test]
        public void actionsTest()
        {
            // TODO unit test for the property 'actions'
        }

    }

}