using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShefainCoreWebApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class sp2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var proc = @"create or alter proc spupdatePerson
                            @pid int,
                            @fn nvarchar(255),
                            @ln nvarchar(255),
                            @em nvarchar(255),
                            @creDate datetime 
                            as
                            begin
                            update Persons set FirstName =@fn, LastName = @ln, EmailAddress = @em, CreatedOn=@creDate where 
                            id = @pid

                            end";

            migrationBuilder.Sql(proc);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var drop = @"Drop proc spupdatePerson";
            migrationBuilder.Sql(drop);
        }
    }
}
