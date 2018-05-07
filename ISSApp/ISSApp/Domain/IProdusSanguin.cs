using System;

namespace ISSApp.Domain
{
    public interface IProdusSanguin
    {
        DateTime DataRecoltare { get; set; }
        float Cantitate { get; set; }
        string Target { get; set; }

        FormularCerere FormularCerere { get; set; }
    }
}