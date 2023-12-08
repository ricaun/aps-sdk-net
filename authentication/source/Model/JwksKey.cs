/* 
 * APS SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * Authentication
 *
 * OAuth2 token management APIs.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Authentication.Model
{
    /// <summary>
    /// Jwks
    /// </summary>
    [DataContract]
    public partial class JwksKey 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Jwks" /> class.
        /// </summary>
        public JwksKey()
        {
        }
            
        /// <summary>
        /// Gets or Sets Kid
        /// </summary>
        [DataMember(Name="kid", EmitDefaultValue=false)]
        public string Kid { get; set; }

        /// <summary>
        /// Gets or Sets Kty
        /// </summary>
        [DataMember(Name="kty", EmitDefaultValue=false)]
        public string Kty { get; set; }

        /// <summary>
        /// Gets or Sets Use
        /// </summary>
        [DataMember(Name="use", EmitDefaultValue=false)]
        public string Use { get; set; }

        /// <summary>
        /// Gets or Sets N
        /// </summary>
        [DataMember(Name="n", EmitDefaultValue=false)]
        public string N { get; set; }

        /// <summary>
        /// Gets or Sets E
        /// </summary>
        [DataMember(Name="e", EmitDefaultValue=false)]
        public string E { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

}
