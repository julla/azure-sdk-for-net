// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.TrafficManager;

namespace Microsoft.WindowsAzure.Management.TrafficManager
{
    /// <summary>
    /// The Windows Azure Traffic Manager management API provides a RESTful set
    /// of web services that interact with Windows Azure Traffic Manager
    /// service for creating, updating, listing, and deleting Traffic Manager
    /// profiles and definitions.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166981.aspx for
    /// more information)
    /// </summary>
    public partial interface ITrafficManagerClient : IDisposable
    {
        /// <summary>
        /// The URI used as the base for all Service Management requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API.  The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure.  No anonymous requests
        /// are allowed.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// The Traffic Manager API includes operations for managing
        /// definitions for a specified profile.
        /// </summary>
        IDefinitionOperations Definitions
        {
            get; 
        }
        
        /// <summary>
        /// The Traffic Manager API includes operations for managing Traffic
        /// Manager profiles.
        /// </summary>
        IProfileOperations Profiles
        {
            get; 
        }
    }
}
