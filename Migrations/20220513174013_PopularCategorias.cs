using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome , Descricao) " +
                "values ('Normal', 'Lanche feito com ingredientes naturais')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome , Descricao) " +
               "values ('Natural', 'Lanche feito com ingredientes integrais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM CATEGORIAS");
        }
    }
}
