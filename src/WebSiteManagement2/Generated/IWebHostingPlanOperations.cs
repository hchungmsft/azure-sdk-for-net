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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.WebSites.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.WebSites
{
    /// <summary>
    /// Operations for managing the Web Hosting Plans in a resource group. Web
    /// hosting plans (WHPs) represent a set of features and capacity that you
    /// can share across your web sites. Web hosting plans support the 4 Azure
    /// Web Sites pricing tiers (Free, Shared, Basic, and Standard) where each
    /// tier has its own capabilities and capacity. Sites in the same
    /// subscription, resource group, and geographic location can share a web
    /// hosting plan. All the sites sharing a web hosting plan can leverage
    /// all the capabilities and features defined by the web hosting plan
    /// tier. All web sites associated with a given web hosting plan run on
    /// the resources defined by the web hosting plan.  (see
    /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
    /// for more information)
    /// </summary>
    public partial interface IWebHostingPlanOperations
    {
        /// <summary>
        /// Creates a new Web Hosting Plan or updates an existing one.  (see
        /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Server Farm operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create Web Hosting Plan operation response.
        /// </returns>
        Task<WebHostingPlanCreateOrUpdateResponse> CreateOrUpdateAsync(string resourceGroupName, WebHostingPlanCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes a Web Hosting Plan  (see
        /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webHostingPlanName'>
        /// The name of the Web Hosting Plan to delete.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteAsync(string resourceGroupName, string webHostingPlanName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets details of an existing Web Hosting Plan  (see
        /// http://azure.microsoft.com/en-us/documentation/articles/azure-web-sites-web-hosting-plans-in-depth-overview/
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webHostingPlanName'>
        /// The name of the Web Hosting Plan.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Web Hosting Plan operation response.
        /// </returns>
        Task<WebHostingPlanGetResponse> GetAsync(string resourceGroupName, string webHostingPlanName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can retrieve historical usage metrics for a site by issuing an
        /// HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166964.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='webHostingPlanName'>
        /// The name of the web hosting plan.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Get Historical Usage Metrics Web hosting
        /// plan operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Historical Usage Metrics Web hosting plan operation
        /// response.
        /// </returns>
        Task<WebHostingPlanGetHistoricalUsageMetricsResponse> GetHistoricalUsageMetricsAsync(string resourceGroupName, string webHostingPlanName, WebHostingPlanGetHistoricalUsageMetricsParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets all Web Hosting Plans in a current subscription and Resource
        /// Group.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194277.aspx
        /// for more information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Web Hosting Plans operation response.
        /// </returns>
        Task<WebHostingPlanListResponse> ListAsync(string resourceGroupName, CancellationToken cancellationToken);
    }
}