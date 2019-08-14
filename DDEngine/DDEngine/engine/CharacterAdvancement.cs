using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data
{

   

    public static class CharacterAdvancement
    {

        private static readonly Dictionary<int, int> lvlProgression = new Dictionary<int, int>() {

            { 1, 0 },
            { 2, 300},
            { 3, 900},
            { 4, 2700},
            { 5, 6500},
            { 6, 14000},
            { 7, 23000},
            { 8, 34000},
            { 9, 48000},
            { 10, 64000},
            { 11, 85000},
            { 12, 100000},
            { 13, 120000},
            { 14, 140000},
            { 15, 165000},
            { 16, 195000},
            { 17, 225000},
            { 18, 265000},
            { 19, 305000},
            { 20, 335000},


        };

        public static bool isReadyToLvlUp(Character character)
        {
            character.XP
        }

    }
}
