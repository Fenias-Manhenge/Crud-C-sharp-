using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Professor
    {
        private int codigo, salario, cargaHoraria;
        private string nome, contacto, nivelAcademico, estadoCivil;
        private char sexo;

        public Professor()
        {
                
        }

        public Professor(int codigo, int salario, int cargaHoraria, string nome, string contacto, string nivelAcademico, string estadoCivil, char sexo)
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

        public string GetContacto()
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

        public char GetSexo()
        {
            return sexo;
        }
    }
}
