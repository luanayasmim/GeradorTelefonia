using System;

namespace TelefonePoo
{
    public class TelefoneMovel : Telefone
    {
        public TelefoneMovel(bool temDdd, bool formatado, string uf)
        {
            this.Numero = CriaNumero();
            this.TemFormatacao = formatado;
            this.TemDdd = temDdd;
            this.Uf = uf;

            if (!String.IsNullOrEmpty(this.Uf))
            {
                this.Ddd = CriaDdd(this.Uf);
            }
            if (TemDdd && String.IsNullOrEmpty(this.Uf))
            {
                this.Ddd = this.CriaDdd();
            }
            this.Numero = Formata(this.TemFormatacao, this.TemDdd);
        }

        public override string CriaNumero()
        {
            Random random = new();

            int cel = random.Next(10000000, 99999999);
            return $"9{cel}";
        }

        public override string Formata(bool temFormatacao, bool temDdd)
        {
            if (temFormatacao && temDdd)
            {
                this.Numero = this.Numero.Insert(5, "-");
                this.Numero = this.Numero.Insert(0, $"({this.Ddd}) ");
                return this.Numero;
            }
            else if (temFormatacao)
            {
                this.Numero = this.Numero.Insert(5, "-");
                return this.Numero;
            }
            else if (temDdd)
            {
                this.Numero = this.Numero.Insert(0, $"{this.Ddd}");
                return this.Numero;
            }
            return this.Numero;
        }
    }
}
