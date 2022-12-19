using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using TelefonePoo.Serialization;

namespace TelefonePoo
{
    public static class AcessarJson
    {
        public static List<DddPorEstadoModel> LerJsonDddPorEstado()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"dddsPorEstado.json");
            var dddsPorEstado = JsonConvert.DeserializeObject<List<DddPorEstadoModel>>(json);

            return dddsPorEstado;
        }

        public static DddsDoBrasilModel LerJsonDddsBrasil()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"dddBrasil.json");
            var dddsBrasil = JsonConvert.DeserializeObject<DddsDoBrasilModel>(json);

            return dddsBrasil;
        }
    }
}
