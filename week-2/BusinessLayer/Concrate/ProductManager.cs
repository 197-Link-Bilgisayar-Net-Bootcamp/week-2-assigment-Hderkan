using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    //productmanager clasında abstractaki interfaceten katım alındım ve metodları implement ettim.
    public class ProductManager : IProductService
    {
        IProductDAL _productDAL;
        //bir productdal nesnesi oluşturuldum.

        public ProductManager(IProductDAL productDAL)
        {
            //constracter metod oluşturdum.
            _productDAL = productDAL;

        }
        //temel crud işlemleri 

        public Product GetById(int id)
        {
            return _productDAL.GetByID(id);
        }

        public List<Product> GetList()
        {
            return _productDAL.GetListAll();
        }

        public void ProductAdd(Product product)
        {
            _productDAL.Insert(product);
        }

        public void ProductDelete(Product product)
        {
            _productDAL.Delete(product);
        }

        public void ProductUpdate(Product product)
        {
            _productDAL.Update(product);   
        }
    }
}
