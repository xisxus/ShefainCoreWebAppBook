using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShefainCoreWebApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class sp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var proc1 = @"create proc spsavePerson
                            @fn nvarchar(255),
                            @ln nvarchar(255),
                            @em nvarchar(255),
                            @creDate datetime 
                            as
                            begin
                            insert into Persons(FirstName, LastName, EmailAddress, CreatedOn)
                            values (@fn, @ln, @em, @creDate)
                            end ";
            migrationBuilder.Sql(proc1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Drop proc spsavePerson");
        }
    }
}
