using TelefonePoo.TemplateMethod;

namespace TelefonePoo
{
    public abstract class Telefone
    {


        public string Numero { get; set; }
        public string Uf { get; set; }
        public string Ddd { get; protected set; }
        protected bool TemDdd { get; set; }
        protected bool TemFormatacao { get; set; }
        protected BuscaDDD _buscaDDD = new();

        public abstract string CriaNumero();
        public abstract string Formata(bool temFormatacao, bool temDdd);

        public string CriaDdd(string uf)
        {
            return _buscaDDD.SortearPorEstado(uf);
        }

        public string CriaDdd()
        {
            return _buscaDDD.SortearDddTodoBrasil();
        }
    }
}
