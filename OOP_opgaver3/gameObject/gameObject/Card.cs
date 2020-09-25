﻿using System;
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
    public class Card : GameObject
    {
        public enum CardSuite { spades, hearts, clubs, diamonds };
        public enum CardValue
        {
            two = 2, three = 3, four = 4, five = 5,
            six = 6, seven = 7, eight = 8, nine = 9,
            ten = 10, jack = 11, queen = 12, king = 13,
            ace = 14
        };

        private CardSuite suite;
        private CardValue value;

        public Card(CardSuite suite, CardValue value)
        {
            this.suite = suite;
            this.value = value;
        }

        public CardSuite Suite
        {
            get { return this.suite; }
        }

        public CardValue Value
        {
            get { return this.value; }
        }

        public override String ToString()
        {
            return String.Format("Suite:{0}, Value:{1}", suite, value);
        }

        public override int GameValue
        {
            get { return (int)(this.value); }
        }

        public override GameObjectMedium Medium
        {
            get
            {
                return GameObjectMedium.Paper;
            }
        }



        
    }

}

