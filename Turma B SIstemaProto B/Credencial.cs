using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaProtoB 
{ 
    
        public class Credencial
        {
            [Required]
            public Int64 Id { get; set; }

            [MinLength(1)]
            [MaxLength(200)]
            private String? _email;
            public String? Email
            {
                get => _email;
                set
                {
                    ArgumentNullException.ThrowIfNull(value);

                    if (value.Length < 1 || value.Length > 200)
                        throw new ArgumentException("Emnail Invalido");
                    _email = value;
                }
            }

            [MinLength(8)]
            [MaxLength(15)]
            private String? _senha;
            public String? Senha
            {
                get => _senha;
                set
                {
                    ArgumentNullException.ThrowIfNull(value);

                    if (value.Length < 8 || value.Length > 15)
                        throw new ArgumentException("Senha Invalida");
                    _senha = value;
                }
            }

            private DateTime? _utimoAcesso;
            public DateTime? UtimoAcesso
            {
                get => _utimoAcesso;
                set
                {
                    _utimoAcesso = value;
                }
            }
        }

}

