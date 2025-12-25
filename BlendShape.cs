using FrooxEngine;

namespace AvatarClothingHelper
{
    internal struct Blendshape
    {
        public readonly IField<float> Field;
        public readonly string Name;
        // Blender will sometimes export shapekeys with duplicated names (ie. Smile.Smile), so this stores the
        // base name for matching
        public readonly string NormalisedName;
        public readonly bool Primary;

        public Blendshape(string name, IField<float> field, bool primary)
        {
            Name = name;
            Field = field;
            Primary = primary;
            
            NormalisedName = name;
            var half = (int)Math.Floor(name.Length / 2d);
            var firstHalf = name.Substring(0, half);
            Console.WriteLine($"{name}: Half character: {name[half]}, firstHalf: {firstHalf}");
            if (name[half] == '.' && firstHalf == name.Substring(half + 1))
                NormalisedName = firstHalf;

        }
    }
}