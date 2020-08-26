using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetShop.Migrations
{
    public partial class seedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Best of Denmark", "Licorice" },
                    { 2, "Blocks of Happiness", "Chocolates" },
                    { 3, "Like real fruit, just without nutrition value", "Fruit Candy" },
                    { 4, "Very plain", "Vanilla Candy" }
                });

            migrationBuilder.InsertData(
                table: "Candies",
                columns: new[] { "CandyId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Soufflé croissant chupa chups cupcake brownie sweet roll biscuit cookie topping. Candy canes caramels jelly-o tart cookie. Lollipop apple pie jujubes jelly beans marshmallow chocolate bar chupa chups jelly beans.", "https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80", "https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80", true, false, "Assorted Licorice", 3.5m },
                    { 5, 1, "Soufflé croissant chupa chups cupcake brownie sweet roll biscuit cookie topping. Candy canes caramels jelly-o tart cookie. Lollipop apple pie jujubes jelly beans marshmallow chocolate bar chupa chups jelly beans.", "https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80", "https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80", true, false, "More Licorice", 3.5m },
                    { 9, 1, "Soufflé croissant chupa chups cupcake brownie sweet roll biscuit cookie topping. Candy canes caramels jelly-o tart cookie. Lollipop apple pie jujubes jelly beans marshmallow chocolate bar chupa chups jelly beans.", "https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80", "https://images.unsplash.com/photo-1564424541861-6c68eb0a4309?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1347&q=80", true, false, "Salty Licorice", 3.5m },
                    { 2, 2, "Ice cream candy fruitcake marzipan wafer carrot cake macaroon. Sugar plum powder lollipop cupcake pastry danish oat cake icing. Icing marzipan pastry caramels gummi bears gingerbread wafer toffee.", "https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", "https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", true, false, "Dark Chocolate", 2.5m },
                    { 6, 2, "Ice cream candy fruitcake marzipan wafer carrot cake macaroon. Sugar plum powder lollipop cupcake pastry danish oat cake icing. Icing marzipan pastry caramels gummi bears gingerbread wafer toffee.", "https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", "https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", true, false, "Light Chocolate", 2.5m },
                    { 10, 2, "Ice cream candy fruitcake marzipan wafer carrot cake macaroon. Sugar plum powder lollipop cupcake pastry danish oat cake icing. Icing marzipan pastry caramels gummi bears gingerbread wafer toffee.", "https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", "https://images.unsplash.com/photo-1575377427642-087cf684f29d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", true, false, "Nut Chocolate", 2.5m },
                    { 3, 3, "Cake chupa chups cheesecake chupa chups donut. Topping chocolate bar danish. Jelly lollipop jelly gummi bears soufflé chocolate cake cake dessert. Bear claw pastry ice cream pastry topping jelly cotton candy fruitcake tart.", "https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", "https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", true, false, "Fruit bowl", 4.5m },
                    { 7, 3, "Cake chupa chups cheesecake chupa chups donut. Topping chocolate bar danish. Jelly lollipop jelly gummi bears soufflé chocolate cake cake dessert. Bear claw pastry ice cream pastry topping jelly cotton candy fruitcake tart.", "https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", "https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", true, false, "Fruit punch", 4.5m },
                    { 11, 3, "Cake chupa chups cheesecake chupa chups donut. Topping chocolate bar danish. Jelly lollipop jelly gummi bears soufflé chocolate cake cake dessert. Bear claw pastry ice cream pastry topping jelly cotton candy fruitcake tart.", "https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", "https://images.unsplash.com/photo-1554908081-267299e53de8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=400&q=60", true, false, "Apple chips", 4.5m },
                    { 13, 4, "Icing bonbon sesame snaps ice cream oat cake. Soufflé gummies cookie oat cake. Sweet jujubes chocolate bar jelly beans.", "https://images.unsplash.com/photo-1560008581-09826d1de69e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1560008581-09826d1de69e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60", true, true, "Vanilla sth", 2.43m },
                    { 8, 4, "Icing bonbon sesame snaps ice cream oat cake. Soufflé gummies cookie oat cake. Sweet jujubes chocolate bar jelly beans.", "https://images.unsplash.com/photo-1560008581-09826d1de69e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1560008581-09826d1de69e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60", true, true, "Vanilla lala", 2.43m },
                    { 12, 4, "Icing bonbon sesame snaps ice cream oat cake. Soufflé gummies cookie oat cake. Sweet jujubes chocolate bar jelly beans.", "https://images.unsplash.com/photo-1560008581-09826d1de69e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1560008581-09826d1de69e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=500&q=60", true, true, "Vanillaaaaa", 2.43m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Candies",
                keyColumn: "CandyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
