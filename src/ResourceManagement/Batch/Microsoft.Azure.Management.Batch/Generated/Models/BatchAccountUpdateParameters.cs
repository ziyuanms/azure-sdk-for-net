// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using Azure;
    using Management;
    using Batch;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Update operation.
    /// </summary>
    [JsonTransformation]
    public partial class BatchAccountUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the BatchAccountUpdateParameters
        /// class.
        /// </summary>
        public BatchAccountUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the BatchAccountUpdateParameters
        /// class.
        /// </summary>
        /// <param name="tags">The user specified tags associated with the
        /// account.</param>
        /// <param name="autoStorage">The properties related to auto storage
        /// account.</param>
        /// <param name="poolAllocationMode">The allocation mode to use for
        /// creating pools in the Batch account.</param>
        /// <param name="keyVaultReference">A reference to the Azure key vault
        /// associated with the Batch account.</param>
        public BatchAccountUpdateParameters(IDictionary<string, string> tags = default(IDictionary<string, string>), AutoStorageBaseProperties autoStorage = default(AutoStorageBaseProperties), PoolAllocationMode? poolAllocationMode = default(PoolAllocationMode?), KeyVaultReference keyVaultReference = default(KeyVaultReference))
        {
            Tags = tags;
            AutoStorage = autoStorage;
            PoolAllocationMode = poolAllocationMode;
            KeyVaultReference = keyVaultReference;
        }

        /// <summary>
        /// Gets or sets the user specified tags associated with the account.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the properties related to auto storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoStorage")]
        public AutoStorageBaseProperties AutoStorage { get; set; }

        /// <summary>
        /// Gets or sets the allocation mode to use for creating pools in the
        /// Batch account.
        /// </summary>
        /// <remarks>
        /// The pool allocation mode also affects how clients may authenticate
        /// to the Batch Service API. If the mode is BatchService, clients may
        /// authenticate using access keys or Azure Active Directory. If the
        /// mode is UserSubscription, clients must use Azure Active Directory.
        /// The default is BatchService. Possible values include:
        /// 'BatchService', 'UserSubscription'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.poolAllocationMode")]
        public PoolAllocationMode? PoolAllocationMode { get; set; }

        /// <summary>
        /// Gets or sets a reference to the Azure key vault associated with the
        /// Batch account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVaultReference")]
        public KeyVaultReference KeyVaultReference { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AutoStorage != null)
            {
                AutoStorage.Validate();
            }
            if (KeyVaultReference != null)
            {
                KeyVaultReference.Validate();
            }
        }
    }
}

