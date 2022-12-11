using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class FinalUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "StoKMh" },
                values: new object[] { 450m, 2.1000000000000001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 420m);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 430m);

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "ColorId", "Description", "ImagePath", "Model", "Price", "StoKMh" },
                values: new object[,]
                {
                    { 4, 5, "Exactly 50 years on from the debut of the last spider in the Ferrari range to sport a front-mounted V12, the 812 GTS hails a triumphant return for a model type that has played a pivotal role in the marque’s history since its foundation.", "https://profiauto.pl/blog/wp-content/uploads/2022/05/Ferrari-SP48-Unica.jpg", "Ferrari 812 GTS", 480m, 3.0 },
                    { 5, 8, "From the outside, the design of the Ferrari 296 GTB borrows heavily from the larger SF90 as well as the classic 1960s Ferrari 250 LM.", "https://profiauto.pl/blog/wp-content/uploads/2021/06/Ferrari-296-GTB-hybryda-z-V6.jpg", "Ferrari 296 GTB", 470m, 2.5 },
                    { 6, 7, "The sky overhead appears just 14 seconds after pressing the button, and the entire operation of opening and folding the roof can be carried out while driving.", "https://profiauto.pl/blog/wp-content/uploads/2020/11/Ferrari-SF90-Spider-hybryda-plug-in-z-napedem-na-4-kola-i-moca-1000-KM.jpg", "Ferrari SF90 Spider", 500m, 2.75 },
                    { 7, 5, "Thanks to the changes made, the Ferrari SF90 Stradale produces 780 hp and 800 Nm of torque. An additional 217 hp is provided by three electric motors - two located at the front and one located between the engine and gearbox. The total power of the propulsion system is reportedly 1000 hp.", "https://profiauto.pl/blog/wp-content/uploads/2019/05/Ferrari-SF90-Stradale.jpg", "Ferrari SF90 Stradale", 490m, 2.6499999999999999 },
                    { 8, 3, "Pista is Italian for track. This nickname was given by Ferrari to the successor of the 458 Speciale, revealing its main asset at the outset. Ladies and gentlemen, this is the Ferrari 488 Pista.", "https://profiauto.pl/blog/wp-content/uploads/2018/02/Ferrari-488-Pista.jpg", "Ferrari 488 Pista", 510m, 3.1000000000000001 },
                    { 9, 1, "To improve high-speed stability, the Ferrari F8 Spider features a two-piece carbon fiber front spoiler. Carbon has also been spared on the door handles, mirrors, engine cover and rear wing. The entire bodywork was fine-tuned for aerodynamics in the wind tunnel.", "https://profiauto.pl/blog/wp-content/uploads/2021/09/Ferrari-F8-Spider-Novitec.jpg", "Ferrari F8 Spider Novitec", 415m, 2.7999999999999998 },
                    { 10, 3, "Particularly noteworthy is the rear fins, which dissipate heat from the engine compartment and, together with the powerful diffuser, provide the right downforce. At a speed of 200 km/h, it is as much as 240 kg.", "https://profiauto.pl/blog/wp-content/uploads/2021/11/Ferrari-Daytona-SP3.jpg", "Ferrari Daytona SP3", 560m, 2.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "StoKMh" },
                values: new object[] { 274280m, 2.8999999999999999 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 230950m);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 601570m);
        }
    }
}
