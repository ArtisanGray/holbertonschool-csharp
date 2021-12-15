using System;

namespace Enemies
{
        ///<summary>initiates a Zombie object.</summary>
        public class Zombie
        {
                ///<summary>public health value, in the form of an integer.</summary>
                public int health;

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
        }
}
