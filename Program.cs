namespace Assignment_7._4_Car_Parking_Garage_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
        }
    }
    public class ParkingSystem
    {
        int[] slots = new int[4];
        public ParkingSystem(int big, int medium, int small)
        {
            slots[0] = 0;
            slots[1] = big;
            slots[2] = medium;
            slots[3] = small;

        }

        public bool AddCar(int carType)
        {
            if (slots[carType] > 0)
            {
                slots[carType]--;
                return true;
            }
            return false;
        }
    }
}
