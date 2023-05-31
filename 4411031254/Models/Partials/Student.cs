using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _4411031254.Models
{
    [MetadataType(typeof(StudentMetadata))]
    
    public partial class Student
    {
        
    }

    public class StudentMetadata
    {
        public int Id{get; set;}

        [Required(ErrorMessage ="請輸入名字")]
        [Display(Name ="姓名")]
        [StringLength(12,ErrorMessage = "最多只能輸入10個字")]
        public string Name{get; set;}

        [Required(ErrorMessage = "請輸入學號")]
        [Display(Name = "學號")]
        [StringLength(10, ErrorMessage = "最多只能輸入10個字")]
        public string Number{get; set;}

        [Required(ErrorMessage = "請輸入電子郵件")]
        [EmailAddress]
        public string Email{get; set;}
    }
}