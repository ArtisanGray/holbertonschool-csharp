using System;

enum Rating
{
        Good,
        Great,
        Excellent
}

struct Dog
{
        public Dog(string n, float a, string o, Rating r)
        {
                name = n;
                age = a;
                owner = o;
                rating = r;
        }

        public string name { get; }
        public float age { get; }
        public string owner { get; }
        public Rating rating { get; }

	public override string ToString() => $"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}";
}
