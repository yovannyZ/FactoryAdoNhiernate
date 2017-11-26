namespace Entities
{
    public class Region : Entidad
    {//IdRegion, CoRegion, NoRegion, TxDescCorta, FlActivo
        public virtual int Id { get; set; }
        public virtual string Codigo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual string DescCorta { get; set; }
        public virtual bool EstaActivo { get; set; }
    }
}
