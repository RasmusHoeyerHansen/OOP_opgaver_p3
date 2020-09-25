using System;
/*

On the slide, to which this exercise belongs, we have written an 
interface IGameObject which is implemented by both class Die and class Card.

Restructure this program such that class Die and class 
Card both inherit an abstract class GameObject. You should write the class GameObject.

The client program should survive this restructuring. 
(You may, however, need to change the name of the type IGameObject to GameObject).
Compile and run the given client program with your classes.
*/
namespace gameObject
{
    public class Die : GameObject
    {
        private int numberOfEyes;
        private Random randomNumberSupplier;
        private readonly int maxNumberOfEyes;

        public Die() : this(6) { }

        public Die(int maxNumberOfEyes)
        {
            randomNumberSupplier =
              new Random(unchecked((int)DateTime.Now.Ticks));
            this.maxNumberOfEyes = maxNumberOfEyes;
            numberOfEyes = NewTossHowManyEyes();
        }

        public void Toss()
        {
            numberOfEyes = NewTossHowManyEyes();
        }

        private int NewTossHowManyEyes()
        {
            return randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
        }

        public int NumberOfEyes()
        {
            return numberOfEyes;
        }

        public override String ToString()
        {
            return String.Format("Die[{0}]: {1}", maxNumberOfEyes, numberOfEyes);
        }

        public override int GameValue
        {
            get
            {
                return numberOfEyes;
            }
        }

        public override GameObjectMedium Medium
        {
            get
            {
                return
                 GameObjectMedium.Plastic;
            }
        }

    }

}

