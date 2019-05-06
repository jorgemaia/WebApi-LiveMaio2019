using System.Collections.Generic;
using System.Linq; 

namespace WebApi_LiveMaio2019
{

 public class Repo :IRepo
    {
        List<Device> x = new List<Device>(); 
        
        public Repo()
        {
            x = new List<Device>();
            x.Add(new Device(){ ID=1, DeviceName="SensorNode1"});
        }

        public List<Device> GetDevices()
        {

            return x; 
        }

        public void Insert(Device dev)
        {
            x.Add(dev);
        }
        public void Update(int id, string name)
        {
            x.First(a=> a.ID==id).DeviceName=name;
        }


        

    }
}
