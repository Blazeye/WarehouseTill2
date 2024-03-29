﻿using WarehouseTill.display;
using WarehouseTill.products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WarehouseTill.till
{
    public class Till : ITill
    {
        IProductCatalog List;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="catalogus">The product catalogus to supply the products and search of products</param>
        public Till(IProductCatalog catalogus)
        {
            if (catalogus == null)
            {

                throw new ObjectIsNullException("The catalog does not exist");

            }
            this.List = catalogus;

            // throw new NotImplementedException();
        }

        /// <summary>
        /// Handle a scan of a barcode
        /// </summary>
        /// <param name="barcode">The scanned barcode</param>
        /// <returns><c>true</c> if succesfull, <c>false</c> otherwise</returns>
        public bool HandleBarcode(string barcode) {

            bool bb = false;
            if (!(List.FindProductForBarcode(barcode) == null))
            {
                bb = true;
            }
            return bb;

            //throw new NotImplementedException();
        }

        /// <summary>
        /// Initiate a payment
        /// </summary>
        /// <param name="amount">The amount paid</param>
        /// <returns>the change to return as a list of (coinvalue => quantity) 
        ///          or <code>null</code> on failure</returns>
        public IDictionary<decimal, int> InitiatePayment(decimal amount) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Installs an interface to be used when displaying
        /// </summary>
        /// <param name="tillDisplay">The interface to use from now on</param>
        public void SetDisplayInterface(ITillDisplay tillDisplay) {
            // throw new NotImplementedException();
        }

        /// <summary>
        /// Trigger a show all products
        /// </summary>
        public void ShowAllProducts() {
            //            throw new NotImplementedException();

            //IList<IProduct> productList = new ProductCatalog


            var items = this.List.GetAllProducts();
            Console.WriteLine("\nProducten:\n");
            foreach(IProduct item in items)
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine();
            




        }
    }
}
