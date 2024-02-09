//-----------------------------------------------------------------------
// <copyright file="SampleJsonDataGeneratorSettings.cs" company="NJsonSchema">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/RicoSuter/NJsonSchema/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

namespace NJsonSchema
{
    /// <summary> Settings for generating sample json data.</summary>
    public class DefaultJsonDataGeneratorSettings
    {
        /// <summary>Gets or sets a value indicating whether to generate optional properties (default: true).</summary>
        public bool GenerateOptionalProperties { get; set; } = true;

        /// <summary>Gets or sets a value indicating the max level of recursion the generator is allowed to perform (default: 3)</summary>
        public int MaxRecursionLevel { get; set; } = 3;

        /// <summary>
        /// Whether to generate example values for the generated JSON data instead of type defaults.
        /// </summary>
        public bool GenerateExampleValues { get; set; } = false;
    }
}
