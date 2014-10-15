namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    public class Homework
    {
        [Key]
        public int HomeworkId { get; set; }

        [Column("Content")]
        public string Content { get; set; }

        [Column("Sended at")]
        public DateTime TimeSent { get; set; }

        [Column("StudentId")]
        public virtual Student StudentId { get; set; }

        [Column("CourseId")]
        public virtual Course CourseId { get; set; }
    }
}