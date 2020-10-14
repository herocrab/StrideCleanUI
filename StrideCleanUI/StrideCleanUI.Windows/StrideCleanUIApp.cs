using Stride.Engine;

namespace StrideCleanUI
{
    class StrideCleanUIApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
