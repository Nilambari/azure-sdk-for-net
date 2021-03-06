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

namespace Microsoft.Azure.Management.ApiManagement.SmapiModels
{
    /// <summary>
    /// Operation request/response representation details.
    /// </summary>
    public partial class RepresentationContract
    {
        private string _contentType;
        
        /// <summary>
        /// Required. Gets or sets Content type.
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }
        
        private string _sample;
        
        /// <summary>
        /// Optional. Gets or sets Content sample.
        /// </summary>
        public string Sample
        {
            get { return this._sample; }
            set { this._sample = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RepresentationContract class.
        /// </summary>
        public RepresentationContract()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the RepresentationContract class with
        /// required arguments.
        /// </summary>
        public RepresentationContract(string contentType)
            : this()
        {
            if (contentType == null)
            {
                throw new ArgumentNullException("contentType");
            }
            this.ContentType = contentType;
        }
    }
}
