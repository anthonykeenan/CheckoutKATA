﻿namespace KATA.Services.Model {
    /// <summary>
    ///     Represents a price for an SKU.
    /// </summary>
    public class Price {
        /// <summary>
        ///     Creates a new <see cref="Price" />
        /// </summary>
        /// <param name="sku">Read-only. The product's SKU</param>
        /// <param name="price">Read-only. The product's Unit Price</param>
        public Price(string sku, decimal price) {
            SKU = sku;
            UnitPrice = price;
        }

        /// <summary>
        ///     The product's SKU
        /// </summary>
        public string SKU { get; }

        /// <summary>
        ///     The product's price
        /// </summary>
        public decimal UnitPrice { get; }
    }
}