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
    
    public partial class Gineco_Obstreticos
    {
        public int i_pk_gineco_obstetricos { get; set; }
        public string vc_menarca { get; set; }
        public string vc_fur { get; set; }
        public string vc_relaciones_sexuales { get; set; }
        public string vc_planificar { get; set; }
        public string vc_ritmo { get; set; }
        public string vc_metodo { get; set; }
        public string vc_duracion { get; set; }
        public string vc_partos_eutocicos { get; set; }
        public string vc_forceps { get; set; }
        public string vc_cesareas { get; set; }
        public string vc_flujos { get; set; }
        public string vc_sangrados_anormales { get; set; }
        public string vc_pap { get; set; }
        public Nullable<System.DateTime> dt_pap { get; set; }
        public string vc_resultado { get; set; }
        public int i_pk_estado { get; set; }
    }
}