using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace capaEF.Migrations
{
    /// <inheritdoc />
    public partial class v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bebidas",
                columns: table => new
                {
                    BebidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bebidas", x => x.BebidaId);
                });

            migrationBuilder.CreateTable(
                name: "Comidas",
                columns: table => new
                {
                    ComidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comidas", x => x.ComidaId);
                });

            migrationBuilder.CreateTable(
                name: "EstadosCaja",
                columns: table => new
                {
                    EstadoCajaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosCaja", x => x.EstadoCajaId);
                });

            migrationBuilder.CreateTable(
                name: "EstadosComanda",
                columns: table => new
                {
                    EstadoComandaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosComanda", x => x.EstadoComandaId);
                });

            migrationBuilder.CreateTable(
                name: "EstadosMesa",
                columns: table => new
                {
                    EstadoMesaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosMesa", x => x.EstadoMesaId);
                });

            migrationBuilder.CreateTable(
                name: "EstadosMozo",
                columns: table => new
                {
                    EstadoMozoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosMozo", x => x.EstadoMozoId);
                });

            migrationBuilder.CreateTable(
                name: "Tamanios",
                columns: table => new
                {
                    TamanioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Canpacidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tamanios", x => x.TamanioId);
                });

            migrationBuilder.CreateTable(
                name: "Cajas",
                columns: table => new
                {
                    CajaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantInicial = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CantFinal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstadoCajaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cajas", x => x.CajaId);
                    table.ForeignKey(
                        name: "FK_Cajas_EstadosCaja_EstadoCajaId",
                        column: x => x.EstadoCajaId,
                        principalTable: "EstadosCaja",
                        principalColumn: "EstadoCajaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mozos",
                columns: table => new
                {
                    MozoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoMozoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mozos", x => x.MozoId);
                    table.ForeignKey(
                        name: "FK_Mozos_EstadosMozo_EstadoMozoId",
                        column: x => x.EstadoMozoId,
                        principalTable: "EstadosMozo",
                        principalColumn: "EstadoMozoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mesas",
                columns: table => new
                {
                    MesaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroMesa = table.Column<int>(type: "int", nullable: false),
                    EstadoMesaId = table.Column<int>(type: "int", nullable: false),
                    TamanioId = table.Column<int>(type: "int", nullable: false),
                    MozoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesas", x => x.MesaId);
                    table.ForeignKey(
                        name: "FK_Mesas_EstadosMesa_EstadoMesaId",
                        column: x => x.EstadoMesaId,
                        principalTable: "EstadosMesa",
                        principalColumn: "EstadoMesaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mesas_Mozos_MozoId",
                        column: x => x.MozoId,
                        principalTable: "Mozos",
                        principalColumn: "MozoId");
                    table.ForeignKey(
                        name: "FK_Mesas_Tamanios_TamanioId",
                        column: x => x.TamanioId,
                        principalTable: "Tamanios",
                        principalColumn: "TamanioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comandas",
                columns: table => new
                {
                    ComandaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesaId = table.Column<int>(type: "int", nullable: false),
                    ComidaId = table.Column<int>(type: "int", nullable: true),
                    BebidaId = table.Column<int>(type: "int", nullable: true),
                    EstadoComandaId = table.Column<int>(type: "int", nullable: false),
                    CantComensales = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comandas", x => x.ComandaId);
                    table.ForeignKey(
                        name: "FK_Comandas_Bebidas_BebidaId",
                        column: x => x.BebidaId,
                        principalTable: "Bebidas",
                        principalColumn: "BebidaId");
                    table.ForeignKey(
                        name: "FK_Comandas_Comidas_ComidaId",
                        column: x => x.ComidaId,
                        principalTable: "Comidas",
                        principalColumn: "ComidaId");
                    table.ForeignKey(
                        name: "FK_Comandas_EstadosComanda_EstadoComandaId",
                        column: x => x.EstadoComandaId,
                        principalTable: "EstadosComanda",
                        principalColumn: "EstadoComandaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comandas_Mesas_MesaId",
                        column: x => x.MesaId,
                        principalTable: "Mesas",
                        principalColumn: "MesaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    FacturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComandaId = table.Column<int>(type: "int", nullable: false),
                    MetodoPago = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.FacturaId);
                    table.ForeignKey(
                        name: "FK_Facturas_Comandas_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comandas",
                        principalColumn: "ComandaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cajas_EstadoCajaId",
                table: "Cajas",
                column: "EstadoCajaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_BebidaId",
                table: "Comandas",
                column: "BebidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_ComidaId",
                table: "Comandas",
                column: "ComidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_EstadoComandaId",
                table: "Comandas",
                column: "EstadoComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comandas_MesaId",
                table: "Comandas",
                column: "MesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ComandaId",
                table: "Facturas",
                column: "ComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mesas_EstadoMesaId",
                table: "Mesas",
                column: "EstadoMesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Mesas_MozoId",
                table: "Mesas",
                column: "MozoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mesas_TamanioId",
                table: "Mesas",
                column: "TamanioId");

            migrationBuilder.CreateIndex(
                name: "IX_Mozos_EstadoMozoId",
                table: "Mozos",
                column: "EstadoMozoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cajas");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "EstadosCaja");

            migrationBuilder.DropTable(
                name: "Comandas");

            migrationBuilder.DropTable(
                name: "Bebidas");

            migrationBuilder.DropTable(
                name: "Comidas");

            migrationBuilder.DropTable(
                name: "EstadosComanda");

            migrationBuilder.DropTable(
                name: "Mesas");

            migrationBuilder.DropTable(
                name: "EstadosMesa");

            migrationBuilder.DropTable(
                name: "Mozos");

            migrationBuilder.DropTable(
                name: "Tamanios");

            migrationBuilder.DropTable(
                name: "EstadosMozo");
        }
    }
}
