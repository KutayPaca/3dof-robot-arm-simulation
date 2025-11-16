using System;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace RobotKoluSimulasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            var nativeWindowSettings = new NativeWindowSettings()
            {
                ClientSize = new Vector2i(1280, 720),
                Title = "3 DOF Robot Kolu Simülasyonu",
                API = ContextAPI.OpenGL,
                APIVersion = new Version(3, 3),
                Profile = ContextProfile.Compatability,
                Flags = ContextFlags.Default,
            };

            var gameWindowSettings = new GameWindowSettings()
            {
                UpdateFrequency = 60.0
            };

            using (var window = new RobotWindow(gameWindowSettings, nativeWindowSettings))
            {
                window.Run();
            }
        }
    }
}
