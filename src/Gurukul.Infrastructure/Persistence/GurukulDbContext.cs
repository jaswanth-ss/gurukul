using Gurukul.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gurukul.Infrastructure.Persistence
{
    public class GurukulDbContext : DbContext
    {
        public GurukulDbContext(DbContextOptions<GurukulDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserProfiles> UserProfiles { get; set; }
        public DbSet<Friendships> Friendships { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupMembers> GroupMembers { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<TaskParticipants> TaskParticipants { get; set; }
        public DbSet<TaskProgress> TaskProgress { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Friendships>()
                .HasOne(f => f.Requester)
                .WithMany(u => u.SentFriendships)
                .HasForeignKey(f => f.RequesterId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Friendships>()
                .HasOne(f => f.Receiver)
                .WithMany(u => u.ReceivedFriendships)
                .HasForeignKey(f => f.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Mentor>()
                .HasOne(r => r.Monitor)
                .WithMany(u => u.Mentors)
                .HasForeignKey(r => r.MonitorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Mentor>()
                .HasOne(r => r.Student)
                .WithMany(u => u.MonitoredBy)
                .HasForeignKey(r => r.StudentId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<UserProfiles>(p => p.UserId);

           
            modelBuilder.Entity<Tasks>()
                .HasOne(t => t.Group)
                .WithMany(g => g.Tasks)
                .HasForeignKey(t => t.GroupId)
                .IsRequired(false);
        }
    }
}
