namespace TelefonePoo.TemplateMethod
{
    public class TelefoneBuilder
    {
        public string Tipo { get; private set; }
        public bool TemFormatacao { get; private set; }
        public bool TemDdd { get; private set; }
        public string Uf { get; private set; }

        public string Constroi()
        {
            TelefonePoo.TemplateNumero template = new();
            return template.GeraTelefonia(Tipo, TemFormatacao, TemDdd, Uf);
        }

        public TelefoneBuilder NumeroAleatorio()
        {
            this.Tipo = "";
            return this;
        }
        public TelefoneBuilder NumeroFixo()
        {
            this.Tipo = "FIXO";
            return this;
        }
        public TelefoneBuilder NumeroMovel()
        {
            this.Tipo = "MOVEL";
            return this;
        }
        public TelefoneBuilder ComFormatacao()
        {
            this.TemFormatacao = true;
            return this;
        }
        public TelefoneBuilder SemFormatacao()
        {
            this.TemFormatacao = false;
            return this;
        }
        public TelefoneBuilder ComDddAleatorio()
        {
            this.TemDdd = true;
            this.Uf = "";
            return this;
        }
        public TelefoneBuilder DefineEstadoParaDdd(string uf)
        {
            this.TemDdd = true;
            this.Uf = uf;
            return this;
        }

    }
}
