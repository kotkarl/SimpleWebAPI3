﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Services.Entities.Courses
{
    /// <summary>
    /// This class represents a single course in a school
    /// </summary>
    [Table("Courses")]
    class Course
    {
        /// <summary>
        /// The ID of a course. Generated by the database
        /// Example: 1
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The Template ID of a course. 
        /// Example: "T-514-VEFT"
        /// </summary>
        public string TemplateID { get; set; }

        /// <summary>
        /// The start date of a course. 
        /// Example: "2015-08-20T00:00:00"
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date of a course. 
        /// Example: "2015-11-20T00:00:00"
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// The semester that a course is tought. 
        /// Example: "20151" -> Spring 2015, 
        ///          "20152" -> Summer 2015, 
        ///          "20153" -> Fall 2015
        /// </summary>
        public string Semester { get; set; }

        /// <summary>
        /// The max number of students allowed in a course
        /// Example: 20
        /// </summary>
        public int MaxStudents { get; set; }
    }
}
