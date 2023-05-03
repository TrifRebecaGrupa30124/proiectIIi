using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Models
{
    interface ILogInRepository
    {
        void Add(ModelLogIn logInModel);
        void Edit(ModelLogIn logInModel);
        void Delete(int id);
        ModelLogIn GetAll();
    }
}
