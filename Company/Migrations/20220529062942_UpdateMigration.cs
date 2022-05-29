using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Migrations
{
    public partial class UpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "manager_id",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "region_name",
                table: "Regions",
                newName: "Region_Name");

            migrationBuilder.RenameColumn(
                name: "region_id",
                table: "Regions",
                newName: "Region_Id");

            migrationBuilder.RenameColumn(
                name: "street_address",
                table: "Locations",
                newName: "Street_Address");

            migrationBuilder.RenameColumn(
                name: "state_province",
                table: "Locations",
                newName: "State_Province");

            migrationBuilder.RenameColumn(
                name: "postal_code",
                table: "Locations",
                newName: "Postal_Code");

            migrationBuilder.RenameColumn(
                name: "country_id",
                table: "Locations",
                newName: "Country_Id");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Locations",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "location_id",
                table: "Locations",
                newName: "Location_Id");

            migrationBuilder.RenameColumn(
                name: "job_title",
                table: "Jobs",
                newName: "Job_Title");

            migrationBuilder.RenameColumn(
                name: "job_id",
                table: "Jobs",
                newName: "Job_Id");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "Employees",
                newName: "Phone_Number");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Employees",
                newName: "Last_Name");

            migrationBuilder.RenameColumn(
                name: "job_id",
                table: "Employees",
                newName: "Job_Id");

            migrationBuilder.RenameColumn(
                name: "hire_date",
                table: "Employees",
                newName: "Hire_Date");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Employees",
                newName: "First_Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Employees",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "Employees",
                newName: "Department_Id");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "Employees",
                newName: "Employee_Id");

            migrationBuilder.RenameColumn(
                name: "relationship",
                table: "Dependents",
                newName: "Relationship");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Dependents",
                newName: "Last_Name");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Dependents",
                newName: "First_Name");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "Dependents",
                newName: "Employee_Id");

            migrationBuilder.RenameColumn(
                name: "dependents_id",
                table: "Dependents",
                newName: "Department_Id");

            migrationBuilder.RenameColumn(
                name: "department_name",
                table: "Departments",
                newName: "Department_Name");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "Departments",
                newName: "Department_Id");

            migrationBuilder.RenameColumn(
                name: "region_id",
                table: "Countries",
                newName: "Region_Id");

            migrationBuilder.RenameColumn(
                name: "country_name",
                table: "Countries",
                newName: "Country_Name");

            migrationBuilder.RenameColumn(
                name: "country_id",
                table: "Countries",
                newName: "Country_Id");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Departments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_Country_Id",
                table: "Locations",
                column: "Country_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Department_Id",
                table: "Employees",
                column: "Department_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Job_Id",
                table: "Employees",
                column: "Job_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Dependents_Employee_Id",
                table: "Dependents",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_LocationId",
                table: "Departments",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Region_Id",
                table: "Countries",
                column: "Region_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Regions_Region_Id",
                table: "Countries",
                column: "Region_Id",
                principalTable: "Regions",
                principalColumn: "Region_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Locations_LocationId",
                table: "Departments",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Location_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dependents_Employees_Employee_Id",
                table: "Dependents",
                column: "Employee_Id",
                principalTable: "Employees",
                principalColumn: "Employee_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_Department_Id",
                table: "Employees",
                column: "Department_Id",
                principalTable: "Departments",
                principalColumn: "Department_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jobs_Job_Id",
                table: "Employees",
                column: "Job_Id",
                principalTable: "Jobs",
                principalColumn: "Job_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Countries_Country_Id",
                table: "Locations",
                column: "Country_Id",
                principalTable: "Countries",
                principalColumn: "Country_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Regions_Region_Id",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Locations_LocationId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Dependents_Employees_Employee_Id",
                table: "Dependents");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_Department_Id",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jobs_Job_Id",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Countries_Country_Id",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Locations_Country_Id",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Department_Id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Job_Id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Dependents_Employee_Id",
                table: "Dependents");

            migrationBuilder.DropIndex(
                name: "IX_Departments_LocationId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Countries_Region_Id",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "Region_Name",
                table: "Regions",
                newName: "region_name");

            migrationBuilder.RenameColumn(
                name: "Region_Id",
                table: "Regions",
                newName: "region_id");

            migrationBuilder.RenameColumn(
                name: "Street_Address",
                table: "Locations",
                newName: "street_address");

            migrationBuilder.RenameColumn(
                name: "State_Province",
                table: "Locations",
                newName: "state_province");

            migrationBuilder.RenameColumn(
                name: "Postal_Code",
                table: "Locations",
                newName: "postal_code");

            migrationBuilder.RenameColumn(
                name: "Country_Id",
                table: "Locations",
                newName: "country_id");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Locations",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Location_Id",
                table: "Locations",
                newName: "location_id");

            migrationBuilder.RenameColumn(
                name: "Job_Title",
                table: "Jobs",
                newName: "job_title");

            migrationBuilder.RenameColumn(
                name: "Job_Id",
                table: "Jobs",
                newName: "job_id");

            migrationBuilder.RenameColumn(
                name: "Phone_Number",
                table: "Employees",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "Last_Name",
                table: "Employees",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "Job_Id",
                table: "Employees",
                newName: "job_id");

            migrationBuilder.RenameColumn(
                name: "Hire_Date",
                table: "Employees",
                newName: "hire_date");

            migrationBuilder.RenameColumn(
                name: "First_Name",
                table: "Employees",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Employees",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Department_Id",
                table: "Employees",
                newName: "department_id");

            migrationBuilder.RenameColumn(
                name: "Employee_Id",
                table: "Employees",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "Relationship",
                table: "Dependents",
                newName: "relationship");

            migrationBuilder.RenameColumn(
                name: "Last_Name",
                table: "Dependents",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "First_Name",
                table: "Dependents",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "Employee_Id",
                table: "Dependents",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "Department_Id",
                table: "Dependents",
                newName: "dependents_id");

            migrationBuilder.RenameColumn(
                name: "Department_Name",
                table: "Departments",
                newName: "department_name");

            migrationBuilder.RenameColumn(
                name: "Department_Id",
                table: "Departments",
                newName: "department_id");

            migrationBuilder.RenameColumn(
                name: "Region_Id",
                table: "Countries",
                newName: "region_id");

            migrationBuilder.RenameColumn(
                name: "Country_Name",
                table: "Countries",
                newName: "country_name");

            migrationBuilder.RenameColumn(
                name: "Country_Id",
                table: "Countries",
                newName: "country_id");

            migrationBuilder.AddColumn<int>(
                name: "manager_id",
                table: "Employees",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
