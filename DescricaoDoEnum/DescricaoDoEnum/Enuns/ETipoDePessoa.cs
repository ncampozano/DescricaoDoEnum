using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DescricaoDoEnum.Enuns
{
    enum ETipoDePessoa
    {
        [Description("Pessoa Física")]
        Fisica =1,
        [Description("Pessoa Jurídica")]
        Juridica =2
    }
}
