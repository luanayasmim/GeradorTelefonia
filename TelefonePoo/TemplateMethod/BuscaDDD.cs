using System;
using System.Collections.Generic;
using TelefonePoo.Serialization;

namespace TelefonePoo.TemplateMethod
{
    public class BuscaDDD
    {
        public string SortearPorEstado(string uf)
        {

            var ddds = BuscarPorEstado(uf.ToUpper());

            if (ddds.Count == 1)
                return ddds[0];

            Random random = new Random();
            int sortIndex = random.Next(0, ddds.Count);
            return ddds[sortIndex];
        }

        private readonly List<DddPorEstadoModel> _dddPorEstado = AcessarJson.LerJsonDddPorEstado();
        private List<string> BuscarPorEstado(string uf)
        {

            for (int i = 0; i < _dddPorEstado.Count; i++)
            {
                if (_dddPorEstado[i].Sigla.Equals(uf))
                    return _dddPorEstado[i].Ddds;
            }

            return null;
        }

        private readonly DddsDoBrasilModel _dddsDoBrasil = AcessarJson.LerJsonDddsBrasil();
        public string SortearDddTodoBrasil()
        {
            Random random = new Random();
            var indexRandom = random.Next(0, _dddsDoBrasil.Ddds.Count);
            return _dddsDoBrasil.Ddds[indexRandom];
        }
    }
}
