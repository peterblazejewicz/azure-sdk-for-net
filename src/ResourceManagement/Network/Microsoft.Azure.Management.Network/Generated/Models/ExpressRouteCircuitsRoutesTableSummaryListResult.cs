// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Response for ListRoutesTable associated with the Express Route
    /// Circuits Api
    /// </summary>
    public partial class ExpressRouteCircuitsRoutesTableSummaryListResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteCircuitsRoutesTableSummaryListResult class.
        /// </summary>
        public ExpressRouteCircuitsRoutesTableSummaryListResult() { }

        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteCircuitsRoutesTableSummaryListResult class.
        /// </summary>
        public ExpressRouteCircuitsRoutesTableSummaryListResult(IList<ExpressRouteCircuitRoutesTableSummary> value = default(IList<ExpressRouteCircuitRoutesTableSummary>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets List of RoutesTable
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ExpressRouteCircuitRoutesTableSummary> Value { get; set; }

        /// <summary>
        /// Gets the URL to get the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
