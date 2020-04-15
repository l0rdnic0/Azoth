using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azoth // Azoth
{
    public static class Weapons
    {
        private static int[,] defaultnothing = { { 0, 0 } }; // its needed because: No clue
        // Credits: RECOIL TABLES FROM https://www.unknowncheats.me/forum/rust/386523-rust-recoil-tables-pixel.html CREDITS TO: RandyShanks: https://www.unknowncheats.me/forum/members/3066922.html
        public static int[,] AssaultRifle = { { -35, 50 }, { 5, 46 }, { -55, 42 }, { -42, 37 }, { 0, 33 }, { 16, 28 }, { 29, 24 }, { 38, 19 }, { 42, 14 }, { 42, 9 }, { 38, 9 }, { 30, 18 }, { 17, 25 }, { 0, 29 }, { -15, 32 }, { -27, 33 }, { -37, 32 }, { -43, 29 }, { -46, 24 }, { -45, 17 }, { -42, 8 }, { -35, 5 }, { -24, 14 }, { -11, 21 }, { 12, 25 }, { 36, 28 }, { 49, 28 }, { 49, 26 }, { 38, 21 } };
        public static int AssaultRifleTime = 133;

        public static int[,] LR300AssaultRifle = { { -2, 25 }, { -6, 31 }, { -10, 33 }, { -14, 31 }, { -15, 25 }, { -14, 20 }, { -9, 17 }, { -2, 15 }, { 9, 12 }, { 17, 10 }, { 20, 8 }, { 17, 7 }, { 10, 5 }, { 0, 4 }, { -5, 4 }, { -9, 4 }, { -12, 3 }, { -14, 3 }, { -15, 3 }, { -15, 2 }, { -14, 2 }, { -13, 2 }, { -10, 2 }, { -7, 2 }, { -3, 2 }, { 13, 2 }, { 30, 2 }, { 36, 3 }, { 30, 3 } };
        public static int LR300AssaultRifleTime = 120;

        public static int[,] Thompson = { { -15, 33 }, { -5, 32 }, { 3, 31 }, { 11, 29 }, { 13, 26 }, { 10, 22 }, { 2, 18 }, { -7, 16 }, { -13, 14 }, { -13, 13 }, { -7, 11 }, { 2, 10 }, { 10, 9 }, { 12, 8 }, { 11, 7 }, { 5, 7 }, { -2, 6 }, { -6, 6 }, { -7, 6 } };
        public static int ThompsonTime = 130;

        public static int[,] MP5A4 = { { 0, 21 }, { 0, 29 }, { 0, 33 }, { 12, 33 }, { 29, 29 }, { 33, 22 }, { 23, 13 }, { 0, 10 }, { -18, 9 }, { -25, 8 }, { -19, 7 }, { -3, 6 }, { 7, 5 }, { 14, 4 }, { 16, 4 }, { 16, 3 }, { 12, 2 }, { 6, 2 }, { -1, 1 }, { -5, 1 }, { -8, 0 }, { -10, 0 }, { -12, 0 }, { -13, 0 }, { -13, 0 }, { -12, 0 }, { -11, 0 }, { -8, 0 }, { -5, 0 } };
        public static int MP5A4Time = 120; // not sure if thats correct

        public static int[,] CustomSMG = { { -13, 27 }, { -6, 27 }, { 0, 26 }, { 6, 25 }, { 10, 23 }, { 11, 21 }, { 9, 18 }, { 4, 16 }, { -3, 14 }, { -9, 13 }, { -11, 12 }, { -10, 10 }, { -6, 9 }, { 0, 9 }, { 6, 8 }, { 9, 7 }, { 10, 6 }, { 9, 6 }, { 4, 5 }, { 0, 5 }, { -4, 5 }, { -6, 5 }, { -5, 5 } };
        public static int CustomSMGTime = 100;

        public static int[,] M249 = { { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 }, { 0, 60 } }; // not sure if thats correct
        public static int M249Time = 120;
        // Credits End
        public static (int[,], int) Current_weapon() // Returning : Recoiltable, Timing
        {
            switch (Menu.weapon)
            {
                case "Assault Rifle":
                    return (AssaultRifle, AssaultRifleTime);

                case "LR-300 Assault Rifle":
                    return (LR300AssaultRifle, LR300AssaultRifleTime);

                case "M249":
                    return (M249, M249Time);

                case "Thompson":
                    return (Thompson, ThompsonTime);

                case "MP5A4":
                    return (MP5A4, MP5A4Time);

                case "Custom SMG":
                    return (CustomSMG, CustomSMGTime);

                default:
                    return ( defaultnothing , 0);
            }
        }
        public static (double, double) Attachment()
        {
            switch (Menu.attachment) // Returning : Multipier, Timing
            {
                case "Muzzle Boost":
                    return (1, 0.9);
                case "Muzzle Brake":
                    return (0.5, 1);
                case "Silencer":
                    return (0.8, 1);
                default:
                    return (1, 1);
            }
        }
        public static  double Scope()
        {
            switch (Menu.scope) // Returning : Recoiltable
            {
                case "8x Zoom Scope":
                    return 3.83721;
                case "16x Zoom Scope":
                    return 7.65116;
                case "Simple Handmade Sight":
                    return 0.8;
                case "Holosight":
                    return 1.18605;
                default:
                    return 1;
            }
        }
        private static Random r = new Random();
        public static int minmax(int av, int min, int max) // Makes a Random value ot of one value
        {
            double percentage = r.Next(min, max);
            percentage = percentage / 100;
            double rv = av * percentage;
            int res = Convert.ToInt32(rv);
            return res;
        }
    }


}
