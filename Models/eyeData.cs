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
    
    public partial class eyeData
    {
        public int id { get; set; }
        public Nullable<int> id_participante { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public string clock { get; set; }
        public string experimento { get; set; }
    
        public virtual participante participante { get; set; }
    }
}
