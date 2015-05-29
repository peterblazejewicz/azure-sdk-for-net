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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Search.Models;

namespace Microsoft.Azure.Search.Models
{
    /// <summary>
    /// Parameters for filtering, sorting, faceting, paging, and other search
    /// query behaviors.
    /// </summary>
    public partial class SearchParameters
    {
        private string _filter;
        
        /// <summary>
        /// Optional. Gets or sets the OData $filter expression to apply to the
        /// search query.  (see
        /// https://msdn.microsoft.com/library/azure/dn798921.aspx for more
        /// information)
        /// </summary>
        public string Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }
        
        private IList<string> _highlightFields;
        
        /// <summary>
        /// Optional. Gets or sets the list of field names to use for hit
        /// highlights. Only searchable fields can be used for hit
        /// highlighting.
        /// </summary>
        public IList<string> HighlightFields
        {
            get { return this._highlightFields; }
            set { this._highlightFields = value; }
        }
        
        private string _highlightPostTag;
        
        /// <summary>
        /// Optional. Gets or sets a string tag that is appended to hit
        /// highlights. Must be set with HighlightPreTag. Default is
        /// &lt;/em&gt;.
        /// </summary>
        public string HighlightPostTag
        {
            get { return this._highlightPostTag; }
            set { this._highlightPostTag = value; }
        }
        
        private string _highlightPreTag;
        
        /// <summary>
        /// Optional. Gets or sets a string tag that is prepended to hit
        /// highlights. Must be set with HighlightPostTag. Default is
        /// &lt;em&gt;.
        /// </summary>
        public string HighlightPreTag
        {
            get { return this._highlightPreTag; }
            set { this._highlightPreTag = value; }
        }
        
        private bool _includeTotalResultCount;
        
        /// <summary>
        /// Optional. Gets or sets a value that specifies whether to fetch the
        /// total count of results. Default is false. Setting this value to
        /// true may have a performance impact. Note that the count returned
        /// is an approximation.
        /// </summary>
        public bool IncludeTotalResultCount
        {
            get { return this._includeTotalResultCount; }
            set { this._includeTotalResultCount = value; }
        }
        
        private IList<string> _orderBy;
        
        /// <summary>
        /// Optional. Gets or sets the list of OData $orderby expressions by
        /// which to sort the results. Each expression can be either a field
        /// name or a call to the geo.distance() function. Each expression can
        /// be followed by asc to indicate ascending, and desc to indicate
        /// descending. The default is ascending order. Ties will be broken by
        /// the match scores of documents. If no OrderBy is specified, the
        /// default sort order is descending by document match score. There
        /// can be at most 32 Orderby clauses.
        /// </summary>
        public IList<string> OrderBy
        {
            get { return this._orderBy; }
            set { this._orderBy = value; }
        }
        
        private IList<string> _scoringParameters;
        
        /// <summary>
        /// Optional. Gets or sets the list of parameter values to be used in
        /// scoring functions (for example, referencePointParameter) using the
        /// format name:value. For example, if the scoring profile defines a
        /// function with a parameter called 'mylocation' the parameter string
        /// would be "mylocation:-122.2,44.8"(without the quotes).
        /// </summary>
        public IList<string> ScoringParameters
        {
            get { return this._scoringParameters; }
            set { this._scoringParameters = value; }
        }
        
        private string _scoringProfile;
        
        /// <summary>
        /// Optional. Gets or sets the name of a scoring profile to evaluate
        /// match scores for matching documents in order to sort the results.
        /// </summary>
        public string ScoringProfile
        {
            get { return this._scoringProfile; }
            set { this._scoringProfile = value; }
        }
        
        private IList<string> _searchFields;
        
        /// <summary>
        /// Optional. Gets or sets the list of field names to include in the
        /// full-text search.
        /// </summary>
        public IList<string> SearchFields
        {
            get { return this._searchFields; }
            set { this._searchFields = value; }
        }
        
        private SearchMode _searchMode;
        
        /// <summary>
        /// Optional. Gets or sets a value that specifies whether any or all of
        /// the search terms must be matched in order to count the document as
        /// a match.
        /// </summary>
        public SearchMode SearchMode
        {
            get { return this._searchMode; }
            set { this._searchMode = value; }
        }
        
        private IList<string> _select;
        
        /// <summary>
        /// Optional. Gets or sets the list of fields to retrieve. If
        /// unspecified, all fields marked as retrievable in the schema are
        /// included.
        /// </summary>
        public IList<string> Select
        {
            get { return this._select; }
            set { this._select = value; }
        }
        
        private int? _skip;
        
        /// <summary>
        /// Optional. Gets or sets the number of search results to skip. This
        /// value cannot be greater than 100,000. If you need to scan
        /// documents in sequence, but cannot use Skip due to this limitation,
        /// consider using OrderBy on a totally-ordered key and Filter with a
        /// range query instead.
        /// </summary>
        public int? Skip
        {
            get { return this._skip; }
            set { this._skip = value; }
        }
        
        private int? _top;
        
        /// <summary>
        /// Optional. Gets or sets the number of search results to retrieve.
        /// This defaults to 50. If you specify a value greater than 1000 for
        /// Top and there are more than 1000 results, only the first 1000
        /// results will be returned, along with a continuation token. See
        /// DocumentSearchResponse.ContinuationToken for more information.
        /// </summary>
        public int? Top
        {
            get { return this._top; }
            set { this._top = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SearchParameters class.
        /// </summary>
        public SearchParameters()
        {
            this.HighlightFields = new LazyList<string>();
            this.OrderBy = new LazyList<string>();
            this.ScoringParameters = new LazyList<string>();
            this.SearchFields = new LazyList<string>();
            this.Select = new LazyList<string>();
        }
    }
}