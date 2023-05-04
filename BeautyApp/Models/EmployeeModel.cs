using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApp.Models
{
    class EmployeeModel
    {
        private int id;
        private string name;
        private string job_name;
        private string hire_date;
        private string salary;
        private string email;
        private string sex;
        private string phone;
        private string birth_date;
        [DisplayName("ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Employee name is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Employee name must be between 3 and 50 characters")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DisplayName("Job Name")]
        [Required(ErrorMessage = "Employee job name is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Employee job name must be between 3 and 50 characters")]
        public string JobName
        {
            get { return job_name; }
            set { job_name = value; }
        }
        [DisplayName("Hire date")]
        [Required(ErrorMessage = "Employee hire date is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Employee hire date must be between 3 and 50 characters")]
        public string HireDate
        {
            get { return hire_date; }
            set { hire_date = value; }
        }
        [DisplayName("Salary")]
        [Required(ErrorMessage = "Employee salary is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Employee salary must be between 3 and 50 characters")]
        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Employee email is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Employee email must be between 3 and 50 characters")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DisplayName("Sex")]
        [Required(ErrorMessage = "Employee sex is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Employee sex must be between 3 and 50 characters")]
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        [DisplayName("Phone")]
        [Required(ErrorMessage = "Employee phone is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Employee phone must be between 3 and 50 characters")]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Employee name is requerid")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Employee name must be between 3 and 50 characters")]
        public string BirthDate_
        {
            get { return birth_date; }
            set { birth_date = value; }
        }
    }
}
