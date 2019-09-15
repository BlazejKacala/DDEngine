using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data.items.wearable.weapons
{
    public enum Property
    {
        Ammunition, Finesse, Light, Heavy, Loading, Range, Reach, Special, Thrown, TwoHanded, Versatile
    }

    public class WeaponProperties
    {
        private readonly List<Property> properties;

        public WeaponProperties(List<Property> properties)
        {
            this.properties = properties;
        }

        public bool IsAmmunition()
        {
            return properties.Contains(Property.Ammunition);
        }

        public bool IsFinesse()
        {
            return properties.Contains(Property.Finesse);
        }

        public bool IsLight()
        {
            return properties.Contains(Property.Light);
        }

        public bool IsHeavy()
        {
            return properties.Contains(Property.Heavy);
        }

        public bool IsLoading()
        {
            return properties.Contains(Property.Loading);
        }

        public bool IsRange()
        {
            return properties.Contains(Property.Range);
        }

        public bool IsReach()
        {
            return properties.Contains(Property.Reach);
        }

        public bool IsSpecial()
        {
            return properties.Contains(Property.Special);
        }

        public bool IsThrown()
        {
            return properties.Contains(Property.Thrown);
        }

        public bool IsTwoHanded()
        {
            return properties.Contains(Property.TwoHanded);
        }

        public bool IsVersatile()
        {
            return properties.Contains(Property.Versatile);
        }

    }
}
