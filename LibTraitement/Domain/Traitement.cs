using System;

namespace LibTraitement.Domain
{
    public class Traitement
    {
        public const string KEYPROPERTY = "KeyName";

        public const string VALUEPROPERTY = "LiteralName";

        public EnumTypeTraitement KeyName { get; set; }

        public String LiteralName { get; set; }

        public BaseTransformation BaseTransformation { get; set; }

    }
}