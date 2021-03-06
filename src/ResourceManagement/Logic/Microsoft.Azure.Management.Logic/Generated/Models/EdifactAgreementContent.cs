// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The Edifact agreement content.
    /// </summary>
    public partial class EdifactAgreementContent
    {
        /// <summary>
        /// Initializes a new instance of the EdifactAgreementContent class.
        /// </summary>
        public EdifactAgreementContent() { }

        /// <summary>
        /// Initializes a new instance of the EdifactAgreementContent class.
        /// </summary>
        public EdifactAgreementContent(EdifactOneWayAgreement receiveAgreement, EdifactOneWayAgreement sendAgreement)
        {
            ReceiveAgreement = receiveAgreement;
            SendAgreement = sendAgreement;
        }

        /// <summary>
        /// Gets or sets the EDIFACT one-way receive agreement.
        /// </summary>
        [JsonProperty(PropertyName = "receiveAgreement")]
        public EdifactOneWayAgreement ReceiveAgreement { get; set; }

        /// <summary>
        /// Gets or sets the EDIFACT one-way send agreement.
        /// </summary>
        [JsonProperty(PropertyName = "sendAgreement")]
        public EdifactOneWayAgreement SendAgreement { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReceiveAgreement == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReceiveAgreement");
            }
            if (SendAgreement == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SendAgreement");
            }
            if (this.ReceiveAgreement != null)
            {
                this.ReceiveAgreement.Validate();
            }
            if (this.SendAgreement != null)
            {
                this.SendAgreement.Validate();
            }
        }
    }
}
