using System.Collections.Generic;
using System.Linq;

namespace AnimalClassification
{
    // Class to allow the storage and filtering of animals.
    // TODO: Consider separating this into two classes dealing with 
    //       storage and filtering seperately.
    public class AnimalCollection : List<Animal>
    {
        public AnimalCollection() : base()
        {
        }

        public AnimalCollection(int capacity) : base(capacity)
        {
        }

        public AnimalCollection(IEnumerable<Animal> animals) : base(animals)
        {
            this.AddRange(animals);
        }

        public AnimalCollection Categorise(AnimalCategory category)
        {
            return Categorise(category, null);
        }

        public AnimalCollection Categorise(AnimalCategory category, bool hasTail)
        {
            return Categorise(category, (bool?)hasTail);
        }

        // This is the requested function with the optional parameter. It uses a 
        // nullable boolean where null represents no parameter supplied, in which case
        // it will not filter based on the tail.
        public AnimalCollection Categorise(AnimalCategory category, bool? hasTail = null)
        {
            // hasTail can be safely cast to a bool because operator short-circuiting on the || will 
            // have caught any nulls. Beware if you need to change this.
            return new AnimalCollection(this.Where(x =>
                    x.Category == category && (hasTail == null || (bool)hasTail == x.HasTail)));
        }
    }
}
