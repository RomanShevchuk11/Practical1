using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        private List<ISwitchable> AllDevices = new List<ISwitchable>();
        private List<IEnergyConsumer> EnergyDevices = new List<IEnergyConsumer>();
        public void AddDevice(ISwitchable device)
        {
            AllDevices.Add(device);
        }
        public void AddEnergyDevice(IEnergyConsumer device)
        {
            EnergyDevices.Add(device);
        }
        public void TurnAllOn()
        {
            foreach (var device in AllDevices)
            {
                device.TurnOn();

            }
        }

        public void TurnAllOff()
        {
            foreach (var device in AllDevices)
            {
                device.TurnOff();

            }
        }

        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"Звіт про споживання енергії за {hours} год:");
            double total = 0;

            foreach (var device in EnergyDevices)
            {
                double usage = device.GetEnergyUsage(hours);
                Console.WriteLine($"{device.DeviceName}: {usage:F2} кВт·год (потужність: {device.PowerConsumption} Вт)");
                total += usage;
            }
            Console.WriteLine($"Загальне споживання: {total:F2} кВт·год");
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {total * 4:F2} грн");
        }

    }
}
