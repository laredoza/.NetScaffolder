using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.SqlServer.Migrations
{
    public partial class V7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ApiResource",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiResource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRole",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUser",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<string>(maxLength: 100, nullable: false),
                    ClientName = table.Column<string>(maxLength: 50, nullable: false),
                    AlwaysSendClientClaims = table.Column<bool>(nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrantType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrantType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityResource",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    DisplayName = table.Column<string>(maxLength: 50, nullable: false),
                    ShowInDiscoveryDocument = table.Column<bool>(nullable: false),
                    Required = table.Column<bool>(nullable: false),
                    Emphasize = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityResource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResourceClaimType",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceClaimType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaim",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaim_AspNetRole_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "AspNetRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaim",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaim_AspNetUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogin",
                schema: "dbo",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogin_AspNetUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRole",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRole_AspNetRole_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "AspNetRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRole_AspNetUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserToken",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserToken_AspNetUser_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "AspNetUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientSecret",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    Secret = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientSecret", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientSecret_Client_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "dbo",
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AllowedScope",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    ResourceName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowedScope", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AllowedScope_Client_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "dbo",
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostLogoutRedirectUri",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    Uri = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostLogoutRedirectUri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostLogoutRedirectUri_Client_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "dbo",
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RedirectUri",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    Uri = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedirectUri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RedirectUri_Client_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "dbo",
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientGrantType",
                schema: "dbo",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false),
                    GrantTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientGrantType", x => new { x.ClientId, x.GrantTypeId });
                    table.ForeignKey(
                        name: "FK_ClientGrantType_Client_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "dbo",
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientGrantType_GrantType_GrantTypeId",
                        column: x => x.GrantTypeId,
                        principalSchema: "dbo",
                        principalTable: "GrantType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IdentityResourceClaimType",
                schema: "dbo",
                columns: table => new
                {
                    IdentityResourceId = table.Column<int>(nullable: false),
                    ResourceClaimTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityResourceClaimType", x => new { x.IdentityResourceId, x.ResourceClaimTypeId });
                    table.ForeignKey(
                        name: "FK_IdentityResourceClaimType_IdentityResource_IdentityResourceId",
                        column: x => x.IdentityResourceId,
                        principalSchema: "dbo",
                        principalTable: "IdentityResource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IdentityResourceClaimType_ResourceClaimType_ResourceClaimTypeId",
                        column: x => x.ResourceClaimTypeId,
                        principalSchema: "dbo",
                        principalTable: "ResourceClaimType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("31dde1b8-8435-408f-a4fd-ecca6d193a78"), "2/25/2019 7:03:46 AM", "Admin", "admin" },
                    { new Guid("481e6e87-5a91-40a7-9ac9-5d1a0730a0f0"), "2/25/2019 7:03:46 AM", "User", "user" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a5655a7e-6296-41ad-85ab-1a15e582bf13"), 0, "2/25/2019 7:03:46 AM", "alice@alice.com", true, false, null, "alice@alice.com", "alice", "AQAAAAEAACcQAAAAEO62KjeNXcKGs8/nLbN36hfCYBu2iXmTUjNLdeqgCmOujUF9x6R19UPPvgfdbSjHlg==", "123#", true, "2/25/2019 7:03:46 AM", false, "Alice" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Client",
                columns: new[] { "Id", "Active", "AlwaysSendClientClaims", "ClientId", "ClientName" },
                values: new object[,]
                {
                    { 1, true, true, "mvc", "MVC Hybrid Client" },
                    { 2, true, true, "client", "Api Client" },
                    { 3, true, true, "ro.client", "Console Client" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "GrantType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ClientCredentials" },
                    { 2, "Code" },
                    { 3, "CodeAndClientCredentials" },
                    { 4, "DeviceFlow" },
                    { 5, "Hybrid" },
                    { 6, "HybridAndClientCredentials" },
                    { 7, "Implicit" },
                    { 8, "ImplicitAndClientCredentials" },
                    { 9, "ResourceOwnerPassword" },
                    { 10, "ResourceOwnerPasswordAndClientCredentials" }
                });

            migrationBuilder.InsertData(
                table: "ClientSecret",
                columns: new[] { "Id", "ClientId", "Secret" },
                values: new object[,]
                {
                    { 3, 3, "K7gNU3sdo+OL0wNhqoVWhr3g6s1xYv72ol/pe/Unols=" },
                    { 2, 2, "K7gNU3sdo+OL0wNhqoVWhr3g6s1xYv72ol/pe/Unols=" },
                    { 1, 1, "K7gNU3sdo+OL0wNhqoVWhr3g6s1xYv72ol/pe/Unols=" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AllowedScope",
                columns: new[] { "Id", "ClientId", "ResourceName" },
                values: new object[,]
                {
                    { 4, 1, "roles" },
                    { 7, 3, "api1" },
                    { 6, 2, "api1" },
                    { 5, 1, "api1" },
                    { 1, 1, "openid" },
                    { 2, 1, "profile" },
                    { 3, 1, "email" }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetUserClaim",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "name", "Alice", new Guid("a5655a7e-6296-41ad-85ab-1a15e582bf13") },
                    { 4, "role", "User", new Guid("a5655a7e-6296-41ad-85ab-1a15e582bf13") },
                    { 3, "email", "alice@alice.com", new Guid("a5655a7e-6296-41ad-85ab-1a15e582bf13") },
                    { 2, "website", "https://alice.com", new Guid("a5655a7e-6296-41ad-85ab-1a15e582bf13") }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetUserLogin",
                columns: new[] { "LoginProvider", "ProviderKey", "ProviderDisplayName", "UserId" },
                values: new object[] { "IdentityServer4", "IdentityServer4", "IdentityServer4", new Guid("a5655a7e-6296-41ad-85ab-1a15e582bf13") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetUserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("a5655a7e-6296-41ad-85ab-1a15e582bf13"), new Guid("31dde1b8-8435-408f-a4fd-ecca6d193a78") });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "AspNetUserToken",
                columns: new[] { "UserId", "LoginProvider", "Name", "Value" },
                values: new object[] { new Guid("a5655a7e-6296-41ad-85ab-1a15e582bf13"), "IdentityServer4", "Alice", "Alice" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ClientGrantType",
                columns: new[] { "ClientId", "GrantTypeId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 5 },
                    { 3, 9 }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "PostLogoutRedirectUri",
                columns: new[] { "Id", "ClientId", "Uri" },
                values: new object[] { 1, 1, "http://localhost:5002/signout-callback-oidc" });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "RedirectUri",
                columns: new[] { "Id", "ClientId", "Uri" },
                values: new object[] { 1, 1, "http://localhost:5002/signin-oidc" });

            migrationBuilder.CreateIndex(
                name: "IX_ClientSecret_ClientId",
                table: "ClientSecret",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_AllowedScope_ClientId",
                schema: "dbo",
                table: "AllowedScope",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "dbo",
                table: "AspNetRole",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "dbo",
                table: "AspNetRoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "dbo",
                table: "AspNetUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "dbo",
                table: "AspNetUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "dbo",
                table: "AspNetUserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "dbo",
                table: "AspNetUserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "dbo",
                table: "AspNetUserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientGrantType_GrantTypeId",
                schema: "dbo",
                table: "ClientGrantType",
                column: "GrantTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityResourceClaimType_ResourceClaimTypeId",
                schema: "dbo",
                table: "IdentityResourceClaimType",
                column: "ResourceClaimTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLogoutRedirectUri_ClientId",
                schema: "dbo",
                table: "PostLogoutRedirectUri",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_RedirectUri_ClientId",
                schema: "dbo",
                table: "RedirectUri",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientSecret");

            migrationBuilder.DropTable(
                name: "AllowedScope",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ApiResource",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaim",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUserClaim",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUserLogin",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUserRole",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUserToken",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ClientGrantType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "IdentityResourceClaimType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PostLogoutRedirectUri",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "RedirectUri",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetRole",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AspNetUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GrantType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "IdentityResource",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ResourceClaimType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Client",
                schema: "dbo");
        }
    }
}
