using Rage;
using Epics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epics.Events.Events
{
    class Robbery
    {
        Location[] VehicleLocations = new Location[]
        {
            new Location(new Vector3(2501,4969,45),294)
        };

        Location[] TrunkLocations = new Location[]
        {
            new Location(new Vector3(2498,4968,44),286)
        };

        Location[] StealingLocations = new Location[]
        {
            new Location(new Vector3(2487,4963,44),54)
        };

        Model[] VehicleModels = new Model[]
        {
            "BURRITO"
        };
    }
}
