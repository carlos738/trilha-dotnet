using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_dotnet_hospedagem.Models
{
    public class Person
    {
        public Person()
        {
            
        }
        public Person(string nome){
            Nome = nome;
        }
        public Person(string nome, string sobrenome){
            Sobrenome = sobrenome;
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto { get; set; }
        
        
        
        
    }
}