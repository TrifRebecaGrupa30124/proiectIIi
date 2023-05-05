using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Models
{
    class CustomerModel
    {

        private int id;
        private string name;
        private string email;
        private string phone;
        private string address;
      


        //Properties - Validations
        [DisplayName("ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Customer's name is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer's name must be between 3 and 50 characters")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        [DisplayName("Email")]
        [Required(ErrorMessage = "Customer's email is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer's email must be between 3 and 50 characters")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DisplayName("Phone")]
        [Required(ErrorMessage = "Customer's phone is requerid")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Customer's phone must be between 3 and 50 characters")]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        [DisplayName("Address")]
        [Required(ErrorMessage = "Customer's address is requerid")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Customer's address must be between 3 and 50 characters")]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}

