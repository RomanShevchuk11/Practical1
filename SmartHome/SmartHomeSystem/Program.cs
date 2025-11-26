namespace SmartHomeSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var controller = new SmartHomeController();

            var Light = new Light { Name = "Лампа у вітальні" };
            var AirConditioner = new AirConditioner { Name = "Кондиціонер у спальні" };
            var CoffeeMachine = new CoffeeMachine { Name = "Кавомашина на кухні" };
            var MotionSensor = new MotionSensor { Name = "Датчик руху у коридорі" };

            controller.AddDevice(Light);
            controller.AddDevice(AirConditioner);
            controller.AddDevice(CoffeeMachine);
            controller.AddDevice(MotionSensor);

            controller.AddEnergyDevice(Light);
            controller.AddEnergyDevice(AirConditioner);
            controller.AddEnergyDevice(CoffeeMachine);

            controller.TurnAllOn();

            Console.WriteLine();
            Light.PrintStatus();
            AirConditioner.PrintStatus();
            CoffeeMachine.PrintStatus();
            MotionSensor.PrintStatus();

            controller.ShowEnergyReport(5);

            Console.WriteLine();
            controller.TurnAllOff();
        }
    }
}
