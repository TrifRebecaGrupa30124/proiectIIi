using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Models
{
    class ProductModel
    {
        private int id;
        private string name;
        private string description;
        private string price;
        private string ammount;
        private string imageURL;
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
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DisplayName("Description")]
        [Required(ErrorMessage = "Product description is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product description must be between 3 and 50 characters")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        [DisplayName("Price")]
        [Required(ErrorMessage = "Product price is requerid")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Product price must be between 3 and 50 characters")]
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        [DisplayName("Ammount")]
        [Required(ErrorMessage = "Product ammount is requerid")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Product ammount must be between 3 and 50 characters")]
        public string Ammount
        {
            get { return ammount; }
            set { ammount = value; }
        }
    }
}
