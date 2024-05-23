using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public class Categoria
    {
        // propriedades da classe
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        // métodos construtores
        public Categoria()
        {
            Id = 0;
        }
        public Categoria(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
        public Categoria(int id, string nome, string sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        // métodos da classes - Funcionalidades de usuário: RF04-Inserir Usuário
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.ExecuteNonQuery(); // executar do Mysql (sinal do raiozinho)
        }
    }
}
