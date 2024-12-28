using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GAMMOV.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class changeSeoData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeoData_Categories_CategoryId",
                table: "SeoData");

            migrationBuilder.DropForeignKey(
                name: "FK_SeoData_Posts_PostId",
                table: "SeoData");

            migrationBuilder.DropForeignKey(
                name: "FK_SeoData_SiteSettings_SiteSettingId",
                table: "SeoData");

            migrationBuilder.DropForeignKey(
                name: "FK_SeoData_Tags_TagId",
                table: "SeoData");

            migrationBuilder.DropIndex(
                name: "IX_SeoData_CategoryId",
                table: "SeoData");

            migrationBuilder.DropIndex(
                name: "IX_SeoData_PostId",
                table: "SeoData");

            migrationBuilder.DropIndex(
                name: "IX_SeoData_SiteSettingId",
                table: "SeoData");

            migrationBuilder.DropIndex(
                name: "IX_SeoData_TagId",
                table: "SeoData");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "SeoData");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "SeoData");

            migrationBuilder.DropColumn(
                name: "SiteSettingId",
                table: "SeoData");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "SeoData");

            migrationBuilder.AddColumn<int>(
                name: "SeoDataId",
                table: "Tags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeoDataId",
                table: "SiteSettings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeoDataId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeoDataId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_SeoDataId",
                table: "Tags",
                column: "SeoDataId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteSettings_SeoDataId",
                table: "SiteSettings",
                column: "SeoDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_SeoDataId",
                table: "Posts",
                column: "SeoDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SeoDataId",
                table: "Categories",
                column: "SeoDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_SeoData_SeoDataId",
                table: "Categories",
                column: "SeoDataId",
                principalTable: "SeoData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_SeoData_SeoDataId",
                table: "Posts",
                column: "SeoDataId",
                principalTable: "SeoData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteSettings_SeoData_SeoDataId",
                table: "SiteSettings",
                column: "SeoDataId",
                principalTable: "SeoData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_SeoData_SeoDataId",
                table: "Tags",
                column: "SeoDataId",
                principalTable: "SeoData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_SeoData_SeoDataId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_SeoData_SeoDataId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteSettings_SeoData_SeoDataId",
                table: "SiteSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_SeoData_SeoDataId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_SeoDataId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_SiteSettings_SeoDataId",
                table: "SiteSettings");

            migrationBuilder.DropIndex(
                name: "IX_Posts_SeoDataId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SeoDataId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SeoDataId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "SeoDataId",
                table: "SiteSettings");

            migrationBuilder.DropColumn(
                name: "SeoDataId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "SeoDataId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "SeoData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "SeoData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteSettingId",
                table: "SeoData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "SeoData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SeoData_CategoryId",
                table: "SeoData",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeoData_PostId",
                table: "SeoData",
                column: "PostId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeoData_SiteSettingId",
                table: "SeoData",
                column: "SiteSettingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SeoData_TagId",
                table: "SeoData",
                column: "TagId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SeoData_Categories_CategoryId",
                table: "SeoData",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeoData_Posts_PostId",
                table: "SeoData",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeoData_SiteSettings_SiteSettingId",
                table: "SeoData",
                column: "SiteSettingId",
                principalTable: "SiteSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeoData_Tags_TagId",
                table: "SeoData",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
