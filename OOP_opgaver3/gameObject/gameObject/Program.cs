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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public enum GameObjectMedium { Paper, Plastic, Electronic }

    //public interface IGameObject
    //{

    //    int GameValue
    //    {
    //        get;
    //    }

    //    GameObjectMedium Medium
    //    {
    //        get;
    //    }
    //}

    public abstract class GameObject
    { 
        public abstract int GameValue { get; }
        public abstract GameObjectMedium Medium {
            get;
        }
    }

}

