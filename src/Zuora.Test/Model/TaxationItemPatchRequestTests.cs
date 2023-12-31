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
    ///  Class for testing TaxationItemPatchRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TaxationItemPatchRequestTests
    {
        // TODO uncomment below to declare an instance variable for TaxationItemPatchRequest
        //private TaxationItemPatchRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TaxationItemPatchRequest
            //instance = new TaxationItemPatchRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TaxationItemPatchRequest
        /// </summary>
        [Test]
        public void TaxationItemPatchRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" TaxationItemPatchRequest
            //Assert.IsInstanceOf(typeof(TaxationItemPatchRequest), instance);
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
        /// Test the property 'on_account_account'
        /// </summary>
        [Test]
        public void on_account_accountTest()
        {
            // TODO unit test for the property 'on_account_account'
        }
        /// <summary>
        /// Test the property 'amount_exempt'
        /// </summary>
        [Test]
        public void amount_exemptTest()
        {
            // TODO unit test for the property 'amount_exempt'
        }
        /// <summary>
        /// Test the property 'invoice_item_id'
        /// </summary>
        [Test]
        public void invoice_item_idTest()
        {
            // TODO unit test for the property 'invoice_item_id'
        }
        /// <summary>
        /// Test the property 'jurisdiction'
        /// </summary>
        [Test]
        public void jurisdictionTest()
        {
            // TODO unit test for the property 'jurisdiction'
        }
        /// <summary>
        /// Test the property 'location_code'
        /// </summary>
        [Test]
        public void location_codeTest()
        {
            // TODO unit test for the property 'location_code'
        }
        /// <summary>
        /// Test the property 'name'
        /// </summary>
        [Test]
        public void nameTest()
        {
            // TODO unit test for the property 'name'
        }
        /// <summary>
        /// Test the property 'amount'
        /// </summary>
        [Test]
        public void amountTest()
        {
            // TODO unit test for the property 'amount'
        }
        /// <summary>
        /// Test the property 'tax_code'
        /// </summary>
        [Test]
        public void tax_codeTest()
        {
            // TODO unit test for the property 'tax_code'
        }
        /// <summary>
        /// Test the property 'tax_code_name'
        /// </summary>
        [Test]
        public void tax_code_nameTest()
        {
            // TODO unit test for the property 'tax_code_name'
        }
        /// <summary>
        /// Test the property 'tax_date'
        /// </summary>
        [Test]
        public void tax_dateTest()
        {
            // TODO unit test for the property 'tax_date'
        }
        /// <summary>
        /// Test the property 'tax_rate'
        /// </summary>
        [Test]
        public void tax_rateTest()
        {
            // TODO unit test for the property 'tax_rate'
        }
        /// <summary>
        /// Test the property 'tax_rate_name'
        /// </summary>
        [Test]
        public void tax_rate_nameTest()
        {
            // TODO unit test for the property 'tax_rate_name'
        }
        /// <summary>
        /// Test the property 'tax_rate_type'
        /// </summary>
        [Test]
        public void tax_rate_typeTest()
        {
            // TODO unit test for the property 'tax_rate_type'
        }
        /// <summary>
        /// Test the property 'source_tax_item_id'
        /// </summary>
        [Test]
        public void source_tax_item_idTest()
        {
            // TODO unit test for the property 'source_tax_item_id'
        }
        /// <summary>
        /// Test the property 'tax_inclusive'
        /// </summary>
        [Test]
        public void tax_inclusiveTest()
        {
            // TODO unit test for the property 'tax_inclusive'
        }
        /// <summary>
        /// Test the property 'sales_tax_payable_account'
        /// </summary>
        [Test]
        public void sales_tax_payable_accountTest()
        {
            // TODO unit test for the property 'sales_tax_payable_account'
        }

    }

}
