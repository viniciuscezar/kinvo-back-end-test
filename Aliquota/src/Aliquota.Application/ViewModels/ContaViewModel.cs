﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aliquota.Application.ViewModels
{
    public class ContaViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo 'nome' é obrigatório")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo 'valor' é obrigatório")]
        [DisplayName("Valor")]
        public decimal ValorCorrente { get; set; }
    }
}
