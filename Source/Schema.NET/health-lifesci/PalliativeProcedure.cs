namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A medical procedure intended primarily for palliative purposes, aimed at relieving the symptoms of an underlying health condition.
    /// </summary>
    [DataContract]
    public partial class PalliativeProcedure : MedicalProcedure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PalliativeProcedure";
    }
}