using System.ComponentModel.DataAnnotations;

namespace StudentDatabase.Models
{
    // this is the Student model class

    // it represents a row in the Students table ...



    public class Student
    {
        // primary key for the studen ....

        [Key]
        public int StudentId { get; set; }

        // first and last name of the student

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        // the date the student enrolled ...

        public DateTime EnrollmentDate { get; set; }
    }
}
