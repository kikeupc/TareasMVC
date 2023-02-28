using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
IF NOT EXISTS(SELECT id FROM AspNetRoles WHERE id='26039c04-4dd1-43bf-88e3-946ab4b79ae7')
BEGIN
	INSERT AspNetRoles(id, [name], normalizedname)
	VALUES('26039c04-4dd1-43bf-88e3-946ab4b79ae7','admin','ADMIN')
END
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE AspNetRoles WHERE Id = '26039c04-4dd1-43bf-88e3-946ab4b79ae7'");
        }
    }
}
