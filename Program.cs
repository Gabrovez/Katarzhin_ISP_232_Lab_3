namespace Katarzhin_ISP_232_Lab_3
{
    internal class Program
    {
        enum TrafficLight { Red, Yellow, Green }
        static void Main(string[] args)
        {
            //Задание 1
            var trafficLight = Enum.GetValues(typeof(TrafficLight));
            int i = 0;
            for (; i < trafficLight.Length; i++)
            {
                TrafficLight color = (TrafficLight)trafficLight.GetValue(i);
                if (color == TrafficLight.Green)
                    break;
            }
            i = (i + 1) % trafficLight.Length;
            TrafficLight nextColor = (TrafficLight)trafficLight.GetValue(i);
            Console.WriteLine(nextColor); 
        }
    }   
}
