using System.Diagnostics.CodeAnalysis;
using BlackSlope.Repositories.Movies.Context;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackSlope.Api.MigrationsSql
{
    [DbContext(typeof(MovieContext))]
    [Migration("Custom_AlterSequence")]
    public class AlterSequence : Migration
    {
        protected override void Up([NotNull] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER SEQUENCE public.\"Movies_Id_seq\" RESTART WITH 51;");
        }

        protected override void Down([NotNull] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER SEQUENCE public.\"Movies_Id_seq\" RESTART WITH 1;");
        }
    }
}
