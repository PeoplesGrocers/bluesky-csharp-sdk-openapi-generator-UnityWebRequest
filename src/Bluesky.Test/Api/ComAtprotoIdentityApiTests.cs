/*
 * AT Protocol XRPC API
 *
 * This section contains HTTP API reference docs for Bluesky and AT Protocol lexicons. Generate a bearer token to test API calls directly from the docs.
 *
 * The version of the OpenAPI document: 0.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

using Bluesky.Client;
using Bluesky.Api;
// uncomment below to import models
//using Bluesky.Model;

namespace Bluesky.Test.Api
{
    /// <summary>
    ///  Class for testing ComAtprotoIdentityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ComAtprotoIdentityApiTests : IDisposable
    {
        private ComAtprotoIdentityApi instance;

        public ComAtprotoIdentityApiTests()
        {
            instance = new ComAtprotoIdentityApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ComAtprotoIdentityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ComAtprotoIdentityApi
            //Assert.IsType<ComAtprotoIdentityApi>(instance);
        }

        /// <summary>
        /// Test ComAtprotoIdentityGetRecommendedDidCredentials
        /// </summary>
        [Test]
        public void ComAtprotoIdentityGetRecommendedDidCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ComAtprotoIdentityGetRecommendedDidCredentials();
            //Assert.IsType<ComAtprotoIdentityGetRecommendedDidCredentials200Response>(response);
        }

        /// <summary>
        /// Test ComAtprotoIdentityRequestPlcOperationSignature
        /// </summary>
        [Test]
        public void ComAtprotoIdentityRequestPlcOperationSignatureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.ComAtprotoIdentityRequestPlcOperationSignature();
        }

        /// <summary>
        /// Test ComAtprotoIdentityResolveHandle
        /// </summary>
        [Test]
        public void ComAtprotoIdentityResolveHandleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string handle = null;
            //var response = instance.ComAtprotoIdentityResolveHandle(handle);
            //Assert.IsType<ComAtprotoAdminDeleteAccountRequest>(response);
        }

        /// <summary>
        /// Test ComAtprotoIdentitySignPlcOperation
        /// </summary>
        [Test]
        public void ComAtprotoIdentitySignPlcOperationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ComAtprotoIdentitySignPlcOperationRequest comAtprotoIdentitySignPlcOperationRequest = null;
            //var response = instance.ComAtprotoIdentitySignPlcOperation(comAtprotoIdentitySignPlcOperationRequest);
            //Assert.IsType<ComAtprotoIdentitySignPlcOperation200Response>(response);
        }

        /// <summary>
        /// Test ComAtprotoIdentitySubmitPlcOperation
        /// </summary>
        [Test]
        public void ComAtprotoIdentitySubmitPlcOperationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ComAtprotoIdentitySignPlcOperation200Response comAtprotoIdentitySignPlcOperation200Response = null;
            //instance.ComAtprotoIdentitySubmitPlcOperation(comAtprotoIdentitySignPlcOperation200Response);
        }

        /// <summary>
        /// Test ComAtprotoIdentityUpdateHandle
        /// </summary>
        [Test]
        public void ComAtprotoIdentityUpdateHandleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ComAtprotoIdentityUpdateHandleRequest comAtprotoIdentityUpdateHandleRequest = null;
            //instance.ComAtprotoIdentityUpdateHandle(comAtprotoIdentityUpdateHandleRequest);
        }
    }
}
