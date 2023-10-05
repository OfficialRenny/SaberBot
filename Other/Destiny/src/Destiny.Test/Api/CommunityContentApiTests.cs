/*
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.18.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Destiny.Client;
using Destiny.Api;
// uncomment below to import models
//using Destiny.Model;

namespace Destiny.Test.Api
{
    /// <summary>
    ///  Class for testing CommunityContentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CommunityContentApiTests : IDisposable
    {
        private CommunityContentApi instance;

        public CommunityContentApiTests()
        {
            instance = new CommunityContentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CommunityContentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CommunityContentApi
            //Assert.IsType<CommunityContentApi>(instance);
        }

        /// <summary>
        /// Test CommunityContentGetCommunityContent
        /// </summary>
        [Fact]
        public void CommunityContentGetCommunityContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int mediaFilter = null;
            //int page = null;
            //int sort = null;
            //var response = instance.CommunityContentGetCommunityContent(mediaFilter, page, sort);
            //Assert.IsType<ForumGetTopicsPaged200Response>(response);
        }
    }
}
