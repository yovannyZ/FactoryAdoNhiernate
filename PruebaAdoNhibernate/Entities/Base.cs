namespace Entities
{
    public class Base 
    {//IdZona, CoZona, NoZona, TxDescCorta, FlActivo, IdRegion
        public virtual int Id { get; set; }
        public virtual string Codigo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual string DescCorta { get; set; }
        public virtual bool EstaActivo { get; set; }
        public virtual Region Region { get; set; }

        public Base()
        {
            Region = new Region();
        }
    }
}
