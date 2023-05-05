using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Models
{
    interface IBasketRepository
    {
        void Add(BasketModel productModel);     
        void Delete(int id);
        IEnumerable<BasketModel> GetAll();
      
    }
}
