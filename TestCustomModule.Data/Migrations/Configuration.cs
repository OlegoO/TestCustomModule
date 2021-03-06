namespace TestCustomModule.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TestCustomModule.Data.Model;

    public sealed class Configuration : DbMigrationsConfiguration<TestCustomModule.Data.Repositories.CustomerReviewRepository>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(TestCustomModule.Data.Repositories.CustomerReviewRepository context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var now = DateTime.UtcNow;
            context.AddOrUpdate(new CustomerReviewEntity { Id = "1", ProductId = "0f7a77cc1b9a46a29f6a159e5cd49ad1", CreatedDate = now, CreatedBy = "initial data seed", AuthorNickname = "Andrew Peters", Content = "Super!", Rating = 1 });
            context.AddOrUpdate(new CustomerReviewEntity { Id = "2", ProductId = "0f7a77cc1b9a46a29f6a159e5cd49ad1", CreatedDate = now, CreatedBy = "initial data seed", AuthorNickname = "Mr. Pumpkin", Content = "So so", Rating = 3 });
            context.AddOrUpdate(new CustomerReviewEntity { Id = "3", ProductId = "0f7a77cc1b9a46a29f6a159e5cd49ad1", CreatedDate = now, CreatedBy = "initial data seed", AuthorNickname = "John Doe", Content = "Liked that", Rating = 5 });

			context.AddOrUpdate(new ProductRatingEntity { Id = "1", ProductId = "0f7a77cc1b9a46a29f6a159e5cd49ad1", CreatedDate = now, CreatedBy = "initial data seed", Rating = 3 });
		}
	}
}
