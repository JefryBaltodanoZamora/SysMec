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
    
    public partial class Exp_Medico
    {
        public int i_PK_ExpMedico { get; set; }
        public string i_FK_id_usuario { get; set; }
        public System.DateTime dt_expMedico { get; set; }
        public int i_fk_estado { get; set; }
        public int i_FK_antecents_patologicos { get; set; }
        public Nullable<int> i_fk_gineco_obstetricos { get; set; }
        public int i_fk_heredo_famili { get; set; }
        public int i_fk_quirurgicos_traumati { get; set; }
        public int i_pk_estado { get; set; }
    }
}