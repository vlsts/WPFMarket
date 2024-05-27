using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WPFMarket.Models.Database.Migrations
{
    /// <inheritdoc />
    public partial class GetAdminById : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE OR REPLACE FUNCTION get_admin_by_id(admin_id INT)
            RETURNS TABLE(
                name VARCHAR(255),
                totp_secret_key VARCHAR(255)
            )
            LANGUAGE plpgsql
            AS $BODY$
            BEGIN
                RETURN QUERY
                    SELECT
                        name,
                        totp_secret_key
                    FROM
                        users
                    WHERE
                        id = admin_id
                    AND
                        role = 'admin'
                    AND
                        active = 1;
            END;
            $BODY$;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP FUNCTION IF EXISTS get_admin_by_id;");
        }
    }
}
