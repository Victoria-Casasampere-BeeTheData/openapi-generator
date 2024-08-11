/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing FakeApi
    /// </summary>
    public sealed class FakeApiTests : ApiTestsBase
    {
        private readonly IFakeApi _instance;

        public FakeApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IFakeApi>();
        }

        /// <summary>
        /// Test FakeHealthGet
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task FakeHealthGetAsyncTest()
        {
            var response = await _instance.FakeHealthGetAsync();
            var model = response.Ok();
            Assert.IsType<HealthCheckResult>(model);
        }

        /// <summary>
        /// Test FakeOuterBooleanSerialize
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task FakeOuterBooleanSerializeAsyncTest()
        {
            Client.Option<bool> body = default;
            var response = await _instance.FakeOuterBooleanSerializeAsync(body);
            var model = response.Ok();
            Assert.IsType<bool>(model);
        }

        /// <summary>
        /// Test FakeOuterCompositeSerialize
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task FakeOuterCompositeSerializeAsyncTest()
        {
            Client.Option<OuterComposite> outerComposite = default;
            var response = await _instance.FakeOuterCompositeSerializeAsync(outerComposite);
            var model = response.Ok();
            Assert.IsType<OuterComposite>(model);
        }

        /// <summary>
        /// Test FakeOuterNumberSerialize
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task FakeOuterNumberSerializeAsyncTest()
        {
            Client.Option<decimal> body = default;
            var response = await _instance.FakeOuterNumberSerializeAsync(body);
            var model = response.Ok();
            Assert.IsType<decimal>(model);
        }

        /// <summary>
        /// Test FakeOuterStringSerialize
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task FakeOuterStringSerializeAsyncTest()
        {
            Guid requiredStringUuid = default;
            Client.Option<string> body = default;
            var response = await _instance.FakeOuterStringSerializeAsync(requiredStringUuid, body);
            var model = response.Ok();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test GetArrayOfEnums
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetArrayOfEnumsAsyncTest()
        {
            var response = await _instance.GetArrayOfEnumsAsync();
            var model = response.Ok();
            Assert.IsType<List<OuterEnum>>(model);
        }

        /// <summary>
        /// Test GetMixedAnyOf
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetMixedAnyOfAsyncTest()
        {
            var response = await _instance.GetMixedAnyOfAsync();
            var model = response.Ok();
            Assert.IsType<MixedAnyOf>(model);
        }

        /// <summary>
        /// Test GetMixedOneOf
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetMixedOneOfAsyncTest()
        {
            var response = await _instance.GetMixedOneOfAsync();
            var model = response.Ok();
            Assert.IsType<MixedOneOf>(model);
        }

        /// <summary>
        /// Test TestAdditionalPropertiesReference
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestAdditionalPropertiesReferenceAsyncTest()
        {
            Dictionary<string, Object> requestBody = default;
            await _instance.TestAdditionalPropertiesReferenceAsync(requestBody);
        }

        /// <summary>
        /// Test TestBodyWithFileSchema
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestBodyWithFileSchemaAsyncTest()
        {
            FileSchemaTestClass fileSchemaTestClass = default;
            await _instance.TestBodyWithFileSchemaAsync(fileSchemaTestClass);
        }

        /// <summary>
        /// Test TestBodyWithQueryParams
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestBodyWithQueryParamsAsyncTest()
        {
            string query = default;
            User user = default;
            await _instance.TestBodyWithQueryParamsAsync(query, user);
        }

        /// <summary>
        /// Test TestClientModel
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestClientModelAsyncTest()
        {
            ModelClient modelClient = default;
            var response = await _instance.TestClientModelAsync(modelClient);
            var model = response.Ok();
            Assert.IsType<ModelClient>(model);
        }

        /// <summary>
        /// Test TestEndpointParameters
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestEndpointParametersAsyncTest()
        {
            decimal number = default;
            double varDouble = default;
            string patternWithoutDelimiter = default;
            byte[] varByte = default;
            Client.Option<int> integer = default;
            Client.Option<int> int32 = default;
            Client.Option<long> int64 = default;
            Client.Option<float> varFloat = default;
            Client.Option<string> varString = default;
            Client.Option<System.IO.Stream> binary = default;
            Client.Option<DateTime> date = default;
            Client.Option<DateTime> dateTime = default;
            Client.Option<string> password = default;
            Client.Option<string> callback = default;
            await _instance.TestEndpointParametersAsync(number, varDouble, patternWithoutDelimiter, varByte, integer, int32, int64, varFloat, varString, binary, date, dateTime, password, callback);
        }

        /// <summary>
        /// Test TestEnumParameters
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestEnumParametersAsyncTest()
        {
            Client.Option<List<TestEnumParametersRequestEnumFormStringArrayInner>> enumHeaderStringArray = default;
            Client.Option<TestEnumParametersEnumHeaderStringParameter> enumHeaderString = default;
            Client.Option<List<TestEnumParametersRequestEnumFormStringArrayInner>> enumQueryStringArray = default;
            Client.Option<TestEnumParametersEnumHeaderStringParameter> enumQueryString = default;
            Client.Option<TestEnumParametersEnumQueryIntegerParameter> enumQueryInteger = default;
            Client.Option<TestEnumParametersEnumQueryDoubleParameter> enumQueryDouble = default;
            Client.Option<List<TestEnumParametersRequestEnumFormStringArrayInner>> enumFormStringArray = default;
            Client.Option<TestEnumParametersRequestEnumFormString> enumFormString = default;
            await _instance.TestEnumParametersAsync(enumHeaderStringArray, enumHeaderString, enumQueryStringArray, enumQueryString, enumQueryInteger, enumQueryDouble, enumFormStringArray, enumFormString);
        }

        /// <summary>
        /// Test TestGroupParameters
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestGroupParametersAsyncTest()
        {
            int requiredStringGroup = default;
            bool requiredBooleanGroup = default;
            long requiredInt64Group = default;
            Client.Option<int> stringGroup = default;
            Client.Option<bool> booleanGroup = default;
            Client.Option<long> int64Group = default;
            await _instance.TestGroupParametersAsync(requiredStringGroup, requiredBooleanGroup, requiredInt64Group, stringGroup, booleanGroup, int64Group);
        }

        /// <summary>
        /// Test TestInlineAdditionalProperties
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestInlineAdditionalPropertiesAsyncTest()
        {
            Dictionary<string, string> requestBody = default;
            await _instance.TestInlineAdditionalPropertiesAsync(requestBody);
        }

        /// <summary>
        /// Test TestInlineFreeformAdditionalProperties
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestInlineFreeformAdditionalPropertiesAsyncTest()
        {
            TestInlineFreeformAdditionalPropertiesRequest testInlineFreeformAdditionalPropertiesRequest = default;
            await _instance.TestInlineFreeformAdditionalPropertiesAsync(testInlineFreeformAdditionalPropertiesRequest);
        }

        /// <summary>
        /// Test TestJsonFormData
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestJsonFormDataAsyncTest()
        {
            string param = default;
            string param2 = default;
            await _instance.TestJsonFormDataAsync(param, param2);
        }

        /// <summary>
        /// Test TestQueryParameterCollectionFormat
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestQueryParameterCollectionFormatAsyncTest()
        {
            List<string> pipe = default;
            List<string> ioutil = default;
            List<string> http = default;
            List<string> url = default;
            List<string> context = default;
            string requiredNotNullable = default;
            string requiredNullable = default;
            Client.Option<string> notRequiredNotNullable = default;
            Client.Option<string> notRequiredNullable = default;
            await _instance.TestQueryParameterCollectionFormatAsync(pipe, ioutil, http, url, context, requiredNotNullable, requiredNullable, notRequiredNotNullable, notRequiredNullable);
        }

        /// <summary>
        /// Test TestStringMapReference
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TestStringMapReferenceAsyncTest()
        {
            Dictionary<string, string> requestBody = default;
            await _instance.TestStringMapReferenceAsync(requestBody);
        }
    }
}
