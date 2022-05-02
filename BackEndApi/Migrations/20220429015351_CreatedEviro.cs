using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndApi.Migrations
{
    public partial class CreatedEviro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "TicketID");

            migrationBuilder.RenameColumn(
                name: "RequestTitle",
                table: "Tickets",
                newName: "SubmitterName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Tickets",
                newName: "SubmitterEmail");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Tickets",
                newName: "SubjectLine");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Tickets",
                newName: "TicketID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "TicketID",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "SubmitterName",
                table: "Tickets",
                newName: "RequestTitle");

            migrationBuilder.RenameColumn(
                name: "SubmitterEmail",
                table: "Tickets",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SubjectLine",
                table: "Tickets",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "TicketID",
                table: "Tickets",
                newName: "ID");
        }
    }
}
