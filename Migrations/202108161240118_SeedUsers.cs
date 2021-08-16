namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'488d3107-3b5d-4504-bcca-f72273bda981', N'admin@gmail.com', 0, N'ANlkI7mHpqMLBxRoqKTjpmMMoYqI7ZwFHTHGI704CvkPUxqsU87ZGa6AAbYTF4G6aQ==', N'6515b835-b6cb-485e-a0ff-8f028e532834', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a61816ba-5c10-4f7a-b68d-c09dd24c14c5', N'admin@vidly.com', 0, N'AO3H4GYGanG/WxMFmSYgnvh2lLKBRLOZvmCfrI0LxIMMr531Nk7lAaBoIjNhLLoNeg==', N'34bf8eb3-d7ef-4423-b0e7-8a511370d306', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bc977f9f-66a8-4de3-a537-773b87b7ac03', N'guest@gmail.com', 0, N'AL8u4Ij4g/GpD6WcvB71WN0MFXHgL7v/AE1tcrWXKgDqEzS9zuVpEw9OtjPv/P0D8A==', N'510e7fd0-b5b1-4255-95ca-150dd7214689', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'eab7ca33-e0da-4faf-831d-d07eeaabebd7', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a61816ba-5c10-4f7a-b68d-c09dd24c14c5', N'eab7ca33-e0da-4faf-831d-d07eeaabebd7')


");

        }
        
        public override void Down()
        {
        }
    }
}
