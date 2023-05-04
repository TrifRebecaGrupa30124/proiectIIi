using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Models
{
    class ModelLogIn
    {
        private int id;
        private string name;
        private string password;

        [DisplayName("User ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DisplayName("User Name")]
        [Required(ErrorMessage = "User name is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "User name must be between 3 and 50 characters")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DisplayName("User Password")]
        [Required(ErrorMessage = "Password is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Password must be between 3 and 50 characters")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
