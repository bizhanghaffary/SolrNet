﻿#region license
// Copyright (c) 2007-2009 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System.Collections.Generic;
using SolrNet.Commands.Parameters;

namespace SolrNet {
    public interface ISolrReadOnlyOperations<T> : ISolrBasicReadOnlyOperations<T> {
        /// <summary>
        /// Queries documents
        /// </summary>
        /// <param name="q">query to execute</param>
        /// <returns>query results</returns>
        ISolrQueryResults<T> Query(string q);

        ISolrQueryResults<T> Query(string q, ICollection<SortOrder> orders);
        ISolrQueryResults<T> Query(string q, QueryOptions options);
        ISolrQueryResults<T> Query(ISolrQuery q);
        ISolrQueryResults<T> Query(ISolrQuery query, ICollection<SortOrder> orders);

        ICollection<KeyValuePair<string, int>> FacetFieldQuery(SolrFacetFieldQuery facets);
    }
}