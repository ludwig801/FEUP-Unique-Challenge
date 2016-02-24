﻿using UnityEngine;

namespace Assets.Scripts.Car.Upgrades
{
    public abstract class Upgrade : MonoBehaviour
    {
        public string Name;

        public string Description;

        public double PriceInEuros;

        public abstract void Apply(Car car);
        public abstract void Remove();
    }
}
