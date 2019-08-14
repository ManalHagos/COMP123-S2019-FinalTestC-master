using COMP123_S2019_FinalTestC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*

 * STUDENT NAME:Manal Hagos
 * STUDENT ID:301027317
 * DESCRIPTION: This is the program
 */
namespace COMP123_S2019_FinalTestC
{
    public static class Program
    {
        
        public static CharacterGenerationForm characterForm;
        public static AboutBox aboutBox;
        public static inistance CharacterPortfolio;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            aboutBox = new AboutBox();
            characterForm = new CharacterGenerationForm();

            Application.Run(characterForm);
        }
    }
}
