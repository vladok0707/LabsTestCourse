using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        public int PassengersCapacity { get; set; }

        public PassengerPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, int passengersCapacity)
            :base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            this.PassengersCapacity = passengersCapacity;
        }

        public override bool Equals(object planeForComparison)
        {
            var comparedPlane = planeForComparison as PassengerPlane;
            return comparedPlane != null &&
                   base.Equals(planeForComparison) &&
                   PassengersCapacity == comparedPlane.PassengersCapacity;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + PassengersCapacity.GetHashCode();
        }

    
        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", passengersCapacity=" + PassengersCapacity +
                    '}');
        }       
        
    }
}
