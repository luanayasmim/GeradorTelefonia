using System;

namespace TelefonePoo
{
    public class TelefoneFixo : Telefone
    {
        public TelefoneFixo(bool temDdd, bool formatado, string uf)
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

            int primeiroDigito = random.Next(2, 6);
            int tel = random.Next(1000000, 9999999);
            return $"{primeiroDigito}{tel}";
        }

        public override string Formata(bool temFormatacao, bool temDdd)
        {
            if (temFormatacao && temDdd)
            {
                this.Numero = this.Numero.Insert(4, "-");
                this.Numero = this.Numero.Insert(0, $"({this.Ddd}) ");
                return this.Numero;
            }
            else if (temFormatacao)
            {
                this.Numero = this.Numero.Insert(4, "-");
                return this.Numero;
            }
            else if (temDdd)
            {
                this.Numero = this.Numero.Insert(0, $"{this.Ddd}");
                return this.Numero;
            }
            return this.Numero;
        }

        //public override string CriaDdd(string uf)
        //{
        //    return _buscaDDD.SortearPorEstado(uf);
        //}

        //public override string CriaDdd()
        //{
        //    return _buscaDDD.SortearDddTodoBrasil();
        //}
    }
}
