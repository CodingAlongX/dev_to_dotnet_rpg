using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dev_to_dotnet_rpg.Migrations
{
    public partial class FinalSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new byte[] { 106, 248, 110, 203, 234, 208, 50, 186, 87, 141, 242, 206, 218, 87, 156, 57, 90, 194, 242, 16, 15, 119, 193, 254, 172, 203, 220, 56, 74, 176, 47, 106, 18, 62, 23, 15, 135, 137, 68, 190, 4, 60, 212, 51, 110, 87, 35, 125, 164, 127, 106, 79, 139, 55, 250, 13, 134, 194, 199, 136, 111, 54, 90, 30 }, new byte[] { 52, 150, 210, 43, 229, 177, 184, 163, 21, 175, 4, 179, 210, 59, 207, 1, 172, 207, 90, 227, 169, 172, 75, 58, 21, 55, 95, 129, 230, 97, 81, 233, 224, 180, 3, 237, 203, 135, 31, 110, 152, 3, 46, 127, 87, 103, 22, 78, 220, 158, 185, 127, 20, 152, 145, 116, 48, 255, 246, 7, 245, 190, 112, 90, 169, 127, 201, 126, 48, 198, 52, 184, 254, 68, 237, 239, 60, 68, 135, 115, 117, 247, 248, 74, 134, 209, 233, 211, 28, 165, 115, 209, 178, 221, 30, 144, 173, 94, 226, 167, 141, 179, 128, 33, 6, 211, 88, 214, 150, 236, 129, 151, 123, 129, 247, 173, 104, 105, 118, 215, 58, 117, 97, 193, 160, 10, 119, 35 }, "user1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, new byte[] { 106, 248, 110, 203, 234, 208, 50, 186, 87, 141, 242, 206, 218, 87, 156, 57, 90, 194, 242, 16, 15, 119, 193, 254, 172, 203, 220, 56, 74, 176, 47, 106, 18, 62, 23, 15, 135, 137, 68, 190, 4, 60, 212, 51, 110, 87, 35, 125, 164, 127, 106, 79, 139, 55, 250, 13, 134, 194, 199, 136, 111, 54, 90, 30 }, new byte[] { 52, 150, 210, 43, 229, 177, 184, 163, 21, 175, 4, 179, 210, 59, 207, 1, 172, 207, 90, 227, 169, 172, 75, 58, 21, 55, 95, 129, 230, 97, 81, 233, 224, 180, 3, 237, 203, 135, 31, 110, 152, 3, 46, 127, 87, 103, 22, 78, 220, 158, 185, 127, 20, 152, 145, 116, 48, 255, 246, 7, 245, 190, 112, 90, 169, 127, 201, 126, 48, 198, 52, 184, 254, 68, 237, 239, 60, 68, 135, 115, 117, 247, 248, 74, 134, 209, 233, 211, 28, 165, 115, 209, 178, 221, 30, 144, 173, 94, 226, 167, 141, 179, 128, 33, 6, 211, 88, 214, 150, 236, 129, 151, 123, 129, 247, 173, 104, 105, 118, 215, 58, 117, 97, 193, 160, 10, 119, 35 }, "user2" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 1, 1, 0, 10, 0, 100, 10, "Frodo", 15, 1, 0 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 2, 2, 0, 5, 0, 100, 20, "Raistlin", 5, 2, 0 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 1, 1, 20, "The Master Sword" });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 2, 2, 5, "Crystal Wand" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
