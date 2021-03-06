// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Blueprint artifact that deploys a Resource Manager template.
    /// </summary>
    [Newtonsoft.Json.JsonObject("template")]
    [Rest.Serialization.JsonTransformation]
    public partial class TemplateArtifact : Artifact
    {
        /// <summary>
        /// Initializes a new instance of the TemplateArtifact class.
        /// </summary>
        public TemplateArtifact()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TemplateArtifact class.
        /// </summary>
        /// <param name="template">The Resource Manager template blueprint
        /// artifact body.</param>
        /// <param name="parameters">Resource Manager template blueprint
        /// artifact parameter values.</param>
        /// <param name="id">String Id used to locate any resource on
        /// Azure.</param>
        /// <param name="type">Type of this resource.</param>
        /// <param name="name">Name of this resource.</param>
        /// <param name="displayName">One-liner string explain this
        /// resource.</param>
        /// <param name="description">Multi-line explain this resource.</param>
        /// <param name="dependsOn">Artifacts which need to be deployed before
        /// the specified artifact.</param>
        /// <param name="resourceGroup">If applicable, the name of the resource
        /// group placeholder to which the Resource Manager template blueprint
        /// artifact will be deployed.</param>
        public TemplateArtifact(object template, IDictionary<string, ParameterValue> parameters, string id = default(string), string type = default(string), string name = default(string), string displayName = default(string), string description = default(string), IList<string> dependsOn = default(IList<string>), string resourceGroup = default(string))
            : base(id, type, name)
        {
            DisplayName = displayName;
            Description = description;
            DependsOn = dependsOn;
            Template = template;
            ResourceGroup = resourceGroup;
            Parameters = parameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets one-liner string explain this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets multi-line explain this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets artifacts which need to be deployed before the
        /// specified artifact.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dependsOn")]
        public IList<string> DependsOn { get; set; }

        /// <summary>
        /// Gets or sets the Resource Manager template blueprint artifact body.
        /// </summary>
        [JsonProperty(PropertyName = "properties.template")]
        public object Template { get; set; }

        /// <summary>
        /// Gets or sets if applicable, the name of the resource group
        /// placeholder to which the Resource Manager template blueprint
        /// artifact will be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroup")]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// Gets or sets resource Manager template blueprint artifact parameter
        /// values.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parameters")]
        public IDictionary<string, ParameterValue> Parameters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Template == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Template");
            }
            if (Parameters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Parameters");
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 256);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 500)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 500);
                }
            }
            if (Parameters != null)
            {
                foreach (var valueElement in Parameters.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
        }
    }
}
