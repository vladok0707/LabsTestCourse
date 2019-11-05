using System.Collections.Generic;
using System.Text;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int MaxFlightDistance { get; set; }
        public int MaxLoadCapacity { get; set; }

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            this.Model = model;
            this.MaxSpeed = maxSpeed;
            this.MaxFlightDistance = maxFlightDistance;
            this.MaxLoadCapacity = maxLoadCapacity;    
        }

        
        public override string ToString()
        {
            return "Plane {" + GetType() +
                "model='" + Model + '\'' + 
                ", maxSpeed=" + MaxSpeed +
                ", maxFlightDistance=" + MaxFlightDistance +
                ", maxLoadCapacity=" + MaxLoadCapacity + 
                '}';
        }

        public override bool Equals(object planeForComparison)
        {
            var comparedPlane = planeForComparison as Plane;
            return comparedPlane != null &&
                   this.Model == comparedPlane.Model &&
                   this.MaxSpeed == comparedPlane.MaxSpeed &&
                   this.MaxFlightDistance == comparedPlane.MaxFlightDistance &&
                   this.MaxLoadCapacity == comparedPlane.MaxLoadCapacity;
        }

        public override int GetHashCode()
        {
            return Model.GetHashCode()+ MaxSpeed.GetHashCode()+MaxFlightDistance.GetHashCode() + MaxLoadCapacity.GetHashCode();
          
        }        

    }
}
