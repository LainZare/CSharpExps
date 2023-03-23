
namespace MineSweepingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(10, 10, 10);
            map.InitMap();
            map.ShowMap();
        }
    }

}