﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnetShop.Models;

namespace dotnetShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dotnetShop.Models.Candy", b =>
                {
                    b.Property<int>("CandyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CandyId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Candies");

                    b.HasData(
                        new
                        {
                            CandyId = 13,
                            CategoryId = 4,
                            Description = "Icing bonbon sesame snaps ice cream oat cake. Soufflé gummies cookie oat cake. Sweet jujubes chocolate bar jelly beans.",
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1560008581-09826d1de69e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60",
                            ImageUrl = "https://images.unsplash.com/photo-1560008581-09826d1de69e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Vanilla sth",
                            Price = 2.43m
                        },
                        new
                        {
                            CandyId = 1,
                            CategoryId = 1,
                            Description = "Soufflé croissant chupa chups cupcake brownie sweet roll biscuit cookie topping. Candy canes caramels jelly-o tart cookie. Lollipop apple pie jujubes jelly beans marshmallow chocolate bar chupa chups jelly beans.",
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80",
                            ImageUrl = "https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Licorice",
                            Price = 3.5m
                        },
                        new
                        {
                            CandyId = 2,
                            CategoryId = 2,
                            Description = "Ice cream candy fruitcake marzipan wafer carrot cake macaroon. Sugar plum powder lollipop cupcake pastry danish oat cake icing. Icing marzipan pastry caramels gummi bears gingerbread wafer toffee.",
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60",
                            ImageUrl = "https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Dark Chocolate",
                            Price = 2.5m
                        },
                        new
                        {
                            CandyId = 3,
                            CategoryId = 3,
                            Description = "Cake chupa chups cheesecake chupa chups donut. Topping chocolate bar danish. Jelly lollipop jelly gummi bears soufflé chocolate cake cake dessert. Bear claw pastry ice cream pastry topping jelly cotton candy fruitcake tart.",
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60",
                            ImageUrl = "https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Fruit bowl",
                            Price = 4.5m
                        },
                        new
                        {
                            CandyId = 5,
                            CategoryId = 1,
                            Description = "Soufflé croissant chupa chups cupcake brownie sweet roll biscuit cookie topping. Candy canes caramels jelly-o tart cookie. Lollipop apple pie jujubes jelly beans marshmallow chocolate bar chupa chups jelly beans.",
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80",
                            ImageUrl = "https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "More Licorice",
                            Price = 3.5m
                        },
                        new
                        {
                            CandyId = 6,
                            CategoryId = 2,
                            Description = "Ice cream candy fruitcake marzipan wafer carrot cake macaroon. Sugar plum powder lollipop cupcake pastry danish oat cake icing. Icing marzipan pastry caramels gummi bears gingerbread wafer toffee.",
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60",
                            ImageUrl = "https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Light Chocolate",
                            Price = 2.5m
                        },
                        new
                        {
                            CandyId = 7,
                            CategoryId = 3,
                            Description = "Cake chupa chups cheesecake chupa chups donut. Topping chocolate bar danish. Jelly lollipop jelly gummi bears soufflé chocolate cake cake dessert. Bear claw pastry ice cream pastry topping jelly cotton candy fruitcake tart.",
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60",
                            ImageUrl = "https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Fruit punch",
                            Price = 4.5m
                        },
                        new
                        {
                            CandyId = 8,
                            CategoryId = 4,
                            Description = "Icing bonbon sesame snaps ice cream oat cake. Soufflé gummies cookie oat cake. Sweet jujubes chocolate bar jelly beans.",
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1560008581-09826d1de69e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60",
                            ImageUrl = "https://images.unsplash.com/photo-1560008581-09826d1de69e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Vanilla lala",
                            Price = 2.43m
                        },
                        new
                        {
                            CandyId = 9,
                            CategoryId = 1,
                            Description = "Soufflé croissant chupa chups cupcake brownie sweet roll biscuit cookie topping. Candy canes caramels jelly-o tart cookie. Lollipop apple pie jujubes jelly beans marshmallow chocolate bar chupa chups jelly beans.",
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80",
                            ImageUrl = "https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Salty Licorice",
                            Price = 3.5m
                        },
                        new
                        {
                            CandyId = 10,
                            CategoryId = 2,
                            Description = "Ice cream candy fruitcake marzipan wafer carrot cake macaroon. Sugar plum powder lollipop cupcake pastry danish oat cake icing. Icing marzipan pastry caramels gummi bears gingerbread wafer toffee.",
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60",
                            ImageUrl = "https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Nut Chocolate",
                            Price = 2.5m
                        },
                        new
                        {
                            CandyId = 11,
                            CategoryId = 3,
                            Description = "Cake chupa chups cheesecake chupa chups donut. Topping chocolate bar danish. Jelly lollipop jelly gummi bears soufflé chocolate cake cake dessert. Bear claw pastry ice cream pastry topping jelly cotton candy fruitcake tart.",
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60",
                            ImageUrl = "https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Apple chips",
                            Price = 4.5m
                        },
                        new
                        {
                            CandyId = 12,
                            CategoryId = 4,
                            Description = "Icing bonbon sesame snaps ice cream oat cake. Soufflé gummies cookie oat cake. Sweet jujubes chocolate bar jelly beans.",
                            ImageThumbnailUrl = "https://images.unsplash.com/photo-1560008581-09826d1de69e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60",
                            ImageUrl = "https://images.unsplash.com/photo-1560008581-09826d1de69e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Vanillaaaaa",
                            Price = 2.43m
                        });
                });

            modelBuilder.Entity("dotnetShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescription = "Best of Denmark",
                            CategoryName = "Licorice"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescription = "Blocks of Happiness",
                            CategoryName = "Chocolates"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescription = "Like real fruit, just without nutrition value",
                            CategoryName = "Fruit Candy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryDescription = "Very plain",
                            CategoryName = "Vanilla Candy"
                        });
                });

            modelBuilder.Entity("dotnetShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CandyId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("CandyId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("dotnetShop.Models.Candy", b =>
                {
                    b.HasOne("dotnetShop.Models.Category", "Category")
                        .WithMany("Candies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dotnetShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("dotnetShop.Models.Candy", "Candy")
                        .WithMany()
                        .HasForeignKey("CandyId");
                });
#pragma warning restore 612, 618
        }
    }
}
