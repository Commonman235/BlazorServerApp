using System.ComponentModel.DataAnnotations;

namespace BlazorServerApp.Model
{


    public class EmployeeData
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "FirstName is mandatory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Salary is mandatory")]
        public string Salary { get; set; }

        [Required(ErrorMessage = "Department is mandatory")]
        public string Department { get; set; }

    }
    
    
    public class EmployeeDetails
    {
        public int id { get; set; }


        public string name { get; set; }

        public double salary { get; set; }

        public string department { get; set; }

    }


}
