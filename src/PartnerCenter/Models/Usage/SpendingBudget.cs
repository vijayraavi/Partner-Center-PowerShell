﻿// -----------------------------------------------------------------------
// <copyright file="SpendingBudget.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.Store.PartnerCenter.Models.Usage
{
    /// <summary>
    /// The spending budget allocated to the customer by the partner.
    /// </summary>
    public sealed class SpendingBudget : ResourceBase
    {
        /// <summary>
        /// Gets or sets the usage spending budget.
        /// </summary>
        public decimal? Amount { get; set; }
    }
}