using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Portal_projeto_cobrancas.Pages

{
    public class RegistroModel
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Company { get; set; }
        public string IdDocumento { get; set; }
        public DateTime? Vencto { get; set; }
        public DateTime? Lancto { get; set; }
        public int? Atraso { get; set; }
        public string Titulo { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public decimal? VrBaseDoc { get; set; }
        public decimal? VrLiquido { get; set; }
        public decimal? VlrPago { get; set; }
        public decimal? Saldo { get; set; }
        public DateTime? UltimoPagto { get; set; }
        public string CodigoVendedor { get; set; }
        public string NomeVendedor { get; set; }
        public string FormaPagto { get; set; }
        public string Contato { get; set; }
        public string NumeroBoleto { get; set; }
        public string StatusBoleto { get; set; }
        public string DescFormaPagto { get; set; }
        public string Serial { get; set; }
        public decimal? VrComissao { get; set; }
        public string DocentryOinv { get; set; }
        public string Filial { get; set; }
        public string CodFilial { get; set; }
        public DateTime? DataImportacao { get; set; }
        public string EmailEnviado { get; set; }
        public string WhatsappEnviado { get; set; }
    }

    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<RegistroModel> ListaRegistros { get; set; } = new();

        public void OnGet()
        {
            var connStr = _configuration.GetConnectionString("DefaultConnection");

            using var conn = new MySqlConnection(connStr);
            conn.Open();

            var sql = "SELECT * FROM registros LIMIT 100";

            using var cmd = new MySqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListaRegistros.Add(new RegistroModel
                {
                    Id = reader.GetInt32("id"),
                    Tipo = reader["tipo"].ToString(),
                    Company = reader["company"].ToString(),
                    IdDocumento = reader["id_documento"].ToString(),
                    Vencto = reader["vencto"] as DateTime?,
                    Lancto = reader["lancto"] as DateTime?,
                    Atraso = reader["atraso"] as int?,
                    Titulo = reader["titulo"].ToString(),
                    Codigo = reader["codigo"].ToString(),
                    Nome = reader["nome"].ToString(),
                    Telefone = reader["telefone"].ToString(),
                    VrBaseDoc = reader["vr_base_doc"] as decimal?,
                    VrLiquido = reader["vr_liquido"] as decimal?,
                    VlrPago = reader["vlr_pago"] as decimal?,
                    Saldo = reader["saldo"] as decimal?,
                    UltimoPagto = reader["ultimo_pagto"] as DateTime?,
                    CodigoVendedor = reader["codigo_vendedor"].ToString(),
                    NomeVendedor = reader["nome_vendedor"].ToString(),
                    FormaPagto = reader["forma_pagto"].ToString(),
                    Contato = reader["contato"].ToString(),
                    NumeroBoleto = reader["numero_boleto"].ToString(),
                    StatusBoleto = reader["status_boleto"].ToString(),
                    DescFormaPagto = reader["desc_forma_pagto"].ToString(),
                    Serial = reader["serial"].ToString(),
                    VrComissao = reader["vr_comissao"] as decimal?,
                    DocentryOinv = reader["docentry_oinv"].ToString(),
                    Filial = reader["filial"].ToString(),
                    CodFilial = reader["cod_filial"].ToString(),
                    DataImportacao = reader["data_importacao"] as DateTime?,
                    EmailEnviado = reader["email_enviado"].ToString(),
                    WhatsappEnviado = reader["whatsapp_enviado"].ToString()
                });
            }
        }
    }
}
