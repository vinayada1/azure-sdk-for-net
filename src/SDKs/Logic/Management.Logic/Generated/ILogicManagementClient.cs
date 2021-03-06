// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// REST API for Azure Logic Apps.
    /// </summary>
    public partial interface ILogicManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The subscription id.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The API version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IWorkflowsOperations.
        /// </summary>
        IWorkflowsOperations Workflows { get; }

        /// <summary>
        /// Gets the IWorkflowVersionsOperations.
        /// </summary>
        IWorkflowVersionsOperations WorkflowVersions { get; }

        /// <summary>
        /// Gets the IWorkflowTriggersOperations.
        /// </summary>
        IWorkflowTriggersOperations WorkflowTriggers { get; }

        /// <summary>
        /// Gets the IWorkflowTriggerHistoriesOperations.
        /// </summary>
        IWorkflowTriggerHistoriesOperations WorkflowTriggerHistories { get; }

        /// <summary>
        /// Gets the IWorkflowRunsOperations.
        /// </summary>
        IWorkflowRunsOperations WorkflowRuns { get; }

        /// <summary>
        /// Gets the IWorkflowRunActionsOperations.
        /// </summary>
        IWorkflowRunActionsOperations WorkflowRunActions { get; }

        /// <summary>
        /// Gets the IIntegrationAccountsOperations.
        /// </summary>
        IIntegrationAccountsOperations IntegrationAccounts { get; }

        /// <summary>
        /// Gets the ISchemasOperations.
        /// </summary>
        ISchemasOperations Schemas { get; }

        /// <summary>
        /// Gets the IMapsOperations.
        /// </summary>
        IMapsOperations Maps { get; }

        /// <summary>
        /// Gets the IPartnersOperations.
        /// </summary>
        IPartnersOperations Partners { get; }

        /// <summary>
        /// Gets the IAgreementsOperations.
        /// </summary>
        IAgreementsOperations Agreements { get; }

        /// <summary>
        /// Gets the ICertificatesOperations.
        /// </summary>
        ICertificatesOperations Certificates { get; }

        /// <summary>
        /// Gets the ISessionsOperations.
        /// </summary>
        ISessionsOperations Sessions { get; }

        /// <summary>
        /// Lists all of the available Logic REST API operations.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Operation>>> ListOperationsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Lists all of the available Logic REST API operations.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<Operation>>> ListOperationsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}

