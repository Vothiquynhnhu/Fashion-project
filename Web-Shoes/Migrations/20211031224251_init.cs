using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_Shoes.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    about_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    about_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.about_id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    cg_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cg_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Sale = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.cg_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactSystems",
                columns: table => new
                {
                    Contact_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactSystems", x => x.Contact_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsers",
                columns: table => new
                {
                    cu_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cu_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsers", x => x.cu_Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    couponId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    couponCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    couponPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.couponId);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    deviceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    deviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devicePostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devicePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.deviceId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    pd_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pd_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Price = table.Column<int>(type: "int", nullable: false),
                    pd_ReducePrice = table.Column<int>(type: "int", nullable: false),
                    pd_NameImg1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Rate = table.Column<int>(type: "int", nullable: false),
                    pd_MenuFacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Size7 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size7_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size8 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size8_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size9 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size9_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size10 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size10_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size11 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size11_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size12 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size12_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size13 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size13_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size14 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size14_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Technologies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_WaitForConfirmation = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.pd_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    ship_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ship_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ship_Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.ship_Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInRoleModel",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameRole = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInRoleModel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    bill_Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartsDevice",
                columns: table => new
                {
                    cartd_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cartd_DeviceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cartd_Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartsDevice", x => x.cartd_Id);
                    table.ForeignKey(
                        name: "FK_CartsDevice_Device_cartd_DeviceId",
                        column: x => x.cartd_DeviceId,
                        principalTable: "Device",
                        principalColumn: "deviceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductsInCategories",
                columns: table => new
                {
                    pic_CategoriesId = table.Column<int>(type: "int", nullable: false),
                    pic_productId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInCategories", x => new { x.pic_productId, x.pic_CategoriesId });
                    table.ForeignKey(
                        name: "FK_ProductsInCategories_Categories_pic_CategoriesId",
                        column: x => x.pic_CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "cg_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsInCategories_Products_pic_productId",
                        column: x => x.pic_productId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    bill_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bill_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    bill_PaidTotal = table.Column<int>(type: "int", nullable: false),
                    bill_ProductIdlist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductNamelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductSizelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductColorlist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductPricelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Shipping = table.Column<int>(type: "int", nullable: false),
                    bill_Discount = table.Column<int>(type: "int", nullable: false),
                    bill_Confirmation = table.Column<bool>(type: "bit", nullable: false),
                    bill_DatetimeOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bill_PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    bill_WaitForConfirmation = table.Column<bool>(type: "bit", nullable: false),
                    bill_WaitPickup = table.Column<bool>(type: "bit", nullable: false),
                    bill_Delivering = table.Column<bool>(type: "bit", nullable: false),
                    bill_Delivered = table.Column<bool>(type: "bit", nullable: false),
                    bill_Cancelled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.bill_Id);
                    table.ForeignKey(
                        name: "FK_Bills_Users_bill_UserId",
                        column: x => x.bill_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    cart_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cart_UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cart_Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.cart_Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_cart_UserID",
                        column: x => x.cart_UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    review_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    review_Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    review_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    review_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    review_ReviewType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    review_UploadTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.review_id);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_review_UserId",
                        column: x => x.review_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubReview",
                columns: table => new
                {
                    subReview_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    subReview_Commnet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subReview_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    subReview_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    subreview_SubReviewType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subReview_DateCommnet = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubReview", x => x.subReview_Id);
                    table.ForeignKey(
                        name: "FK_SubReview_Users_subReview_UserId",
                        column: x => x.subReview_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    wl_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wl_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.wl_Id);
                    table.ForeignKey(
                        name: "FK_Wishlists_Users_wl_UserId",
                        column: x => x.wl_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCartDevices",
                columns: table => new
                {
                    picd_CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    picd_ProductId = table.Column<int>(type: "int", nullable: false),
                    picd_amount = table.Column<int>(type: "int", nullable: false),
                    picd_size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    picd_color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCartDevices", x => new { x.picd_CartId, x.picd_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCartDevices_CartsDevice_picd_CartId",
                        column: x => x.picd_CartId,
                        principalTable: "CartsDevice",
                        principalColumn: "cartd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCartDevices_Products_picd_ProductId",
                        column: x => x.picd_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCart",
                columns: table => new
                {
                    pic_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pic_CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pic_ProductId = table.Column<int>(type: "int", nullable: false),
                    pic_amount = table.Column<int>(type: "int", nullable: false),
                    pic_size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pic_color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCart", x => new { x.pic_CartId, x.pic_ProductId, x.pic_Id });
                    table.ForeignKey(
                        name: "FK_ProductInCart_Carts_pic_CartId",
                        column: x => x.pic_CartId,
                        principalTable: "Carts",
                        principalColumn: "cart_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCart_Products_pic_ProductId",
                        column: x => x.pic_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewInproduct",
                columns: table => new
                {
                    rip_ReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    rip_ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewInproduct", x => new { x.rip_ProductId, x.rip_ReviewId });
                    table.ForeignKey(
                        name: "FK_ReviewInproduct_Products_rip_ProductId",
                        column: x => x.rip_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewInproduct_Reviews_rip_ReviewId",
                        column: x => x.rip_ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "review_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubReviewInReview",
                columns: table => new
                {
                    SRiR_ReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SRiR_SubReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubReviewInReview", x => new { x.SRiR_ReviewId, x.SRiR_SubReviewId });
                    table.ForeignKey(
                        name: "FK_SubReviewInReview_Reviews_SRiR_ReviewId",
                        column: x => x.SRiR_ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "review_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubReviewInReview_SubReview_SRiR_SubReviewId",
                        column: x => x.SRiR_SubReviewId,
                        principalTable: "SubReview",
                        principalColumn: "subReview_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInWishlist",
                columns: table => new
                {
                    piw_WishlistId = table.Column<int>(type: "int", nullable: false),
                    piw_ProductId = table.Column<int>(type: "int", nullable: false),
                    piw_amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInWishlist", x => new { x.piw_WishlistId, x.piw_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInWishlist_Products_piw_ProductId",
                        column: x => x.piw_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInWishlist_Wishlists_piw_WishlistId",
                        column: x => x.piw_WishlistId,
                        principalTable: "Wishlists",
                        principalColumn: "wl_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "about_id", "about_Description", "about_Title", "about_Url" },
                values: new object[] { 1, "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way.", "Footwear the leading eCommerce Store around the Globe", "https://www.youtube.com/watch?v=F1vcruph8JA" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { 4, "TopSeller", "", "" },
                    { 3, "BestSeller", "", "" },
                    { 2, "Man", "", "" },
                    { 1, "women", "", "" },
                    { 5, "Hangbag", "", "" }
                });

            migrationBuilder.InsertData(
                table: "ContactSystems",
                columns: new[] { "Contact_Id", "Contact_Address", "Contact_Email", "Contact_Phone", "Contact_Website" },
                values: new object[] { 1, " 123, An Lac A Ward, Binh Tan District, HCM", "admin@gmail.com", "0123456789", "https://shoes.com" });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cu_Id", "cu_Description", "cu_Email", "cu_FirstName", "cu_LastName", "cu_Subject" },
                values: new object[] { 1, "Description", "Email", "FirstName", "LastName", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "couponCode", "couponPrice" },
                values: new object[,]
                {
                    { "9b405464-e97c-4d8c-a897-1cedddcbf638", "code10", 10 },
                    { "bfee1a52-b00c-4518-b426-3e9f7a2b6733", "code50", 50 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "pd_Brand", "pd_Color", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Material", "pd_MenuFacturer", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size", "pd_Size10", "pd_Size10_5", "pd_Size11", "pd_Size11_5", "pd_Size12", "pd_Size12_5", "pd_Size13", "pd_Size13_5", "pd_Size14", "pd_Size14_5", "pd_Size7", "pd_Size7_5", "pd_Size8", "pd_Size8_5", "pd_Size9", "pd_Size9_5", "pd_Style", "pd_Technologies", "pd_WaitForConfirmation" },
                values: new object[,]
                {
                    { 22, "Supreme", "White", "", "https://drive.google.com/uc?export=download&id=1xi9IyKns4dFZD1Fyxpk4i0HkHdfkKU78", "https://drive.google.com/uc?export=download&id=1Ka9RyvnJxZRkeeDuM06N0MvfScwfDln8", "https://drive.google.com/uc?export=download&id=1IsdUB3ikPiRnKkZSKjdnG9vJS6zMESIX", "", "1", "1", "SUPREME SPIRAL T-SHIRT - WHITE", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "T-shirt", "1", false },
                    { 21, "Moschino", "Black", "", "https://drive.google.com/uc?export=download&id=1oL6TkiejPN42yqbWEv8xN-Ckah67S0xW", "https://drive.google.com/uc?export=download&id=1JdEfzri9AU-QBrlcVvVtA733KV95fo89", "https://drive.google.com/uc?export=download&id=17OhvAH_HTfZFMvQYwolkdSwGS7To7s1f", "", "1", "1", "MOSCHINO T-SHIRT COUTURE", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "T-shirt", "1", false },
                    { 20, "Moschino", "White", "", "https://drive.google.com/uc?export=download&id=1b4zWMxw2fSXDmTZsZfI5UGRW4ujKo1rN", "https://drive.google.com/uc?export=download&id=1JR9ts1KgrL0abi8u-3P60isz-alhrvo_", "", "", "1", "1", "MOSCHINO T-SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "T-shirt", "1", false },
                    { 27, "ADLV", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "https://drive.google.com/uc?export=download&id=1c8sJrSezckX9Vm0p387ikGFsU1Tuv87r", "https://drive.google.com/uc?export=download&id=1yMULMDGga8_c2lBh6j2KrMt9VN9N90hV", "https://drive.google.com/uc?export=download&id=1GUQbvk2Pa1eS3tKaxCuM_4Ow-hKPxE_w", "https://drive.google.com/uc?export=download&id=1GvhlYo8s5HMGZ0flnPnsVJ6ZRu4nEAkb", "1", "1", "ADLV ASTRONAUT TRIO SHORT SLEEVE T-SHIRT - BLACK", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 24, "eteft", "", "", "https://drive.google.com/uc?export=download&id=1WlhWQzqgCVnlI9XyNtRD8iJ0O-2Oa25L", "", "", "", "1", "1", "SUPREME CROSS BOX LOGO T-SHIRT - NAVY", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 25, "ADLV", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "https://drive.google.com/uc?export=download&id=1uBO0fPafsG1P5vmtwvgkOrcypX6H4rDY", "https://drive.google.com/uc?export=download&id=1BlxKN-HjkTHzIQW8AwUpKCSGdf22cJXj", "https://drive.google.com/uc?export=download&id=1gxUlGv7LqXuQX9uyhmbL6DW3q9QkjEqv", "https://drive.google.com/uc?export=download&id=1izxagkrKqxpOMU7SsiGLi3agg8OvuQGX", "1", "1", "ADLV BABY FACE SHORT SLEEVE T-SHIRT BLACK DONUTS 1", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 26, "ADLV", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "https://drive.google.com/uc?export=download&id=1w8KaiMGTvWcxpJMfalYcFEN_yG6Awk-9", "https://drive.google.com/uc?export=download&id=1u0R9N991JjD80tnr8ASmRiZ8kt8_D2T_", "https://drive.google.com/uc?export=download&id=1yLUSschFEI0auLqrZ8qnCkO8L534TDAp", "https://drive.google.com/uc?export=download&id=1-E6bVLQEKaq2fkR2dd96v8mWtFq_tzfi", "1", "1", "ADLV BABY FACE SHORT SLEEVE T-SHIRT BLACK ASTRONAUT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 23, "Supreme", "Black", "", "https://drive.google.com/uc?export=download&id=1bDO25ILHq2cvHXn5S1fUzRhSejVCJ-8n", "https://drive.google.com/uc?export=download&id=1Jmco4XQmd82c7Lng1WJe66crfAYMOBjD", "https://drive.google.com/uc?export=download&id=1BEODWmyDSlBEnltTR4NLBJ3KXoW6RUvS", "", "1", "1", "SUPREME SPIRAL T-SHIRT - BLACK", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "T-shirt", "1", false },
                    { 28, "ADLV", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "https://drive.google.com/uc?export=download&id=1stJaTkCT3ZXMWE_Ph_d5TLf97pmMhIF6", "https://drive.google.com/uc?export=download&id=1MyfOcOXt3aCd3Qv16_grwbVKYvKQf-ps", "https://drive.google.com/uc?export=download&id=1GJVPqfAWR-PiI_Eg5A01QxSfXYubq41F", "https://drive.google.com/uc?export=download&id=1mtlkFQFl32HILbTC5snWntWsOcTMiPji", "1", "1", "ADLV RAINBOW CLOUD LOGO SHORT SLEEVE T-SHIRT BLACK", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 33, "BURBERRY", "", "An archive-inspired tote in canvas and topstitched leather, featuring a front pocket stamped with our Horseferry print. Carry by the reinforced top handles or detachable shoulder strap.", "https://drive.google.com/uc?export=download&id=1FivY1-HqVnegDBV8kcv7wgdHnU4AkWem", "https://drive.google.com/uc?export=download&id=19RsYsZymH7kMSH-71UzpleonRtyaiw_J", "https://drive.google.com/uc?export=download&id=1gUUl3WOTr_C5u5V0rcJdNCL6imqtbg45", "https://drive.google.com/uc?export=download&id=1YoUX47gEGBKEkuO9_ACjmdhF1rYvi0c9", "1", "1", "BURBERRY MINI LOGO GRAPHIC CANVAS AND LEATHER POCKET BAG", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 30, "ADLV", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "https://drive.google.com/uc?export=download&id=1rLOrHjbc_a6lW5Q6MKx9uCNN6SJelkQf", "https://drive.google.com/uc?export=download&id=1GfDcGW2aeOjsGIUkojoeCxun4G_mVRZu", "https://drive.google.com/uc?export=download&id=1vcfWHY2hXs4rlG_OBcp2FkJrMi9jWL3r", "https://drive.google.com/uc?export=download&id=1eAjIfM9bS2tqUnouKq1sle1bGRsBZWpc", "1", "1", "ADLV BABY FACE SHORT SLEEVE T-SHIRT BLACK RABBIT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 31, "MCM", "Brown", "", "https://drive.google.com/uc?export=download&id=1cus6PlFMcV6Qpye0-Ff0TLabYoWnJIht", "https://drive.google.com/uc?export=download&id=1SpXL_PswMgBR8YMhIYCnPp_wQ6LPdXAC", "https://drive.google.com/uc?export=download&id=1jtfRGI7aS0DA7nWQdyPmJvFz3tE52G4o", "https://drive.google.com/uc?export=download&id=1p-rhtAO9y8x54khE-S4xyrjCM9flxtwM", "1", "1", "MCM BROWN CROSSBODY BAG", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Crossbody bag", "1", false },
                    { 32, "Prada", "Black", "The Prada Cleo bag with sophisticated allure reinterprets an iconic design of the brand from the 1990's. Sleek curved lines emphasized by the particular construction rounded on the bottom and sides give this hobo bag a soft, light look. Brushed leather, a modern and versatile material that is distinctive in Prada collections, is ideal for creating always new combinations and contrasts. The enamel triangle logo decorates the silhouette.", "https://drive.google.com/uc?export=download&id=1fhdHU_V5FYVQ7i5ZefEktABB5JqzL01H", "https://drive.google.com/uc?export=download&id=12bTJvLOAH-_rC0NhjZc1NU4S7sYiFJof", "https://drive.google.com/uc?export=download&id=1XtXVuJG4FIKd-0UU-J288yUQHH-cxMaO", "https://drive.google.com/uc?export=download&id=1-r_5xt9-sQSZYr78VfwhL9Tbqwemlg3J", "1", "1", "Prada Cleo Brushed Leather Shoulder Bag", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Bag", "1", false },
                    { 19, "Moschino", "White", "", "https://drive.google.com/uc?export=download&id=1OcAaWtM9osemCa3B4TWG2USDDVnjRM7X", "https://drive.google.com/uc?export=download&id=1pjpGm7aE5kZ2pCaQDAGox00t9YK02uoc", "https://drive.google.com/uc?export=download&id=1mm5fCb2D1d9IJkSEQ_KId3e5K57T0bXO", "", "1", "1", "MOSCHINO T-SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "T-shirt", "1", false },
                    { 34, "MCM", "Brown", "Infused with the heritage emblem, the front pocket of the Patricia backpack is protected with the famous Laurel Buckle. The detachable leather strap allows you to turn the x-mini accessory into an elegant handbag or crossbody bag.", "https://drive.google.com/uc?export=download&id=1TWAmegqZrDSIBfFP5m-g5F2_Rj3NsS9I", "https://drive.google.com/uc?export=download&id=1FF5-HdgiPEqmYMpGGoO-C_MasTRqVLCi", "https://drive.google.com/uc?export=download&id=1S8oVliKLqeafD2QLbiRcKrrpf6kA5Hbx", "https://drive.google.com/uc?export=download&id=1zL07pOXYCk80y4n-wGIHqm6y7IsuGbhn", "1", "1", "MCM MINI COGNAC PATRICIA VISETOS CROSSBODY | MWKBSPA01CO001", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Bag", "1", false },
                    { 35, "Gucci", "White", "Combine both style and practicality with this Gucci Fake logo bum bag. Constructed with an adjustable fabric buckle waistband, this compact has a zip compartment and is finished with the brand's signature imitation logo details embroidered on the front.", "https://drive.google.com/uc?export=download&id=12niwGccl8KfuoLkrvDEpsTZ34otlOLc-", "https://drive.google.com/uc?export=download&id=1uqem4eQawaG2OGwvBHN20_gt3yMEniCR", "https://drive.google.com/uc?export=download&id=1rTroGFVd7WnKRuPVCy4dZrOsTSBMA1rI", "https://drive.google.com/uc?export=download&id=1Qtq4NUk_dtuEOO7zDfvU6RDmb_-1Si-y", "1", "1", "GUCCI BELT BAG FAKE LOGO WHITE", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 36, "Burberry", "", "What do your phone, your wallet, an old lipstick and some emergency snacks have in common? They all belong in this crossbody bag from Burberry - with a Horseferry print to the front and a spacious body, this bag fits all your essentials and more. We've got you covered. ", "https://drive.google.com/uc?export=download&id=11wRP1ACgpE4kP1xD9ypWMnjQd1F6aTqX", "https://drive.google.com/uc?export=download&id=14_iUyL97JjXYgWADSmlRs-J0VVvVWLL1", "https://drive.google.com/uc?export=download&id=1dAXTIpBYyksPxIi3bMlH8fTKYALTv6Sv", "https://drive.google.com/uc?export=download&id=1KzjLV_HAKknlRzCg3CHKb69aweVUorv5", "1", "1", "BURBERRY BAG", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Bag", "1", false },
                    { 37, "MARC JACOBS", "", "Marc Jacobs’ iconic Snapshot bag has been reimagined with a vibrant tie-dye print and a matching cross-body strap. Crafted from saffiano leather, the compact style has two zipped sections and slip pockets to keep your daily essentials organised. Silver-tone metal hardware and co-ordinating ‘Double J’ hardware completes the bold style.", "https://drive.google.com/uc?export=download&id=1N4UQ_qU7D0jwof4cPG83XujEdGDh7s-p", "https://drive.google.com/uc?export=download&id=1gZFceh7UvwzamS0f-T997J00rvjnDCC_", "https://drive.google.com/uc?export=download&id=1rxWh70yUyRl4W-1GahDplUxO50FOaWk5", "https://drive.google.com/uc?export=download&id=1s0noMO6Z2IFL8jN7JfEgw54pBAqavXjn", "1", "1", "Marc Jacobs Tie Dye Snapshot Cross Body Bag - Pink Multi", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Bag", "1", false },
                    { 29, "ADLV", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "https://drive.google.com/uc?export=download&id=1DcgjPlR0vCPGXVp_AZYZdaEobjRznKOu", "https://drive.google.com/uc?export=download&id=1NDYqoXAwGNqTZPfFjshzXhQ6SohCIMg4", "https://drive.google.com/uc?export=download&id=11oUK_-D0E3voLuD37_t_PmqSGUCAL23h", "https://drive.google.com/uc?export=download&id=1eaUpzTFbUzs3BsTRbySKqxN1KiVhtgkT", "1", "1", "ADLV TEDDY BEAR SHORT SLEEVE T-SHIRT BLACK", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 18, "Moschino", "", "", "https://drive.google.com/uc?export=download&id=1BqGUuj-7G4MDgK-k38SML_wLuNmsxV4t", "", "", "", "1", "1", "MOSCHINO TEE DOLLARS", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 13, "eteft", "", "", "https://drive.google.com/uc?export=download&id=1OUfVp1RZhpwhZAch5daeLszb0HzccbtJ", "https://drive.google.com/uc?export=download&id=1ahvRu6z7hwYYX1I10K3Rjx6kMyH2Vi9E", "", "", "1", "1", "BURBERRY SHIRT LIGHT BROWN", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 16, "Moschino", "Black", "", "https://drive.google.com/uc?export=download&id=1WLz6y8DGD6FVXhV-bP_EdjwlnF1TXRUS", "https://drive.google.com/uc?export=download&id=1CcTPQpg8PlEyIX5iKI8kN4aHBsyl9FwU", "https://drive.google.com/uc?export=download&id=1bF29kqD_1ajfzX6kny82Q9SJw9rS8rt4", "", "1", "1", "MOSCHINO T-SHIRT GOLD LOGO WITH PIG", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "T-shirt", "1", false },
                    { 1, "Off White", "Black", "black / purple / red ,cotton, signature arrow pattern, logo print on chest, round neck, short sleeves, straight border", "https://drive.google.com/uc?export=download&id=1qGc4cXF4az9X2evToVj0x0Ceu2qmQYnN", "https://drive.google.com/uc?export=download&id=1iViLlxnkxISB8wMdMjka0ILlfWmvple8", "https://drive.google.com/uc?export=download&id=1EPqJakj7EBtmPHZO0gf_wo8HPgUa75Zf", "", "1", "1", "OFF-WHITE ARROWS PRINT COTTON SLIM T-SHIRT - BLACK/PURPLE/RED", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 2, "Off White", "Black", "", "https://drive.google.com/uc?export=download&id=1iViLlxnkxISB8wMdMjka0ILlfWmvple8", "https://drive.google.com/uc?export=download&id=1UZzX_yVVgDsemltdOZvX_943pfU6cXoO", "https://drive.google.com/uc?export=download&id=1VLOsewsM_8-8m-Ko2ZvsvDaa01_DGlMX", "", "1", "1", "OFF-WHITE ARROWS PRINT SHORT-SLEEVE T-SHIRT - BLACK/GREY SS21", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 3, "Off White", "White/Blue", "White, cotton, signature arrow pattern, logo print on chest, round neck, short sleeves, straight border", "https://drive.google.com/uc?export=download&id=1EPqJakj7EBtmPHZO0gf_wo8HPgUa75Zf", "https://drive.google.com/uc?export=download&id=1fkx0O2cIJ5DrL60l7EJu0QX-xISIVmNa", "https://drive.google.com/uc?export=download&id=1TRmzvuN91iCLO1SRXtVMxJwuRQmHnpij", "", "1", "1", "OFF-WHITE ARROWS PRINT SHORT-SLEEVE T-SHIRT - WHITE/BLUE SS21", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 4, "Andrea Martin", "Gray", "", "https://drive.google.com/uc?export=download&id=1rOilu5Z4w41A7tx3kkd9l5PSvPfMnfBT", "https://drive.google.com/uc?export=download&id=1mc_eKkp4OscemgzZBGZcCFuEWznZS-pW", "https://drive.google.com/uc?export=download&id=1YnUToorFthY05S17uSQIRnXcUBiJLVH8", "", "1", "1", "ANDREA MARTIN Grey Astronaut Mesh Shirt", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Slim 3-layer mesh top", "1", false },
                    { 5, "Burberry", "", "- The shirt is made of breathable cotton fabric, good sweat absorption, bringing comfort to the wearer. Beautiful standard shirt form, delicate seams meticulous detail to satisfy even fastidious customers.", "https://drive.google.com/uc?export=download&id=1QhQ9e5DmIcqaXPy0RBNrvIAMgbv_YWqs", "https://drive.google.com/uc?export=download&id=1JWK25M-KEkvqsxeuiNjFm4nlPEiHIoQ4", "https://drive.google.com/uc?export=download&id=1Q-KWkHbFDVa2MHEZOxmNiaBbu1IffhGv", "", "1", "1", "BURBERRY SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Shirt", "1", false },
                    { 17, "Moschino", "", "", "https://drive.google.com/uc?export=download&id=1-QV_gSFzdfy-qRTPLgbWwTD2plYwteNk", "", "", "", "1", "1", "MOSCHINO TEE WARRIOR", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 7, "Burberry", "", "", "https://drive.google.com/uc?export=download&id=1nD8Fl62ptV1LXUZpM3cW-rECv4cXMHEn", "https://drive.google.com/uc?export=download&id=1rURWs71KvJDQ81go7rA-m0N2U7iktBJt", "", "", "1", "1", "BURBERRY SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Shirt", "1", false },
                    { 6, "ADLV", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "https://drive.google.com/uc?export=download&id=1e_zKMaR3x86zIuTaEWYew7cyLeT-VWni", "https://drive.google.com/uc?export=download&id=19u835hxFv_7E5ktACy9XfbPMxYifZ6G_", "https://drive.google.com/uc?export=download&id=1o4tsocSZxePog0y6NQg6aLCq-xDx5BYp", "", "1", "1", "ADLV SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 9, "Thom Browne", "White", "", "https://drive.google.com/uc?export=download&id=1Ry38U-_ZzzGsnci5mqHObvi8tgoc6Trz", "https://drive.google.com/uc?export=download&id=1R_a3f_050dqsgbQLz23FQxPfVForPLkc", "https://drive.google.com/uc?export=download&id=1J5Yim8sYRqELe9Imzj4mrun7uytnQm6R", "", "1", "1", "THOM BROWN SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Shirt", "1", false },
                    { 10, "Burberry", "", "", "https://drive.google.com/uc?export=download&id=1UUIDx-uORgXTIJsIytWO957naKtGAq3A", "https://drive.google.com/uc?export=download&id=1QLfLZv4TN2ugOZM375L9ZIwNmkdUKiy5", "https://drive.google.com/uc?export=download&id=1uajOerRRnV9eB7BS0UnIVXcfuPnscZyg", "", "1", "1", "BURBERRY SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Shirt", "1", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "pd_Brand", "pd_Color", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Material", "pd_MenuFacturer", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size", "pd_Size10", "pd_Size10_5", "pd_Size11", "pd_Size11_5", "pd_Size12", "pd_Size12_5", "pd_Size13", "pd_Size13_5", "pd_Size14", "pd_Size14_5", "pd_Size7", "pd_Size7_5", "pd_Size8", "pd_Size8_5", "pd_Size9", "pd_Size9_5", "pd_Style", "pd_Technologies", "pd_WaitForConfirmation" },
                values: new object[,]
                {
                    { 11, "Burberry", "", "", "https://drive.google.com/uc?export=download&id=1VjacENWRQeseioMaQFhcWdmOlvsIcPht", "https://drive.google.com/uc?export=download&id=1tQlJGdeQceNTTaDzkAVKyycgylDhMio8", "https://drive.google.com/uc?export=download&id=158cFi3wOuNmrPD5woibSuVT-YT_RCRpw", "https://drive.google.com/uc?export=download&id=1Sb1zUw0A3ZmvBJ_ZNkqpHpKrqYrnhk0M", "1", "1", "BURBERRY SHIRT RED", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Shirt", "1", false },
                    { 12, "eteft", "", "", "https://drive.google.com/uc?export=download&id=1ZKZYlg_rA6EZ7SdsVe4GbI0tP18uG67Z", "", "", "", "1", "1", "BURBERRY SHIRT LIGHT BROWN", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 38, "MARC JACOBS", "", "Marc Jacobs’ iconic Snapshot bag has been reimagined with a vibrant tie-dye print and a matching cross-body strap. Crafted from saffiano leather, the compact style has two zipped sections and slip pockets to keep your daily essentials organised. Silver-tone metal hardware and co-ordinating ‘Double J’ hardware completes the bold style.", "https://drive.google.com/uc?export=download&id=17Eq6odE_bU2_vEaSyLzxKmIzlSAvfXe2", "https://drive.google.com/uc?export=download&id=1v1RAixoCfJhNItZBYDLVCypdKY5qbhd0", "https://drive.google.com/uc?export=download&id=1jycki4ONFJrzcgEuBUX6O3ZR_jIVJ9P8", "https://drive.google.com/uc?export=download&id=1F56uErxN3w3BK51w4xe-aODnio_dna3l", "1", "1", "Marc Jacobs Tie Dye Snapshot Cross Body Bag - Blue Multi", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Bag", "1", false },
                    { 14, "Thom Browne", "White", "Endless styling opportunities are in store with this Thom Browne shirt. Made from breathable cotton, this piece is both cool and comfortable. Talk about no trouble. Features a button-down collar, front button closure, open front pockets, curved hemline, front logo patch and tricolor stripe detail with buttons on both sleeves", "https://drive.google.com/uc?export=download&id=1MLh7rMo4ZLlvjGL9lVwptz1RflsvvFsn", "https://drive.google.com/uc?export=download&id=1rU7uI2Wu25u8LMSBkJ9oQLYyRwbCLPOn", "https://drive.google.com/uc?export=download&id=1LjscRUDgfVKmg0PDX5oTChoiNG0kukg3", "", "1", "1", "THOM BROWNE WHITE SHORT SLEEVE SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Shirt", "1", false },
                    { 15, "eteft", "", "", "https://drive.google.com/uc?export=download&id=1D3qVLRk7-M8PBVm2m0ZwOAgp4kKafvOD", "", "", "", "1", "1", "GUCCI GG STRETCH COTTON POLO - DARK GREEN", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 8, "eteft", "", "", "https://drive.google.com/uc?export=download&id=1RmcA-LwkzPlAdUMb-ZtvuY1j8lGzW3HU", "https://drive.google.com/uc?export=download&id=1a6tJReOu3wtzJ_1BSdlR3L6d-2KPske7", "", "", "1", "1", "BURBERRY MONOGRAM MOTIF STRETCH COTTON POPLIN SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "dea57168-0127-4c1d-a3d1-2b4573839b2c", "admin", "AppRole", "admin", null },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "fbd287b7-1826-495e-9142-5d87e232a735", "Staff", "AppRole", "staff", null }
                });

            migrationBuilder.InsertData(
                table: "Shipping",
                columns: new[] { "ship_Id", "ship_Name", "ship_Price" },
                values: new object[] { "7CF94A7D-9239-446E-A404-086518F84652", "Ship", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "bill_Address1", "bill_Address2", "bill_City", "bill_CompanyName", "bill_Country", "bill_PhoneNumber", "bill_PostalCode", "bill_State" },
                values: new object[,]
                {
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", 0, "9a93762d-baa9-4a20-837e-0b78ae6ff841", "AppUser", new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, "staff", "staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEMqQNajB39howC5EsBDqjzpfjsN/7k+jWzIim+TKaE6AKkc+4Nza/akg4ERhIEzZtg==", null, false, "0e07623e-e6d9-41f5-b0e6-202c7ee64df7", false, "Staff", null, null, null, null, null, null, null, null },
                    { "DE544998-A3CC-4E12-ABB4-0642E57BD222", 0, "893ffd3f-4e0b-42c7-b8ed-0bdd2f0090bf", "AppUser", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "admin", "admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJp/H57Mb8m9JtbyDuKtcpwyPMVf+5mqUKKpaTFu9Wyv+nHWi6rmwyX4yCFnIu61CQ==", null, false, "2da58d9e-26d2-41c6-8d93-41205a00eeab", false, "Admin", "HCM 1", "HCM 2", "HCM", "0123456789", "Viet Nam", "0112223344", "700000", "700000" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "bill_Cancelled", "bill_Confirmation", "bill_DatetimeOrder", "bill_Delivered", "bill_Delivering", "bill_Discount", "bill_HideStatus", "bill_Note", "bill_PaidTotal", "bill_PaymentMethod", "bill_ProductColorlist", "bill_ProductIdlist", "bill_ProductNamelist", "bill_ProductPricelist", "bill_ProductSizelist", "bill_Quantity", "bill_Shipping", "bill_UserId", "bill_WaitForConfirmation", "bill_WaitPickup" },
                values: new object[,]
                {
                    { "AFD66490-12F5-4EA7-BFF6-425624290D6D", false, true, new DateTime(2021, 11, 1, 5, 42, 51, 283, DateTimeKind.Local).AddTicks(1205), false, false, 0, false, "", 2100, "Check Payment", "Blue|Red|Black|Green", "5|6|7|8", "product 5|product 6| product 7| product 8", "550|450|350|640", "7|8|9|14", "1|1|2|2", 10, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", false, false },
                    { "D269BF93-A5E2-4C4A-8146-9967DDE80D30", false, true, new DateTime(2021, 11, 1, 5, 42, 51, 281, DateTimeKind.Local).AddTicks(8328), false, false, 0, false, "", 2000, "Check Payment", "Blue|Red|Black|Green", "1|2|3|4", "product 1|product 2| product 3| product 4", "550|450|350|640", "7|8|9|14", "1|1|2|1", 10, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", false, false }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "cart_Id", "cart_Discount", "cart_UserID" },
                values: new object[,]
                {
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", 0, "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "72309286-ECBB-4D20-AD95-2819D31E3400", 0, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.InsertData(
                table: "ProductsInCategories",
                columns: new[] { "pic_CategoriesId", "pic_productId" },
                values: new object[,]
                {
                    { 3, 26 },
                    { 1, 26 },
                    { 1, 25 },
                    { 3, 24 },
                    { 1, 24 },
                    { 1, 23 },
                    { 2, 15 },
                    { 1, 22 },
                    { 1, 21 },
                    { 1, 20 },
                    { 3, 19 },
                    { 1, 19 },
                    { 1, 27 },
                    { 1, 29 },
                    { 4, 29 },
                    { 1, 18 },
                    { 1, 30 },
                    { 5, 31 },
                    { 3, 31 },
                    { 5, 32 },
                    { 3, 32 },
                    { 5, 33 },
                    { 5, 34 },
                    { 4, 34 },
                    { 5, 35 },
                    { 5, 36 },
                    { 5, 37 },
                    { 3, 29 },
                    { 1, 17 },
                    { 5, 38 },
                    { 1, 16 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 2, 4 },
                    { 4, 16 },
                    { 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "ProductsInCategories",
                columns: new[] { "pic_CategoriesId", "pic_productId" },
                values: new object[,]
                {
                    { 4, 6 },
                    { 2, 7 },
                    { 2, 5 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 3, 12 },
                    { 2, 13 },
                    { 4, 13 },
                    { 2, 14 },
                    { 4, 37 },
                    { 2, 8 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "review_id", "review_Comment", "review_HideStatus", "review_ReviewType", "review_UploadTime", "review_UserId" },
                values: new object[,]
                {
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "Test", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "Test", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "C2A543C2-B1E2-4DC5-A131-9137E4673FA6", "Test", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "DE544998-A3CC-4E12-ABB4-0642E57BD222" }
                });

            migrationBuilder.InsertData(
                table: "SubReview",
                columns: new[] { "subReview_Id", "subReview_Commnet", "subReview_DateCommnet", "subReview_HideStatus", "subReview_UserId", "subreview_SubReviewType" },
                values: new object[,]
                {
                    { "2271da85-ad1b-4e46-889a-741ba425ea49", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", "SubReview" },
                    { "d14bd792-fff1-4646-bb7d-a2e68d2b3ac9", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" },
                    { "8e7e0853-f114-4a9f-b0cb-e278b53cd0ce", "subreview 1", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.InsertData(
                table: "Wishlists",
                columns: new[] { "wl_Id", "wl_UserId" },
                values: new object[] { 1, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "pic_CartId", "pic_Id", "pic_ProductId", "pic_amount", "pic_color", "pic_size" },
                values: new object[,]
                {
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "204a4dcc-49f2-48f2-b595-b5fbe62c5dcc", 1, 2, "blue", "7" },
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "547add8c-ba30-49f5-ac42-1190514183c5", 2, 3, "blue", "7.5" },
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "852aeb8c-8465-497d-85a1-e5646881744a", 3, 1, "blue", "8" }
                });

            migrationBuilder.InsertData(
                table: "ProductInWishlist",
                columns: new[] { "piw_ProductId", "piw_WishlistId", "piw_amount" },
                values: new object[] { 1, 1, 0 });

            migrationBuilder.InsertData(
                table: "ReviewInproduct",
                columns: new[] { "rip_ProductId", "rip_ReviewId" },
                values: new object[,]
                {
                    { 1, "EEBA6608-AB75-4E83-909F-604B1A06F16C" },
                    { 1, "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" },
                    { 1, "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" }
                });

            migrationBuilder.InsertData(
                table: "SubReviewInReview",
                columns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                values: new object[,]
                {
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "8e7e0853-f114-4a9f-b0cb-e278b53cd0ce" },
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "d14bd792-fff1-4646-bb7d-a2e68d2b3ac9" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "2271da85-ad1b-4e46-889a-741ba425ea49" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_bill_UserId",
                table: "Bills",
                column: "bill_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_cart_UserID",
                table: "Carts",
                column: "cart_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CartsDevice_cartd_DeviceId",
                table: "CartsDevice",
                column: "cartd_DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCart_pic_ProductId",
                table: "ProductInCart",
                column: "pic_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCartDevices_picd_ProductId",
                table: "ProductInCartDevices",
                column: "picd_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInWishlist_piw_ProductId",
                table: "ProductInWishlist",
                column: "piw_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInCategories_pic_CategoriesId",
                table: "ProductsInCategories",
                column: "pic_CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewInproduct_rip_ReviewId",
                table: "ReviewInproduct",
                column: "rip_ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_review_UserId",
                table: "Reviews",
                column: "review_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubReview_subReview_UserId",
                table: "SubReview",
                column: "subReview_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubReviewInReview_SRiR_SubReviewId",
                table: "SubReviewInReview",
                column: "SRiR_SubReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_wl_UserId",
                table: "Wishlists",
                column: "wl_UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "ContactSystems");

            migrationBuilder.DropTable(
                name: "ContactUsers");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "ProductInCart");

            migrationBuilder.DropTable(
                name: "ProductInCartDevices");

            migrationBuilder.DropTable(
                name: "ProductInWishlist");

            migrationBuilder.DropTable(
                name: "ProductsInCategories");

            migrationBuilder.DropTable(
                name: "ReviewInproduct");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "SubReviewInReview");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserInRoleModel");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "CartsDevice");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "SubReview");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
