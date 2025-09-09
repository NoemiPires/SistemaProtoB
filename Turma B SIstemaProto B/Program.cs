using System;

namespace SistemaProtoB
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Repository repository = new Repository();
            
            Usuario u1 = new Usuario();
            u1.Nome = "Ana Zaira";
            u1.Idade = 18;

            Usuario u2 = new Usuario();
            u2.Nome = "Vivian Nadielle";
            u2.Idade = 19;

            Usuario u3 = new Usuario();
            u3.Nome = "Ana Queren";
            u3.Idade = 20;

            Usuario u4 = new Usuario();
            u4.Nome = "Rute Aguiar";
            u4.Idade = 21;

            Usuario u5 = new Usuario();
            u5.Nome = "Thamires Farias";
            u5.Idade = 22;

            UsuarioRepository.Save(u1);
            UsuarioRepository.Save(u2);
            UsuarioRepository.Save(u3);
            UsuarioRepository.Save(u4);
            UsuarioRepository.Save(u5);

        }
    }
}
