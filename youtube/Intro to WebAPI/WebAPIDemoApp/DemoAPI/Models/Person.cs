using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    /// <summary>
    /// Represent one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Id from SQL
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The user's first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Couldn't you guess?
        /// </summary>
        public string LastName { get; set; }

    }
}