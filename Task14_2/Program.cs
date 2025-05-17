using System;

namespace Task14_2
{
    delegate void DeviceState(string deviceType, string newState, DateTime dateTime);

    internal class Program
    {
        static void Main(string[] args)
        {
            var smt = new SmartHomeSystem();
            smt.DeviceStateChanged += Smt_DeviceStateChanged;

            smt.UnlockDoor();
            smt.TurnOnLight();
            smt.LockDoor();
            smt.SetTemperature(24);

            Console.ReadKey();
        }

        private static void Smt_DeviceStateChanged(string deviceType, string newState, DateTime dateTime)
        {
            Console.WriteLine($"[{dateTime:HH:mm:ss}] {deviceType}: {newState}");
        }
    }

    class SmartHomeSystem
    {
        public event DeviceState DeviceStateChanged;

        string[] devices = { "Освещение", "Термостат", "Дверь" };

        public void TurnOnLight()
        {
            DeviceStateChanged?.Invoke(devices[0], "включено", DateTime.Now);
        }
        public void TurnOffLight()
        {
            DeviceStateChanged?.Invoke(devices[0], "выключено", DateTime.Now);
        }
        public void SetTemperature(int newTemp)
        {
            DeviceStateChanged?.Invoke(devices[1], $"установлена температура {newTemp}C", DateTime.Now);
        }
        public void LockDoor()
        {
            DeviceStateChanged?.Invoke(devices[2], "закрыта", DateTime.Now);
        }
        public void UnlockDoor()
        {
            DeviceStateChanged?.Invoke(devices[2], "открыта", DateTime.Now);
        }
    }
}
