using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace RocketElevator.Migrations
{
    public partial class MigrateSampleDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ar_internal_metadata",
                columns: table => new
                {
                    key = table.Column<string>(type: "varchar(255)", nullable: false),
                    value = table.Column<string>(type: "varchar(255)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.key);
                });

            migrationBuilder.CreateTable(
                name: "batteries",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    building_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    employee_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    battery_type = table.Column<string>(type: "varchar(255)", nullable: true),
                    battery_status = table.Column<string>(type: "varchar(255)", nullable: true),
                    date_of_commissioning = table.Column<DateTime>(type: "date", nullable: true),
                    date_of_last_inspection = table.Column<DateTime>(type: "date", nullable: true),
                    certificate_of_operations = table.Column<string>(type: "varchar(255)", nullable: true),
                    information = table.Column<string>(type: "varchar(255)", nullable: true),
                    notes = table.Column<string>(type: "varchar(255)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_batteries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "columns",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    battery_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    column_type = table.Column<string>(type: "varchar(255)", nullable: true),
                    column_status = table.Column<string>(type: "varchar(255)", nullable: true),
                    number_of_floors_served = table.Column<int>(type: "int(11)", nullable: true),
                    information = table.Column<string>(type: "varchar(255)", nullable: true),
                    notes = table.Column<string>(type: "varchar(255)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_columns", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    company_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    company_contact_full_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    company_contact_phone = table.Column<string>(type: "varchar(255)", nullable: true),
                    company_contact_email = table.Column<string>(type: "varchar(255)", nullable: true),
                    company_description = table.Column<string>(type: "varchar(255)", nullable: true),
                    technical_authority_full_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    technical_authority_phone_number = table.Column<string>(type: "varchar(255)", nullable: true),
                    technical_manager_email_service = table.Column<string>(type: "varchar(255)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    address_id = table.Column<long>(type: "bigint(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "elevators",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    column_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    serial_number = table.Column<string>(type: "varchar(255)", nullable: true),
                    elevator_model = table.Column<string>(type: "varchar(255)", nullable: true),
                    elevator_type = table.Column<string>(type: "varchar(255)", nullable: true),
                    elevator_status = table.Column<string>(type: "varchar(255)", nullable: true),
                    date_of_commissioning = table.Column<DateTime>(type: "date", nullable: true),
                    date_of_last_inspection = table.Column<DateTime>(type: "date", nullable: true),
                    certificate_of_inspection = table.Column<string>(type: "varchar(255)", nullable: true),
                    information = table.Column<string>(type: "varchar(255)", nullable: true),
                    notes = table.Column<string>(type: "varchar(255)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_elevators", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    last_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    function = table.Column<string>(type: "varchar(255)", nullable: true),
                    phone = table.Column<string>(type: "varchar(255)", nullable: true),
                    email = table.Column<string>(type: "varchar(255)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    user_id = table.Column<long>(type: "bigint(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "interventions",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    author = table.Column<int>(type: "int(11)", nullable: false),
                    customer_id = table.Column<int>(type: "int(11)", nullable: false),
                    building_id = table.Column<int>(type: "int(11)", nullable: false),
                    battery_id = table.Column<int>(type: "int(11)", nullable: true),
                    column_id = table.Column<int>(type: "int(11)", nullable: true),
                    elevator_id = table.Column<int>(type: "int(11)", nullable: true),
                    employee_id = table.Column<int>(type: "int(11)", nullable: true),
                    start_intervention = table.Column<DateTime>(type: "datetime", nullable: true),
                    end_intervention = table.Column<DateTime>(type: "datetime", nullable: true),
                    result = table.Column<string>(type: "varchar(255)", nullable: true, defaultValueSql: "'Incomplete'"),
                    report = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<string>(type: "varchar(255)", nullable: true, defaultValueSql: "'Pending'"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_interventions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "leads",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    full_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    email = table.Column<string>(type: "varchar(255)", nullable: true),
                    phone = table.Column<string>(type: "varchar(255)", nullable: true),
                    business_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    project_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    department = table.Column<string>(type: "varchar(255)", nullable: true),
                    project_description = table.Column<string>(type: "text", nullable: true),
                    message = table.Column<string>(type: "text", nullable: true),
                    attachment = table.Column<string>(type: "varchar(255)", nullable: true),
                    user_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leads", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "quotes",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    apartments = table.Column<int>(type: "int(11)", nullable: true),
                    floors = table.Column<int>(type: "int(11)", nullable: true),
                    basements = table.Column<int>(type: "int(11)", nullable: true),
                    businesses = table.Column<int>(type: "int(11)", nullable: true),
                    elevator_shafts = table.Column<int>(type: "int(11)", nullable: true),
                    parking_spaces = table.Column<int>(type: "int(11)", nullable: true),
                    occupants = table.Column<int>(type: "int(11)", nullable: true),
                    opening_hours = table.Column<int>(type: "int(11)", nullable: true),
                    product_line = table.Column<string>(type: "varchar(255)", nullable: true),
                    install_fee = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    total_price = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    unit_price = table.Column<int>(type: "int(11)", nullable: true),
                    elevator_number = table.Column<int>(type: "int(11)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    building_type = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quotes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "schema_migrations",
                columns: table => new
                {
                    version = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.version);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    last_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    title = table.Column<string>(type: "varchar(255)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    email = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''"),
                    encrypted_password = table.Column<string>(type: "varchar(255)", nullable: false, defaultValueSql: "''"),
                    reset_password_token = table.Column<string>(type: "varchar(255)", nullable: true),
                    reset_password_sent_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    remember_created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    is_admin = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'0'"),
                    is_employee = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'0'"),
                    is_user = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "buildings",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    customer_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    admin_contact_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    technical_contact_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    administrator_full_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    administrator_email = table.Column<string>(type: "varchar(255)", nullable: true),
                    administrator_phone_number = table.Column<string>(type: "varchar(255)", nullable: true),
                    technical_contact_full_name = table.Column<string>(type: "varchar(255)", nullable: true),
                    technical_contact_email = table.Column<string>(type: "varchar(255)", nullable: true),
                    technical_contact_phone = table.Column<string>(type: "varchar(255)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    building_detail_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    address_id = table.Column<long>(type: "bigint(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buildings", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_6f76cebe7f",
                        column: x => x.admin_contact_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_rails_f7dd45df76",
                        column: x => x.technical_contact_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    building_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    customer_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    type_of_address = table.Column<string>(type: "varchar(255)", nullable: true),
                    status = table.Column<string>(type: "varchar(255)", nullable: true),
                    entity = table.Column<string>(type: "varchar(255)", nullable: true),
                    number_and_street = table.Column<string>(type: "varchar(255)", nullable: true),
                    suite_or_apartment = table.Column<string>(type: "varchar(255)", nullable: true),
                    city = table.Column<string>(type: "varchar(255)", nullable: true),
                    postal_code = table.Column<string>(type: "varchar(255)", nullable: true),
                    country = table.Column<string>(type: "varchar(255)", nullable: true),
                    notes = table.Column<string>(type: "varchar(255)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    latitude = table.Column<float>(type: "float", nullable: true),
                    longitude = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_a9ab2347cc",
                        column: x => x.building_id,
                        principalTable: "buildings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_rails_d5f9efddd3",
                        column: x => x.customer_id,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "building_details",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    building_id = table.Column<long>(type: "bigint(20)", nullable: true),
                    information_key = table.Column<string>(type: "varchar(255)", nullable: true),
                    value = table.Column<string>(type: "varchar(255)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_building_details", x => x.id);
                    table.ForeignKey(
                        name: "fk_rails_51749f8eac",
                        column: x => x.building_id,
                        principalTable: "buildings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "index_addresses_on_building_id",
                table: "addresses",
                column: "building_id");

            migrationBuilder.CreateIndex(
                name: "index_addresses_on_customer_id",
                table: "addresses",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "index_batteries_on_building_id",
                table: "batteries",
                column: "building_id");

            migrationBuilder.CreateIndex(
                name: "index_batteries_on_employee_id",
                table: "batteries",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "index_building_details_on_building_id",
                table: "building_details",
                column: "building_id");

            migrationBuilder.CreateIndex(
                name: "index_buildings_on_address_id",
                table: "buildings",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "index_buildings_on_admin_contact_id",
                table: "buildings",
                column: "admin_contact_id");

            migrationBuilder.CreateIndex(
                name: "index_buildings_on_building_detail_id",
                table: "buildings",
                column: "building_detail_id");

            migrationBuilder.CreateIndex(
                name: "index_buildings_on_customer_id",
                table: "buildings",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "index_buildings_on_technical_contact_id",
                table: "buildings",
                column: "technical_contact_id");

            migrationBuilder.CreateIndex(
                name: "index_columns_on_battery_id",
                table: "columns",
                column: "battery_id");

            migrationBuilder.CreateIndex(
                name: "index_customers_on_address_id",
                table: "customers",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "index_customers_on_user_id",
                table: "customers",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "index_elevators_on_column_id",
                table: "elevators",
                column: "column_id");

            migrationBuilder.CreateIndex(
                name: "index_employees_on_user_id",
                table: "employees",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "index_leads_on_user_id",
                table: "leads",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "index_quotes_on_user_id",
                table: "quotes",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "index_users_on_email",
                table: "users",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "index_users_on_reset_password_token",
                table: "users",
                column: "reset_password_token",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "ar_internal_metadata");

            migrationBuilder.DropTable(
                name: "batteries");

            migrationBuilder.DropTable(
                name: "building_details");

            migrationBuilder.DropTable(
                name: "columns");

            migrationBuilder.DropTable(
                name: "elevators");

            migrationBuilder.DropTable(
                name: "interventions");

            migrationBuilder.DropTable(
                name: "leads");

            migrationBuilder.DropTable(
                name: "quotes");

            migrationBuilder.DropTable(
                name: "schema_migrations");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "buildings");

            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
