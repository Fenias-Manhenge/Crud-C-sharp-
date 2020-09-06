using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Professor
    {
        private int codigo, salario, cargaHoraria, contacto;
        private string nome, nivelAcademico, estadoCivil, sexo;

        public Professor()
        {
                
        }

        public Professor(int codigo , string nome, int contacto, string nivelAcademico, int salario, int cargaHoraria, string sexo, string estadoCivil)
        {
            this.codigo = codigo;
            this.salario = salario;
            this.cargaHoraria = cargaHoraria;
            this.nome = nome;
            this.contacto = contacto;
            this.nivelAcademico = nivelAcademico;
            this.estadoCivil = estadoCivil;
            this.sexo = sexo;
        }

        public int GetCodigo()
        {
            return codigo;
        }

        public int GetSalario()
        {
            return salario;
        }

        public int GetCargaHoraria()
        {
            return cargaHoraria;
        }

        public string GetNome()
        {
            return nome;
        }

        public int GetContacto()
        {
            return contacto;
        }

        public string GetNivelAcademico()
        {
            return nivelAcademico;
        }

        public string GetEstadoCivil()
        {
            return estadoCivil;
        }

        public string GetSexo()
        {
            return sexo;
        }
    }
}
