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
    /// Tenant access information update parameters of the Api Management
    /// service.
    /// </summary>
    public partial class AccessInformationUpdateParameters
    {
        private bool _enabled;
        
        /// <summary>
        /// Required. Gets or sets tenant access information of the Api
        /// Management service.
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AccessInformationUpdateParameters
        /// class.
        /// </summary>
        public AccessInformationUpdateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the AccessInformationUpdateParameters
        /// class with required arguments.
        /// </summary>
        public AccessInformationUpdateParameters(bool enabled)
            : this()
        {
            this.Enabled = enabled;
        }
    }
}
