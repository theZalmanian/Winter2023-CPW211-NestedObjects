using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents an individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The student's legal first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The student's legal last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The student's date of birth (time is ignored)
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The student's assigned school email address
        /// </summary>
        public string SchoolEmail { get; set; }

        /// <summary>
        /// The student's mobile phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The student's assigned college advisor
        /// </summary>
        public Advisor Advisor { get; set; }
    }
}
