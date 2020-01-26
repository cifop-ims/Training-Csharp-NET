using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI.Configurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            //ToTable("tbl_Courses");
            //HasKey(c => c.Id);

            Property(c => c.Description)
           .IsRequired()
           .HasMaxLength(255);

            Property(c => c.Name)
            .IsRequired();

            HasRequired(c => c.Author)
            .WithMany(a => a.Courses)
            .HasForeignKey(c => c.AuthorId);

            HasMany(c => c.Tags)
            .WithMany(t => t.Courses)
            .Map(ct => ct.ToTable("CourseTags"));

        }
    }
}
