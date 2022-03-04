using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "59db5157-3639-4edc-91f1-37007a7a4caf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "91f1e630-dfa1-401c-92f6-414962afa24b", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd5d53cb-1570-4184-9b70-56bdaee26527", "AQAAAAEAACcQAAAAEEtFmdkt8/SWRIR7H/xF6u84TAZvHk3j3sIE+wJ6a+P3nAXFNpYPJK8VZA6cIT3D/w==", "9ba4a4b6-d229-48d4-801b-f2f8ca30cdd0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "2991035a-48b1-4f4c-b452-60ee18582789");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0c65187-2e20-42b2-999a-76d0168633ef", "AQAAAAEAACcQAAAAEHh1MCXIHnQZOF6P/0zI5bakerdGZcA6W0crT6tOqttq+Ah3JIW2Awue+IOL9cHHaA==", "40c9af06-a1f6-46de-9fde-9acabfc251b7" });
        }
    }
}
