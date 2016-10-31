//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysMec
{
    using System;
    using System.Collections.Generic;
    
    public partial class Funcionarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcionarios()
        {
            this.Cat_ExpMedico = new HashSet<Cat_ExpMedico>();
            this.CM_Cita = new HashSet<CM_Cita>();
            this.CM_Medico = new HashSet<CM_Medico>();
        }
    
        public int i_Pk_Funcionario { get; set; }
        public string vc_Cedula { get; set; }
        public string vc_Nombre { get; set; }
        public string vc_PrimerApellido { get; set; }
        public string vc_SegundoApellido { get; set; }
        public Nullable<int> i_Fk_Genero { get; set; }
        public Nullable<int> i_Fk_EstadoCivil { get; set; }
        public string vc_TelefonoTrabajo { get; set; }
        public string vc_TelefonoDomicilio { get; set; }
        public string vc_TelefonoCelular { get; set; }
        public string vc_TelefonoFax { get; set; }
        public Nullable<int> i_Fk_AreaTrabajo { get; set; }
        public string vc_Email { get; set; }
        public string vc_Declara { get; set; }
        public Nullable<int> i_Fk_Distrito { get; set; }
        public string vc_DireccionExacta { get; set; }
        public Nullable<System.DateTime> dt_Nacimiento { get; set; }
        public Nullable<int> i_Fk_TipoFuncionario { get; set; }
        public Nullable<int> i_Fk_CategoriaNombramiento { get; set; }
        public Nullable<int> i_Fk_CategoriaPresupuesto { get; set; }
        public Nullable<System.DateTime> dt_IngresoAdmPub { get; set; }
        public Nullable<System.DateTime> dt_IngresoMag { get; set; }
        public Nullable<System.DateTime> dt_Propiedad { get; set; }
        public string vc_NumeroPuesto { get; set; }
        public Nullable<int> i_Fk_Puesto { get; set; }
        public Nullable<int> i_Fk_Cargo { get; set; }
        public Nullable<int> i_Fk_SubEspecialidad { get; set; }
        public string vc_Antecedente { get; set; }
        public byte[] img_Foto { get; set; }
        public Nullable<System.DateTime> dt_Sistema { get; set; }
        public string vc_CedulaResidencia { get; set; }
        public string vc_NumeroAsegurado { get; set; }
        public Nullable<System.DateTime> dt_InicioNombramiento { get; set; }
        public Nullable<System.DateTime> dt_FinNombramiento { get; set; }
        public Nullable<System.DateTime> dt_InicioCategoria { get; set; }
        public Nullable<System.DateTime> dt_FinCategoria { get; set; }
        public string vc_UsuarioIncluyo { get; set; }
        public string vc_ObservacionPuesto { get; set; }
        public string vc_UsuarioAD { get; set; }
        public Nullable<System.DateTime> dt_CumplePeriodo { get; set; }
        public Nullable<bool> b_LaboraFines { get; set; }
        public string vc_PolizaFidelidad { get; set; }
        public Nullable<int> i_Anualidades { get; set; }
    
        public virtual AreaTrabajo AreaTrabajo { get; set; }
        public virtual Cargo Cargo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cat_ExpMedico> Cat_ExpMedico { get; set; }
        public virtual CategoriaNombramiento CategoriaNombramiento { get; set; }
        public virtual CategoriaPresupuesto CategoriaPresupuesto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CM_Cita> CM_Cita { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CM_Medico> CM_Medico { get; set; }
        public virtual Distrito Distrito { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual Genero Genero { get; set; }
        public virtual Puesto Puesto { get; set; }
        public virtual SubEspecialidad SubEspecialidad { get; set; }
        public virtual TipoFuncionario TipoFuncionario { get; set; }
    }
}