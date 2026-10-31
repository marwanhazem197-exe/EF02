using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF02.Migrations
{
    /// <inheritdoc />
    public partial class Realtions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizerId",
                table: "organizerProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganizerId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AttendeeId",
                table: "Badges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_organizerProfiles_OrganizerId",
                table: "organizerProfiles",
                column: "OrganizerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_OrganizerId",
                table: "Events",
                column: "OrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_Badges_AttendeeId",
                table: "Badges",
                column: "AttendeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Badges_Attendees_AttendeeId",
                table: "Badges",
                column: "AttendeeId",
                principalTable: "Attendees",
                principalColumn: "AttendeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventOrganizers_OrganizerId",
                table: "Events",
                column: "OrganizerId",
                principalTable: "EventOrganizers",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_organizerProfiles_EventOrganizers_OrganizerId",
                table: "organizerProfiles",
                column: "OrganizerId",
                principalTable: "EventOrganizers",
                principalColumn: "OrgId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Badges_Attendees_AttendeeId",
                table: "Badges");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventOrganizers_OrganizerId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_organizerProfiles_EventOrganizers_OrganizerId",
                table: "organizerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_organizerProfiles_OrganizerId",
                table: "organizerProfiles");

            migrationBuilder.DropIndex(
                name: "IX_Events_OrganizerId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Badges_AttendeeId",
                table: "Badges");

            migrationBuilder.DropColumn(
                name: "OrganizerId",
                table: "organizerProfiles");

            migrationBuilder.DropColumn(
                name: "OrganizerId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "AttendeeId",
                table: "Badges");
        }
    }
}
