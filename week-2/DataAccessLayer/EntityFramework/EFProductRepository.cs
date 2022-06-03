using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    // ef repository için hem generic repository hemde product dal kalıtım alımalı , daha sonrasında generic repository oluşturuldu.

    public class EFProductRepository : GenericRepository<Product>, IProductDAL
    {


    }
}
