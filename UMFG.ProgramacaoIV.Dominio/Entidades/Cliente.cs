﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Dominio.Entidades
{
    public sealed class Cliente : AbstractEntidade
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; } 


        public Cliente(string nome, string cpf, string usuarioAlteracao, string usuarioCadastro) 
            : base(usuarioAlteracao, usuarioCadastro)
        {
            Nome = string.IsNullOrWhiteSpace(nome)
                ? throw new ArgumentNullException(nameof(nome)) : nome;

            CPF = string.IsNullOrWhiteSpace(cpf)
                ? throw new ArgumentNullException(nameof(cpf)) : cpf;
        }

        public override string ToString()
            => $"Nome: {Nome} | CPF: {CPF} | Data cadastro: {DataCadastro.ToString("dd/MM/yyyy")}";
    }
}
