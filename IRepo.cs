using System.Collections; 
using System.Collections.Generic; 


namespace WebApi_LiveMaio2019
{
    public interface IRepo
    {
        List<Device> GetDevices(); 
        void Insert(Device dev);
        void Update(int id, string name);

    }
}