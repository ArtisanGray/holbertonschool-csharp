using System;

namespace Enemies
{
        ///<summary>initiates a Zombie object.</summary>
        public class Zombie
        {
                ///<summary>public health value, in the form of an integer.</summary>
                int health;

                ///<summary>zombie constructor.</summary>
                public Zombie()
                {
                        health = 0;
                }

                ///<summary>zombie constuctor that sets public field to desired value.</summary>
                public Zombie(int value)
                {
                        if (value < 0)
                                throw new ArgumentException("Health must be greater than or equal to 0");
                        else
                                health = value;
                }

                string name = "(No name)";

                ///<summary>name property</summary>
                public string Name
                {
                        get { return name; }
                        set { name = value;  }
                }

                ///<summary>gets the health from the current Zombie object and returns it.</summary>
                public int GetHealth()
                {
                        return health;
                }
		///<summary>overrides ToString representation</summary>
		public override string ToString() => $"Zombie Name: {name} / Total Health: {health}";
        }
}
