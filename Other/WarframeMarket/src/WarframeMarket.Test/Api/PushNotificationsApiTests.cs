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
    ///  Class for testing PushNotificationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PushNotificationsApiTests : IDisposable
    {
        private PushNotificationsApi instance;

        public PushNotificationsApiTests()
        {
            instance = new PushNotificationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PushNotificationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PushNotificationsApi
            //Assert.IsType<PushNotificationsApi>(instance);
        }

        /// <summary>
        /// Test SettingsNotificationsPushDelete
        /// </summary>
        [Fact]
        public void SettingsNotificationsPushDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.SettingsNotificationsPushDelete();
            //Assert.IsType<SettingsNotificationsPushPost200Response>(response);
        }

        /// <summary>
        /// Test SettingsNotificationsPushGet
        /// </summary>
        [Fact]
        public void SettingsNotificationsPushGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.SettingsNotificationsPushGet();
        }

        /// <summary>
        /// Test SettingsNotificationsPushPost
        /// </summary>
        [Fact]
        public void SettingsNotificationsPushPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SettingsNotificationsPushPostRequest settingsNotificationsPushPostRequest = null;
            //var response = instance.SettingsNotificationsPushPost(settingsNotificationsPushPostRequest);
            //Assert.IsType<SettingsNotificationsPushPost200Response>(response);
        }
    }
}
