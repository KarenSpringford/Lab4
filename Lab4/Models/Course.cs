namespace Lab4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Courses")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        [Key]

        [Display(Name = "Course ID")]
        public int CourseID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Course Name")]
        public string Title { get; set; }

        [Display(Name = "Credits")]
        public int Credits { get; set; }

        [Display(Name = "Department ID")]
        public int DepartmentID { get; set; }

        [Display(Name = "Department")]
        public virtual Department Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
