using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace capaEF.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cajas_EstadosCaja_EstadoCajaId",
                table: "Cajas");

            migrationBuilder.DropForeignKey(
                name: "FK_Comandas_Bebidas_BebidaId",
                table: "Comandas");

            migrationBuilder.DropForeignKey(
                name: "FK_Comandas_Comidas_ComidaId",
                table: "Comandas");

            migrationBuilder.DropForeignKey(
                name: "FK_Comandas_EstadosComanda_EstadoComandaId",
                table: "Comandas");

            migrationBuilder.DropForeignKey(
                name: "FK_Comandas_Mesas_MesaId",
                table: "Comandas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Comandas_ComandaId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mesas_EstadosMesa_EstadoMesaId",
                table: "Mesas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mesas_Mozos_MozoId",
                table: "Mesas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mesas_Tamanios_TamanioId",
                table: "Mesas");

            migrationBuilder.DropForeignKey(
                name: "FK_Mozos_EstadosMozo_EstadoMozoId",
                table: "Mozos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tamanios",
                table: "Tamanios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mozos",
                table: "Mozos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mesas",
                table: "Mesas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadosMozo",
                table: "EstadosMozo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadosMesa",
                table: "EstadosMesa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadosComanda",
                table: "EstadosComanda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadosCaja",
                table: "EstadosCaja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comidas",
                table: "Comidas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comandas",
                table: "Comandas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cajas",
                table: "Cajas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bebidas",
                table: "Bebidas");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "Tamanios",
                newName: "Tamanio");

            migrationBuilder.RenameTable(
                name: "Mozos",
                newName: "Mozo");

            migrationBuilder.RenameTable(
                name: "Mesas",
                newName: "Mesa");

            migrationBuilder.RenameTable(
                name: "Facturas",
                newName: "Factura");

            migrationBuilder.RenameTable(
                name: "EstadosMozo",
                newName: "EstadoMozo");

            migrationBuilder.RenameTable(
                name: "EstadosMesa",
                newName: "EstadoMesa");

            migrationBuilder.RenameTable(
                name: "EstadosComanda",
                newName: "EstadoComanda");

            migrationBuilder.RenameTable(
                name: "EstadosCaja",
                newName: "EstadoCaja");

            migrationBuilder.RenameTable(
                name: "Comidas",
                newName: "Comida");

            migrationBuilder.RenameTable(
                name: "Comandas",
                newName: "Comanda");

            migrationBuilder.RenameTable(
                name: "Cajas",
                newName: "Caja");

            migrationBuilder.RenameTable(
                name: "Bebidas",
                newName: "Bebida");

            migrationBuilder.RenameIndex(
                name: "IX_Mozos_EstadoMozoId",
                table: "Mozo",
                newName: "IX_Mozo_EstadoMozoId");

            migrationBuilder.RenameIndex(
                name: "IX_Mesas_TamanioId",
                table: "Mesa",
                newName: "IX_Mesa_TamanioId");

            migrationBuilder.RenameIndex(
                name: "IX_Mesas_MozoId",
                table: "Mesa",
                newName: "IX_Mesa_MozoId");

            migrationBuilder.RenameIndex(
                name: "IX_Mesas_EstadoMesaId",
                table: "Mesa",
                newName: "IX_Mesa_EstadoMesaId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_ComandaId",
                table: "Factura",
                newName: "IX_Factura_ComandaId");

            migrationBuilder.RenameIndex(
                name: "IX_Comandas_MesaId",
                table: "Comanda",
                newName: "IX_Comanda_MesaId");

            migrationBuilder.RenameIndex(
                name: "IX_Comandas_EstadoComandaId",
                table: "Comanda",
                newName: "IX_Comanda_EstadoComandaId");

            migrationBuilder.RenameIndex(
                name: "IX_Comandas_ComidaId",
                table: "Comanda",
                newName: "IX_Comanda_ComidaId");

            migrationBuilder.RenameIndex(
                name: "IX_Comandas_BebidaId",
                table: "Comanda",
                newName: "IX_Comanda_BebidaId");

            migrationBuilder.RenameIndex(
                name: "IX_Cajas_EstadoCajaId",
                table: "Caja",
                newName: "IX_Caja_EstadoCajaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tamanio",
                table: "Tamanio",
                column: "TamanioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mozo",
                table: "Mozo",
                column: "MozoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mesa",
                table: "Mesa",
                column: "MesaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Factura",
                table: "Factura",
                column: "FacturaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadoMozo",
                table: "EstadoMozo",
                column: "EstadoMozoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadoMesa",
                table: "EstadoMesa",
                column: "EstadoMesaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadoComanda",
                table: "EstadoComanda",
                column: "EstadoComandaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadoCaja",
                table: "EstadoCaja",
                column: "EstadoCajaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comida",
                table: "Comida",
                column: "ComidaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comanda",
                table: "Comanda",
                column: "ComandaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Caja",
                table: "Caja",
                column: "CajaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bebida",
                table: "Bebida",
                column: "BebidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Caja_EstadoCaja_EstadoCajaId",
                table: "Caja",
                column: "EstadoCajaId",
                principalTable: "EstadoCaja",
                principalColumn: "EstadoCajaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comanda_Bebida_BebidaId",
                table: "Comanda",
                column: "BebidaId",
                principalTable: "Bebida",
                principalColumn: "BebidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comanda_Comida_ComidaId",
                table: "Comanda",
                column: "ComidaId",
                principalTable: "Comida",
                principalColumn: "ComidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comanda_EstadoComanda_EstadoComandaId",
                table: "Comanda",
                column: "EstadoComandaId",
                principalTable: "EstadoComanda",
                principalColumn: "EstadoComandaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comanda_Mesa_MesaId",
                table: "Comanda",
                column: "MesaId",
                principalTable: "Mesa",
                principalColumn: "MesaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Comanda_ComandaId",
                table: "Factura",
                column: "ComandaId",
                principalTable: "Comanda",
                principalColumn: "ComandaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mesa_EstadoMesa_EstadoMesaId",
                table: "Mesa",
                column: "EstadoMesaId",
                principalTable: "EstadoMesa",
                principalColumn: "EstadoMesaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mesa_Mozo_MozoId",
                table: "Mesa",
                column: "MozoId",
                principalTable: "Mozo",
                principalColumn: "MozoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mesa_Tamanio_TamanioId",
                table: "Mesa",
                column: "TamanioId",
                principalTable: "Tamanio",
                principalColumn: "TamanioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mozo_EstadoMozo_EstadoMozoId",
                table: "Mozo",
                column: "EstadoMozoId",
                principalTable: "EstadoMozo",
                principalColumn: "EstadoMozoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caja_EstadoCaja_EstadoCajaId",
                table: "Caja");

            migrationBuilder.DropForeignKey(
                name: "FK_Comanda_Bebida_BebidaId",
                table: "Comanda");

            migrationBuilder.DropForeignKey(
                name: "FK_Comanda_Comida_ComidaId",
                table: "Comanda");

            migrationBuilder.DropForeignKey(
                name: "FK_Comanda_EstadoComanda_EstadoComandaId",
                table: "Comanda");

            migrationBuilder.DropForeignKey(
                name: "FK_Comanda_Mesa_MesaId",
                table: "Comanda");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Comanda_ComandaId",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Mesa_EstadoMesa_EstadoMesaId",
                table: "Mesa");

            migrationBuilder.DropForeignKey(
                name: "FK_Mesa_Mozo_MozoId",
                table: "Mesa");

            migrationBuilder.DropForeignKey(
                name: "FK_Mesa_Tamanio_TamanioId",
                table: "Mesa");

            migrationBuilder.DropForeignKey(
                name: "FK_Mozo_EstadoMozo_EstadoMozoId",
                table: "Mozo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tamanio",
                table: "Tamanio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mozo",
                table: "Mozo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mesa",
                table: "Mesa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Factura",
                table: "Factura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadoMozo",
                table: "EstadoMozo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadoMesa",
                table: "EstadoMesa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadoComanda",
                table: "EstadoComanda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EstadoCaja",
                table: "EstadoCaja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comida",
                table: "Comida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comanda",
                table: "Comanda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Caja",
                table: "Caja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bebida",
                table: "Bebida");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Tamanio",
                newName: "Tamanios");

            migrationBuilder.RenameTable(
                name: "Mozo",
                newName: "Mozos");

            migrationBuilder.RenameTable(
                name: "Mesa",
                newName: "Mesas");

            migrationBuilder.RenameTable(
                name: "Factura",
                newName: "Facturas");

            migrationBuilder.RenameTable(
                name: "EstadoMozo",
                newName: "EstadosMozo");

            migrationBuilder.RenameTable(
                name: "EstadoMesa",
                newName: "EstadosMesa");

            migrationBuilder.RenameTable(
                name: "EstadoComanda",
                newName: "EstadosComanda");

            migrationBuilder.RenameTable(
                name: "EstadoCaja",
                newName: "EstadosCaja");

            migrationBuilder.RenameTable(
                name: "Comida",
                newName: "Comidas");

            migrationBuilder.RenameTable(
                name: "Comanda",
                newName: "Comandas");

            migrationBuilder.RenameTable(
                name: "Caja",
                newName: "Cajas");

            migrationBuilder.RenameTable(
                name: "Bebida",
                newName: "Bebidas");

            migrationBuilder.RenameIndex(
                name: "IX_Mozo_EstadoMozoId",
                table: "Mozos",
                newName: "IX_Mozos_EstadoMozoId");

            migrationBuilder.RenameIndex(
                name: "IX_Mesa_TamanioId",
                table: "Mesas",
                newName: "IX_Mesas_TamanioId");

            migrationBuilder.RenameIndex(
                name: "IX_Mesa_MozoId",
                table: "Mesas",
                newName: "IX_Mesas_MozoId");

            migrationBuilder.RenameIndex(
                name: "IX_Mesa_EstadoMesaId",
                table: "Mesas",
                newName: "IX_Mesas_EstadoMesaId");

            migrationBuilder.RenameIndex(
                name: "IX_Factura_ComandaId",
                table: "Facturas",
                newName: "IX_Facturas_ComandaId");

            migrationBuilder.RenameIndex(
                name: "IX_Comanda_MesaId",
                table: "Comandas",
                newName: "IX_Comandas_MesaId");

            migrationBuilder.RenameIndex(
                name: "IX_Comanda_EstadoComandaId",
                table: "Comandas",
                newName: "IX_Comandas_EstadoComandaId");

            migrationBuilder.RenameIndex(
                name: "IX_Comanda_ComidaId",
                table: "Comandas",
                newName: "IX_Comandas_ComidaId");

            migrationBuilder.RenameIndex(
                name: "IX_Comanda_BebidaId",
                table: "Comandas",
                newName: "IX_Comandas_BebidaId");

            migrationBuilder.RenameIndex(
                name: "IX_Caja_EstadoCajaId",
                table: "Cajas",
                newName: "IX_Cajas_EstadoCajaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tamanios",
                table: "Tamanios",
                column: "TamanioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mozos",
                table: "Mozos",
                column: "MozoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mesas",
                table: "Mesas",
                column: "MesaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facturas",
                table: "Facturas",
                column: "FacturaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadosMozo",
                table: "EstadosMozo",
                column: "EstadoMozoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadosMesa",
                table: "EstadosMesa",
                column: "EstadoMesaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadosComanda",
                table: "EstadosComanda",
                column: "EstadoComandaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EstadosCaja",
                table: "EstadosCaja",
                column: "EstadoCajaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comidas",
                table: "Comidas",
                column: "ComidaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comandas",
                table: "Comandas",
                column: "ComandaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cajas",
                table: "Cajas",
                column: "CajaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bebidas",
                table: "Bebidas",
                column: "BebidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cajas_EstadosCaja_EstadoCajaId",
                table: "Cajas",
                column: "EstadoCajaId",
                principalTable: "EstadosCaja",
                principalColumn: "EstadoCajaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comandas_Bebidas_BebidaId",
                table: "Comandas",
                column: "BebidaId",
                principalTable: "Bebidas",
                principalColumn: "BebidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comandas_Comidas_ComidaId",
                table: "Comandas",
                column: "ComidaId",
                principalTable: "Comidas",
                principalColumn: "ComidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comandas_EstadosComanda_EstadoComandaId",
                table: "Comandas",
                column: "EstadoComandaId",
                principalTable: "EstadosComanda",
                principalColumn: "EstadoComandaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comandas_Mesas_MesaId",
                table: "Comandas",
                column: "MesaId",
                principalTable: "Mesas",
                principalColumn: "MesaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Comandas_ComandaId",
                table: "Facturas",
                column: "ComandaId",
                principalTable: "Comandas",
                principalColumn: "ComandaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mesas_EstadosMesa_EstadoMesaId",
                table: "Mesas",
                column: "EstadoMesaId",
                principalTable: "EstadosMesa",
                principalColumn: "EstadoMesaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mesas_Mozos_MozoId",
                table: "Mesas",
                column: "MozoId",
                principalTable: "Mozos",
                principalColumn: "MozoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mesas_Tamanios_TamanioId",
                table: "Mesas",
                column: "TamanioId",
                principalTable: "Tamanios",
                principalColumn: "TamanioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mozos_EstadosMozo_EstadoMozoId",
                table: "Mozos",
                column: "EstadoMozoId",
                principalTable: "EstadosMozo",
                principalColumn: "EstadoMozoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
