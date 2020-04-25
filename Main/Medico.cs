using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{

    /// <summary>
    /// Classe Medico - pode ser atribuido a varios pacientes dependendo da condiçao do mesmo (...)
    /// </summary>

    class Medico : Pessoa
    {
        #region Atributos
        decimal salarioHora;
        #endregion

        #region Construtores

        /// <summary>
        /// Construtor sem dados
        /// </summary>
        public Medico()
        {
            salarioHora = 0;
        }

        /// <summary>
        /// Cria objeto enfermeiro com valores do exterior
        /// </summary>
        /// <param name="n"></param>
        /// <param name="i"></param>
        /// <param name="s"></param>
        /// <param name="salario"></param>
        public Medico(string n, int i, Sexo s, decimal salario) : base(n, i, s)
        {
            n = base.Nome;
            i = base.Idade;
            s = base.Sexo;
            salario = salarioHora;
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Manipula o salario
        /// </summary>
        public decimal Salario
        {
            get { return 22 * 8 * salarioHora; }
        }
        #endregion
        
    }
}
