using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvities.Models
{
    public class LearnCSharp
    {
        public int DaysToLearn { get; set; }

        public LearnCSharp() { }

        public LearnCSharp(int daysToLearn)
        {
            this.DaysToLearn = daysToLearn;
        }

        public T CreateJaggedArray<T>(params int[] lengths)
        {
            return (T)InitializeJaggedArray(typeof(T).GetElementType(), 0, lengths);
        }

        public object InitializeJaggedArray(Type type, int index, int[] lengths)
        {
            Array array = Array.CreateInstance(type, lengths[index]);
            Type elementType = type.GetElementType();

            if( elementType != null)
            {
                for (int i = 0; i < lengths[index]; i++)
                {
                    array.SetValue(InitializeJaggedArray(elementType, index + 1, lengths), i);
                }
            }

            return array;
        }
    }
}