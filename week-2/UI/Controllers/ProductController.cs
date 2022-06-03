using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductManager pm = new ProductManager(new EFProductRepository()); 
        
        [HttpGet]
        public IActionResult GetList(Product product)
        {
             var values = pm.GetList();

            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
           var values = pm.GetById(id);

            return Ok(values);
        }
        //[HttpPost]
        //public IActionResult Save()
        //{
        //    return Ok("Save");
        //}
        [HttpPost]
        public IActionResult ProductAdd(Product product)
        {
            pm.ProductAdd(product);
            return Ok(product);
        }
        [HttpPut]
        public IActionResult ProductUpdate(Product product)
        {
            pm.ProductUpdate(product);

            return Ok(pm);
        }
        [HttpDelete]
        public IActionResult ProductDelete(Product product)
        {
              pm.ProductDelete(product);

            return Ok(product);
        }

    }
}
