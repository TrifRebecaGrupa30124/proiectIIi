using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Models
{
    class BasketModel
    {
        private int id;
        private string name;
        private string price;
      

        //Properties - Validations
        [DisplayName("ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Product name is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 50 characters")]
        [ForeignKey("ProductModel")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        [DisplayName("Price")]
        [Required(ErrorMessage = "Product price is requerid")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Product price must be between 3 and 50 characters")]
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        
    }
}
