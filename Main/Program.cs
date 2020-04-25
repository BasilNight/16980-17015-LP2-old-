using System;

/// <summary>
/// Trabalho Pratico Lp2
/// 
/// Autor: Luís Martins, Daniel Maltêz
/// 
/// Descrição: Neste trabalho visamos desenvolver uma aplicação que consiga gerir a secção das urgências de um hospital 
/// detetando os níveis de urgência na condição de um paciente e atribuindo certos casos a certos médicos. (...)
/// (Trabalho ainda sujeito a alterações dependendo do conteudo dado durante as proximas aulas)
/// 
/// </summary>



namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testes de funções basicas

            Pessoa n = new Pessoa("Luis", 21, Sexo.MACHO);

            Paciente guy = new Paciente("Tony das Camionetas", 20, Sexo.MACHO, Condicao.NORMAL);
            

            Console.WriteLine("{0}",guy);

            
        }
    }
}
