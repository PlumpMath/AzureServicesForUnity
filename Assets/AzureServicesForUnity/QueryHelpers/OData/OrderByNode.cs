﻿// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AzureServicesForUnity.QueryHelpers.OData
{
    /// <summary>
    /// Represents the result of parsing the $orderby query option.
    /// </summary>
    public class OrderByNode
    {
        /// <summary>
        /// Gets the order-by expression.
        /// </summary>
        public QueryNode Expression { get; private set; }

        /// <summary>
        /// Gets the direction to order.
        /// </summary>
        public OrderByDirection Direction { get; private set; }

        /// <summary>
        /// Initializes an instance of <see cref="OrderByNode"/>
        /// </summary>
        /// <param name="expression">The order-by expression.</param>
        /// <param name="direction">The direction to order.</param>
        public OrderByNode(QueryNode expression, OrderByDirection direction)
        {
            this.Expression = expression;
            this.Direction = direction;
        }
    }
}
