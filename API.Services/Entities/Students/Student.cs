﻿using System.ComponentModel.DataAnnotations.Schema;

namespace API.Services.Entities.Students
{
    /// <summary>
    /// This class represents a student at a school
    /// </summary>
    [Table("Students")]
    class Student
    {
        /// <summary>
        /// ID of student generated by the database
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of the student
        /// Example: "Jón Gunnarsson"
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Students SSN
        /// Example: "1212882659"
        /// </summary>
        public string SSN { get; set; }


    }
}
