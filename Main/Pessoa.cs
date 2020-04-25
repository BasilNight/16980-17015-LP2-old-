using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    public enum Sexo
    {
        MACHO,
        FEMEA,
        NULL
    }

    /// <summary>
    /// Descreve uma pessoa básica
    /// </summary>
    public class Pessoa
    {
        #region Atributos

        string nome;
        int idade;
        Sexo sexo;
        #endregion

        #region Construtores      

        /// <summary>
        /// Cria objeto pessoa com valores predefinidos
        /// </summary>
        public Pessoa()
        {
            nome = "";
            idade = 0;
            
        }
        /// <summary>
        /// Cria objeto pessoa com valores do exterior
        /// </summary>
        /// <param name="n"></param>
        /// <param name="i"></param>
        public Pessoa(string n, int i, Sexo s)
        {
            this.nome = n;
            this.idade = i;
            this.sexo = s;
        }

        

        #endregion

        #region Propriedades

        /// <summary>
        /// Manipula o parametro de idade
        /// </summary>
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        /// <summary>
        /// Manipula o parametro do nome
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Manipula o parametro do nome
        /// </summary>
        public Sexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        #endregion

        

        #region Funções


        #endregion
    }
}
