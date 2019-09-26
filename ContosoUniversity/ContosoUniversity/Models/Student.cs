using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")] //Specifies the name of the column in the DB.
        [Display(Name ="First Name")]
        public string FirstMidName { get; set; }


        [DataType(DataType.Date)] // Speicfies data type.
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] // Formats Date.
        [Display(Name ="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName // Since it has no "set", no column will be generated in te DB.
        {
            get
            {
                return LastName + " " + FirstMidName;
            }
        }

        public virtual ICollection<Enrollment> Enrollments { get; set; } //A Student entity can be related to multiple Enrollment entities.

    }
}