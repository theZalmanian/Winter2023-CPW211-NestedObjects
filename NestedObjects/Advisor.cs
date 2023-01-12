using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a college advisor
    /// </summary>
    public class Advisor
    {
        /// <summary>
        /// The advisor's legal first and last name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The advisor's work email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The advisor's office location (building and room number)
        /// </summary>
        public string OfficeLocation { get; set; }
    }
}
