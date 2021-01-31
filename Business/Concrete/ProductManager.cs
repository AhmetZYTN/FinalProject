using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ProductDal;
        private InMemoryProductDal ınMemoryProductDal;
        private InMemoryProductDal ınMemoryProductDal1;

        public ProductManager(IProductDal productDal)
        {
            _ProductDal = productDal;
        }

        public ProductManager(InMemoryProductDal ınMemoryProductDal1)
        {
            this.ınMemoryProductDal1 = ınMemoryProductDal1;
        }

        //  public ProductManager(InMemoryProductDal ınMemoryProductDal) => this.ınMemoryProductDal = ınMemoryProductDal;

        public List<Product> GetAll()
        {
            //iş kodları
            return _ProductDal.GetAll();
        }
    }
}
