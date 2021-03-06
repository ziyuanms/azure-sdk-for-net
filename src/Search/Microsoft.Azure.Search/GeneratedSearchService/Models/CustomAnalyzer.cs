// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Allows you to take control over the process of converting text into
    /// indexable/searchable tokens. It's a user-defined configuration
    /// consisting of a single predefined tokenizer and one or more filters.
    /// The tokenizer is responsible for breaking text into tokens, and the
    /// filters for modifying tokens emitted by the tokenizer.
    /// </summary>
    [JsonObject("#Microsoft.Azure.Search.CustomAnalyzer")]
    public partial class CustomAnalyzer : Analyzer
    {
        /// <summary>
        /// Initializes a new instance of the CustomAnalyzer class.
        /// </summary>
        public CustomAnalyzer() { }

        /// <summary>
        /// Initializes a new instance of the CustomAnalyzer class.
        /// </summary>
        public CustomAnalyzer(string name, TokenizerName tokenizer, IList<TokenFilterName> tokenFilters = default(IList<TokenFilterName>), IList<CharFilterName> charFilters = default(IList<CharFilterName>))
            : base(name)
        {
            Tokenizer = tokenizer;
            TokenFilters = tokenFilters;
            CharFilters = charFilters;
        }

        /// <summary>
        /// Gets or sets the name of the tokenizer to use to divide continuous
        /// text into a sequence of tokens, such as breaking a sentence into
        /// words.
        /// </summary>
        [JsonProperty(PropertyName = "tokenizer")]
        public TokenizerName Tokenizer { get; set; }

        /// <summary>
        /// Gets or sets a list of token filters used to filter out or modify
        /// the tokens generated by a tokenizer. For example, you can specify
        /// a lowercase filter that converts all characters to lowercase. The
        /// filters are run in the order in which they are listed.
        /// </summary>
        [JsonProperty(PropertyName = "tokenFilters")]
        public IList<TokenFilterName> TokenFilters { get; set; }

        /// <summary>
        /// Gets or sets a list of character filters used to prepare input
        /// text before it is processed by the tokenizer. For instance, they
        /// can replace certain characters or symbols. The filters are run in
        /// the order in which they are listed.
        /// </summary>
        [JsonProperty(PropertyName = "charFilters")]
        public IList<CharFilterName> CharFilters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Tokenizer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tokenizer");
            }
        }
    }
}
