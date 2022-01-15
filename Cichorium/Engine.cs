using Microsoft.Xna.Framework;

namespace Cichorium
{
    public class Engine : Game
    {
        public static Engine Instance { get; private set; }
        public GraphicsDeviceManager GraphicsDeviceManager;

        public Engine()
        {
            Instance = this;

            GraphicsDeviceManager = new GraphicsDeviceManager(this);
            GraphicsDeviceManager.IsFullScreen = false;
            GraphicsDeviceManager.ApplyChanges();
        }
    }
}