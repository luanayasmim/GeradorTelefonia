using System;

namespace TelefonePoo
{
    public class TemplateNumero
    {
        public string GeraTelefonia(string tipo, bool temFormatacao, bool temDdd, string uf)
        {
            tipo = tipo.ToUpper();
            if (String.IsNullOrEmpty(tipo))
                tipo = SortearTipoTelefonia();

            if ("FIXO".Equals(tipo))
            {
                var tel = new TelefoneFixo(temDdd, temFormatacao, uf);
                return tel.Numero;
            }
            else if ("MOVEL".Equals(tipo))
            {
                var cel = new TelefoneMovel(temDdd, temFormatacao, uf);
                return cel.Numero;
            }
            return null;
        }

        private string SortearTipoTelefonia()
        {
            Random random = new Random();
            string[] types = { "MOVEL", "FIXO" };
            int index = random.Next(0, 2);
            return types[index];
        }
    }
}
