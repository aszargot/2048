using _2048.DAL;
using _2048.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Game game = new Game();

            game.Run();

            //IRepository repo = new RepoEntity();

            //Score score = new Score();
            //score.Id = 1;
            //score.Username = "agata";
            //score.Value = 400;

            //repo.Delete(score);
        }
    }
}
