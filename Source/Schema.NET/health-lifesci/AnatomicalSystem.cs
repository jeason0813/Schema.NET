namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An anatomical system is a group of anatomical structures that work together to perform a certain task. Anatomical systems, such as organ systems, are one organizing principle of anatomy, and can includes circulatory, digestive, endocrine, integumentary, immune, lymphatic, muscular, nervous, reproductive, respiratory, skeletal, urinary, vestibular, and other systems.
    /// </summary>
    [DataContract]
    public partial class AnatomicalSystem : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AnatomicalSystem";

        /// <summary>
        /// If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.
        /// </summary>
        [DataMember(Name = "associatedPathophysiology", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? AssociatedPathophysiology { get; set; }

        /// <summary>
        /// Specifying something physically contained by something else. Typically used here for the underlying anatomical structures, such as organs, that comprise the anatomical system.
        /// </summary>
        [DataMember(Name = "comprisedOf", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AnatomicalStructure, AnatomicalSystem>? ComprisedOf { get; set; }

        /// <summary>
        /// A medical condition associated with this anatomy.
        /// </summary>
        [DataMember(Name = "relatedCondition", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<MedicalCondition>? RelatedCondition { get; set; }

        /// <summary>
        /// Related anatomical structure(s) that are not part of the system but relate or connect to it, such as vascular bundles associated with an organ system.
        /// </summary>
        [DataMember(Name = "relatedStructure", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<AnatomicalStructure>? RelatedStructure { get; set; }

        /// <summary>
        /// A medical therapy related to this anatomy.
        /// </summary>
        [DataMember(Name = "relatedTherapy", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<MedicalTherapy>? RelatedTherapy { get; set; }
    }
}
