using KendoUIAPIs.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;


namespace KendoUIAPIs.Controllers
{
    public class ProductController : ApiController
    {
       
        [HttpGet]
        public ProductDto GetProduct()
        {
            ProductDto product = new ProductDto();
            product.ProductName = "MyName";
            product.ProductId = 1;
            product.UnitPrice = 100;

            return product;
        }

        [HttpPut]
        public HttpResponseMessage Update(ProductDto product)
        {
            product = new ProductDto();
            product.ProductName = "YourName";
            product.ProductId = 1;
            product.UnitPrice = 100;

            var response = Request.CreateResponse(HttpStatusCode.OK, "Success");
            return response;
        }
        
        [HttpPost]
        public HttpResponseMessage Create(ProductDto product)
        {
            product = new ProductDto();
            product.ProductName = "HerName";
            product.ProductId = 1;
            product.UnitPrice = 100;

            var response = Request.CreateResponse(HttpStatusCode.OK, "Success");
            return response;
        }


    }
}
