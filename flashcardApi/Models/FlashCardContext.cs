using Microsoft.EntityFrameworkCore;

namespace FlashcardApi.Models
{
    public class FlashCardContext : DbContext
    {
        public FlashCardContext(DbContextOptions<FlashCardContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>()
                .HasOne(t => t.Deck)
                .WithMany(u => u.Cards);

            modelBuilder.Entity<Card>()
            .Navigation(t => t.Deck)
            .UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<Question>()
                .HasOne(t => t.Quiz)
                .WithMany(u => u.Questions);

            modelBuilder.Entity<Question>()
            .Navigation(t => t.Quiz)
            .UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<Deck>()
                .HasOne(t => t.User)
                .WithMany(u => u.Decks);

            modelBuilder.Entity<Deck>()
            .Navigation(t => t.User)
            .UsePropertyAccessMode(PropertyAccessMode.Property);

            modelBuilder.Entity<Quiz>()
                .HasOne(t => t.User)
                .WithMany(u => u.Quizzes);

            modelBuilder.Entity<Quiz>()
            .Navigation(t => t.User)
            .UsePropertyAccessMode(PropertyAccessMode.Property);
        }



    }

}
