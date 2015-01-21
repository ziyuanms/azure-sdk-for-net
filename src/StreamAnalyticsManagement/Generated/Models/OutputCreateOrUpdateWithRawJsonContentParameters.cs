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

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// Parameters specifying the output definition for a create or update
    /// operation in json format.
    /// </summary>
    public partial class OutputCreateOrUpdateWithRawJsonContentParameters
    {
        private string _content;
        
        /// <summary>
        /// Required. Gets or sets the definition of the output to be created
        /// or updated. It is in json format.
        /// </summary>
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// OutputCreateOrUpdateWithRawJsonContentParameters class.
        /// </summary>
        public OutputCreateOrUpdateWithRawJsonContentParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// OutputCreateOrUpdateWithRawJsonContentParameters class with
        /// required arguments.
        /// </summary>
        public OutputCreateOrUpdateWithRawJsonContentParameters(string content)
            : this()
        {
            if (content == null)
            {
                throw new ArgumentNullException("content");
            }
            this.Content = content;
        }
    }
}