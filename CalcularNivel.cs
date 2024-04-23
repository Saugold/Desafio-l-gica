using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_lógica
{
    static class CalcularNivel
    {
    public static string CalcularLv(int vitorias)
    {
        // Calcular o saldo de Rankeadas
        int saldoVitorias = vitorias;

        // Determinar o nível com base no saldo de vitórias
        string nivel;
        if (vitorias < 10)
        {
            nivel = "Ferro";
        }
        else if (vitorias <= 20)
        {
            nivel = "Bronze";
        }
        else if (vitorias <= 50)
        {
            nivel = "Prata";
        }
        else if (vitorias <= 80)
        {
            nivel = "Ouro";
        }
        else if (vitorias <= 90)
        {
            nivel = "Diamante";
        }
        else if (vitorias <= 100)
        {
            nivel = "Lendário";
        }
        else
        {
            nivel = "Imortal";
        }

        return nivel;
    }
    }
}