using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{

    /// <summary>
    /// Enumerador que descreve a condiçao do paciente
    /// </summary>
    public enum Condicao
    {
        URGENTE,
        MAU,
        NORMAL
    }


    /// <summary>
    /// Descreve paciente do hospital
    /// </summary>
    public class Paciente : Pessoa
    {
        #region Atributos
        Condicao condicao;
        #endregion


        #region Construtores

        /// <summary>
        /// Cria objeto pessoa com valores predefinidos
        /// </summary>
        public Paciente()
        {
            condicao = Condicao.NORMAL;
        }

        /// <summary>
        /// Cria objeto paciente com valores do exterior
        /// </summary>
        /// <param name="c"></param>
        public Paciente(string n, int i, Sexo s, Condicao c) : base(n,i,s)
        {
            condicao = c;
            base.Nome = n;
            base.Idade = i;
            base.Sexo = s;
        }


        #endregion


        #region Métodos


        // Adicionar paciente ------

        // Eliminar pactiente ------

        // Existe paciente?   ------

        #endregion


        #region Overrides
        /// <summary>
        /// Converte dados para forma de string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "\nNome: " + base.Nome + "\nIdade: " + base.Idade + "\nSexo: " + base.Sexo + "\nCondição: \n" + condicao;
        }
        #endregion

    }
}
