using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._03.Factory_method
{
    internal abstract class Creator
    {
        public abstract ITransport Create();
    }
    internal class CreateRoadLogistic : Creator
    {
        public override ITransport Create() 
        {
            return new RoadLogistic();
        }
    }
    internal class CreateSeaLogistic : Creator
    {
        public override ITransport Create()
        {
            return new SeaLogistic();
        }
    }
    internal class CreateAirLogistic : Creator
    {
        public override ITransport Create()
        {
            return new AirLogistic();
        }
    }
}
