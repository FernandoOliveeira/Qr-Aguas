using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAguas.Models
{
    interface ICepApiService
    {
        [Get("/ws/{cep}/json/")]
        Task<CepResponse> CepResposta(string cep);
    }
}
