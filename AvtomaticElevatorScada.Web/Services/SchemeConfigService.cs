using Models.Entities;

namespace AvtomaticElevatorScada.Web.Services
{
    public class SchemeConfigService
    {
        private readonly List<SensorView> _sensors = new List<SensorView>
        {
            new SensorView
            {
                Name = "Пожежа",
                Topic = "elevator/1/sensors/emergency/fire",
                X = 405, Y = 205
            },
            new SensorView
            {
                Name = "Перегрів двигуна",
                Topic = "elevator/1/sensors/emergency/motor_overheat",
                X = 405, Y = 275
            },
            new SensorView
            {
                Name = "Аварійна зупинка",
                Topic = "elevator/1/sensors/emergency/stop",
                X = 405, Y = 345
            },
            new SensorView
            {
                Name = "Температура зовні",
                Topic = "elevator/1/sensors/outside/temperature",
                X = 53, Y = 118
            },
            new SensorView
            {
                Name = "Вологість зовні",
                Topic = "elevator/1/sensors/outside/humidity",
                X = 53, Y = 185
            },
            new SensorView
            {
                Name = "Температура всередині",
                Topic = "elevator/1/sensors/inside/temperature",
                X = 1225, Y = 505
            },
            new SensorView
            {
                Name = "Вологість всередині",
                Topic = "elevator/1/sensors/inside/humidity",
                X = 1225, Y = 570
            },
            new SensorView
            {
                Name = "Рівень заповнення силосу",
                Topic = "elevator/1/sensors/silos/level",
                X = 703, Y = 400
            },
            new SensorView
            {
                Name = "Швидкість норії 1",
                Topic = "elevator/1/sensors/noriy1/speed",
                X = 665, Y = 133
            },
            new SensorView
            {
                Name = "Швидкість норії 2",
                Topic = "elevator/1/sensors/noriy2/speed",
                X = 1218, Y = 190
            }
        };

        public IReadOnlyList<SensorView> GetSensors()
        {
            return _sensors;
        }
    }
}
