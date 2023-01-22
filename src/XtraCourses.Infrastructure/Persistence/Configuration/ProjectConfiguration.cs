using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XtraCourses.Application.Entities;

namespace XtraCourses.Infrastructure.Persistence.Configuration
{
    internal sealed class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.OwnsOne(x => x.ProjectDetails, sb =>
            {
                sb.Property(x => x.CertificateTitle).HasDefaultValue(string.Empty);
                sb.Property(x => x.CompletedDate).HasDefaultValue(string.Empty);
                sb.Property(x => x.CourseStartedDate).HasDefaultValue(string.Empty);
                sb.Property(x => x.OpenedLessonsCount).HasDefaultValue(0);
                sb.Property(x => x.CompletedLessonsCount).HasDefaultValue(0);
                sb.Property(x => x.TotalLessonsCount).HasDefaultValue(0);
                sb.Property(x => x.HaveNotStarted).HasDefaultValue(string.Empty);
                sb.Property(x => x.NotOnSchedule).HasDefaultValue(string.Empty);
                sb.Property(x => x.HaveStarted).HasDefaultValue(string.Empty);
                sb.Property(x => x.QuizScore).HasDefaultValue(0);
                sb.Property(x => x.QuizScoreTotal).HasDefaultValue(0);
                sb.Property(x => x.IsPassed).HasDefaultValue(false);
            });

            builder.HasOne(x => x.User)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.PersonId);
        }
    }
}
