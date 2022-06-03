using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public  interface IGenericDAL<T> where T : class
    {
        //database değiştirsek bile aynı yapıda kullnabilmek için generic bir yapı oluşturdum. T class olmalı.
        void Insert(T t);
        void Delete(T t);

        void Update(T t);

        List<T> GetListAll();

        T GetByID(int id);
       
    }
}
