using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._03.Facade
{
    internal class Facade
    {
        PowerUnit powerUnit;        //блок питания
        Sensors sensors;            //датчики
        VideoCard videoCard;        //видеокарта
        RAM ram;                    //оперативная память
        HDD hdd;                    //винчестер
        CardReader cardReader;      //устройство чтения дисков
        public Facade()
        {
            powerUnit = new PowerUnit();
            sensors = new Sensors();
            videoCard = new VideoCard();
            ram = new RAM();
            cardReader = new CardReader();
            hdd = new HDD();
        }
        public void BeginWork()
        {
            powerUnit.Supply();
            sensors.CheckVoltage();
            sensors.TemperaturePowerUnit();
            sensors.TemperatureVideoCard();
            powerUnit.SupplyVideoCard();
            videoCard.Start();
            videoCard.ConnectMonitor();
            sensors.TemperatureRAM();
            powerUnit.SupplyRAM();
            ram.LaunchDevices();
            ram.MemoryAnalisis();
            videoCard.DataRAM();
            powerUnit.SupplyCardReader();
            cardReader.Start();
            cardReader.CheckDiskPresence();
            videoCard.DataCardReader();
            powerUnit.SupplyHDD();
            hdd.Start();
            hdd.BootSector();
            videoCard.DataHDD();
            sensors.TemperatureAllSystems();
        }
        public void FinishWork()
        {
            hdd.Stop();
            ram.MemoryClear();
            ram.MemoryAnalisis();
            videoCard.Stop();
            cardReader.OriginalPosition();
            powerUnit.StopSupplyVideoCard();
            powerUnit.StopSupplyRAM();
            powerUnit.StopSupplyCardReader();
            powerUnit.StopSupplyHDD();
            sensors.CheckVoltage();
            powerUnit.StopSupply();
        }
    }
}
