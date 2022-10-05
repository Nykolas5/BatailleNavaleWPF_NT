﻿using System;

namespace BatailleNavaleWPF
{
    public abstract class Navire : INavire
    {
        public int Longueur { get; }
        public bool Coule { get => EstCoule(); }

        public Case[] cases;

        public Navire(int longueur, Case[] carres)
        {
            Longueur = longueur;
            cases = carres;

            foreach (Case carre in cases)
            {
                carre.Navire = this;
            }
        }

        public bool EstCoule()
        {
            foreach (Case carre in cases)
            {
                if (!carre.Touche) return false;
            }
            return true;
        }
    }
}
