//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Experimentos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class respuestasExperimento
    {
        public int id { get; set; }
        public Nullable<int> id_Participante { get; set; }
        public string nivelBasicoExp1 { get; set; }
        public string nivelBasicoExp2 { get; set; }
        public string nivelBasicoExp3 { get; set; }
        public string nivelIntermedioExp1 { get; set; }
        public string nivelIntermedioExp2 { get; set; }
        public string nivelIntermedioExp3 { get; set; }
        public string nivelAvanzadoExp1 { get; set; }
        public string nivelAvanzadoExp2 { get; set; }
        public string nivelAvanzadoExp3 { get; set; }
    
        public virtual participante participante { get; set; }
    }
}
