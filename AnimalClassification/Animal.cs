namespace AnimalClassification
{
    // Immutable class to store details about an animal.
    // TODO: Consider making this a struct.
    public class Animal
    {
        public Animal(string name, AnimalCategory category, bool hasTail)
        {
            Name = name;
            Category = category;
            HasTail = hasTail;
        }

        public string Name { get; private set; }
        public AnimalCategory Category { get; private set; }
        public bool HasTail { get; private set; }
    }
}
