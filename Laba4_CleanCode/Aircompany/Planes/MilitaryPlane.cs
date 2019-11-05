using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType PlaneType { get; set; }

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType planeType)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            this.PlaneType = planeType;
        }

        public override bool Equals(object planeForComparison)
        {
            var comparedPlane = planeForComparison as MilitaryPlane;
            return comparedPlane != null &&
                   base.Equals(planeForComparison) &&
                   this.PlaneType == comparedPlane.PlaneType;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + PlaneType.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", type=" + PlaneType +
                    '}');
        }        
    }
}
