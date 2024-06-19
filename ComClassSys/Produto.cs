using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Produto
    {
        public int Id { get; set; }
        public string? CodBarras { get; set; }
        public string? Descricao { get; set; }
        public double? ValorUnit { get; set; }
        public string? UnidadeVenda { get; set; }
        public int CategoriaId { get; set; }
        public int EstoqueMin { get; set; }
        public double? ClasseDesc { get; set; }
        public string? Imagem { get; set; }
        public DateTime DataCad { get; set; }

        public Produto()
        {

        }
        public Produto( string codbarras, string descricao, double valorunit, string unidadevenda, int categoriaid, int estoquemin, double classedesc)

        {
            CodBarras = codbarras;
            Descricao = descricao;
            ValorUnit = valorunit;
            UnidadeVenda = unidadevenda;
            CategoriaId = categoriaid;
            EstoqueMin = estoquemin;
            ClasseDesc = classedesc;
        }


        public Produto(int id, string codbarras, string descricao, double valorunit, string unidadevenda, int categoriaid, int estoquemin, double classedesc)

        {
            Id = id;
            CodBarras = codbarras;
            Descricao = descricao;
            ValorUnit = valorunit;
            UnidadeVenda = unidadevenda;
            CategoriaId = categoriaid;
            EstoqueMin = estoquemin;
            ClasseDesc = classedesc;
        }
        public Produto(int id, string codbarras, string descricao, double valorunit, string unidadevenda, int categoriaid, int estoquemin, double classedesc, string imagem, DateTime data)

        {
            Id = id;
            CodBarras = codbarras;
            Descricao = descricao;
            ValorUnit = valorunit;
            UnidadeVenda = unidadevenda;
            CategoriaId = categoriaid;
            EstoqueMin = estoquemin;
            ClasseDesc = classedesc;
            DataCad = data;
        }
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", CategoriaId);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMin);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesc);
            cmd.ExecuteNonQuery(); // execultar no mysql
        }
        public bool Editar(int id)
        {
            bool resultado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcod_barras", CodBarras);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
            cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
            cmd.Parameters.AddWithValue("spcategoria_id", CategoriaId);
            cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMin);
            cmd.Parameters.AddWithValue("spclasse_desconto", ClasseDesc);
            try
            {
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }
        public static Produto ObterPorId(int id)
        {
            Produto produto = new Produto();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produtos where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new(dr.GetInt32(0),
                              dr.GetString(1),
                              dr.GetString(2),
                              dr.GetDouble(3),
                              dr.GetString(4),
                              dr.GetInt32(5),
                              dr.GetInt32(6),
                              dr.GetDouble(7));
            }


            return produto;
        }

        public static List<Produto> ObterLista(string? descricao = null)
        {
            List<Produto> lista = new List<Produto>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (descricao == null)
            {
                cmd.CommandText = "select * from produtos";
            }
            else
            {
                cmd.CommandText = $"select * from produtos where descricao like '%{descricao}%' order by descricao";
            }

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Produto(
                              dr.GetInt32(0),
                              dr.GetString(1),
                              dr.GetString(2),
                              dr.GetDouble(3),
                              dr.GetString(4),
                              dr.GetInt32(5),
                              dr.GetInt32(6),
                              dr.GetDouble(7)

                    ));


            }
            return lista;
        }
    }
}



