using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace university_management.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please select a student")]
        [ValidateNever]
        public int StudentId { get; set; }
        
        public Student Student { get; set; } = new Student();

        [Required(ErrorMessage = "Please select a course")]
        [ValidateNever]
        public int CourseId { get; set; }
        
        public Course Course { get; set; } = new Course();

        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;

        [Required(ErrorMessage = "Please select a A, B, C, D, F grade")]
        [Display(Name = "Grade")]
        public Grade? Grade { get; set; }
    }

    public enum Grade
    {
        A, B, C, D, F
    }
}