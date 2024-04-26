using System.ComponentModel.DataAnnotations;


namespace Models.ACME
{
    public class EmpresaEntidad
    {
        [Range(0, int.MaxValue, ErrorMessage = "Debe seleccionar una empresa.")]
        [Display(Name = "Codigo")]
        public int IDEmpresa {  get; set; }

        [Required(ErrorMessage = "Debe selesccionar un tipo de empresa.")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un tipo de empresa.")]
        [Display(Name = "Tipo Empresa")]
        public int? IDTipoEmpresa { get; set; }

        [Required(ErrorMessage =" El nombre de la empresa es obligatorio")]
        [Display(Name ="Nombre empresa")]
        public string Empresa { get; set; } = string.Empty;

        [Required(ErrorMessage = " La direccion de la empresa es obligatoria")]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; } = string.Empty;

        [Required(ErrorMessage = " El RUC de la empresa es obligatorio")]
        [Display(Name = "RUC")]
        public string RUC {  get; set; } = string.Empty;

        [Required(ErrorMessage = " Debe ingresar la fecha de creacion")]
        [Display(Name = "Fecha Creacion")]
        public DateTime fechaCreacion { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Debe Ingresar el presupuesto")]
        [Display(Name = "Presupuesto")]
        public decimal Presupuesto { get; set; }
        public bool Activo { get; set; } = true; 
        
        //Propiedad de navegacion a TipoEmpresa

        public TipoEmpresaEntidad? TipoEmpresaEntidad { get; set;}
    }
}
