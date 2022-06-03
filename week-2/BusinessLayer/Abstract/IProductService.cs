using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    // abstrack klasöründe interfaceleri tanımladım tüm katmanlarda
    public interface IProductService
    {
        //temel crud işlemleri
        void ProductAdd(Product product);
        void ProductDelete(Product product);
        void ProductUpdate(Product product);

        List<Product> GetList();
         Product GetById(int id);
    }
}
