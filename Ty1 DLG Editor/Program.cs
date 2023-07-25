namespace Ty1_DLG_Editor
{
    internal static class Program
    {
        public static Form1 Editor = new Form1();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(Editor);
        }
    }
}