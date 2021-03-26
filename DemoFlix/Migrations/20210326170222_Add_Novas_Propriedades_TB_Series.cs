using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoFlix.Migrations
{
    public partial class Add_Novas_Propriedades_TB_Series : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Series",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Series");
        }
    }
}
