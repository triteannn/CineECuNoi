﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Table("FormulareCerere")]
    public class FormularCerere
    {
        public FormularCerere()
        {
            PsPlasme = new List<PSPlasma>();
            PsGlobuleRosii = new List<PSGlobuleRosii>();
            PsTrombocite = new List<PSTrombocite>();
        }

        public int Id { get; set; }
        public virtual ICollection<PSPlasma> PsPlasme { get; set; }
        public virtual ICollection<PSGlobuleRosii> PsGlobuleRosii { get; set; }
        public virtual ICollection<PSTrombocite> PsTrombocite { get; set; }
    }
}
