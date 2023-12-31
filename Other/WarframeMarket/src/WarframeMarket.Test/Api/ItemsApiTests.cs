/*
 * Warframe.market API
 *
 * ## Documentation is under very slow and heavy development  This document will gradually be supplemented and updated over some extended period of time.  ## Unstable endpoints Endpoint that is not stable and probably will be changed in the future will be marked with exclamation sign -> ⚠ 
 *
 * The version of the OpenAPI document: 1.14.0
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

using WarframeMarket.Client;
using WarframeMarket.Api;
// uncomment below to import models
//using WarframeMarket.Model;

namespace WarframeMarket.Test.Api
{
    /// <summary>
    ///  Class for testing ItemsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ItemsApiTests : IDisposable
    {
        private ItemsApi instance;

        public ItemsApiTests()
        {
            instance = new ItemsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ItemsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ItemsApi
            //Assert.IsType<ItemsApi>(instance);
        }

        /// <summary>
        /// Test GetItemInfo
        /// </summary>
        [Fact]
        public void GetItemInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string urlName = null;
            //string platform = null;
            //var response = instance.GetItemInfo(urlName, platform);
            //Assert.IsType<GetItemInfo200Response>(response);
        }

        /// <summary>
        /// Test ItemsGet
        /// </summary>
        [Fact]
        public void ItemsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string language = null;
            //var response = instance.ItemsGet(language);
            //Assert.IsType<ItemsGet200Response>(response);
        }

        /// <summary>
        /// Test ItemsUrlNameDropsourcesGet
        /// </summary>
        [Fact]
        public void ItemsUrlNameDropsourcesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string urlName = null;
            //string language = null;
            //string include = null;
            //var response = instance.ItemsUrlNameDropsourcesGet(urlName, language, include);
            //Assert.IsType<ItemsUrlNameDropsourcesGet200Response>(response);
        }

        /// <summary>
        /// Test ItemsUrlNameOrdersGet
        /// </summary>
        [Fact]
        public void ItemsUrlNameOrdersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string urlName = null;
            //string platform = null;
            //string include = null;
            //var response = instance.ItemsUrlNameOrdersGet(urlName, platform, include);
            //Assert.IsType<ItemsUrlNameOrdersGet200Response>(response);
        }
    }
}
