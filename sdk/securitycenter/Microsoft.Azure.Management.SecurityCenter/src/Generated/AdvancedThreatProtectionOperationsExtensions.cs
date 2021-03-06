// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AdvancedThreatProtectionOperations.
    /// </summary>
    public static partial class AdvancedThreatProtectionOperationsExtensions
    {
            /// <summary>
            /// Gets the Advanced Threat Protection settings for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            public static AdvancedThreatProtectionSetting Get(this IAdvancedThreatProtectionOperations operations, string resourceId)
            {
                return operations.GetAsync(resourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Advanced Threat Protection settings for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AdvancedThreatProtectionSetting> GetAsync(this IAdvancedThreatProtectionOperations operations, string resourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the Advanced Threat Protection settings on a specified
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='isEnabled'>
            /// Indicates whether Advanced Threat Protection is enabled.
            /// </param>
            public static AdvancedThreatProtectionSetting Create(this IAdvancedThreatProtectionOperations operations, string resourceId, bool? isEnabled = default(bool?))
            {
                return operations.CreateAsync(resourceId, isEnabled).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the Advanced Threat Protection settings on a specified
            /// resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='isEnabled'>
            /// Indicates whether Advanced Threat Protection is enabled.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AdvancedThreatProtectionSetting> CreateAsync(this IAdvancedThreatProtectionOperations operations, string resourceId, bool? isEnabled = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceId, isEnabled, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
