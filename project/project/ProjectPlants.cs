//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectPlants
    {
        public int IDProjectPlants { get; set; }
        public int IDProject { get; set; }
        public int IDPlant { get; set; }
        public double PointX { get; set; }
        public double PointY { get; set; }
    
        public virtual Plants Plants { get; set; }
        public virtual Projects Projects { get; set; }
    }
}
