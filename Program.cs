using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace NotesCommandLine
{
    class Program
    {
        private static string NoteDirectory =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Notes\";

        private static void Main(string[] args)
        {
            while (true)
            {
                ReadCommand();

            }

        }
        private static void ReadCommand()
        {
            Console.Write(Directory.GetDirectoryRoot(NoteDirectory));
            string Command = Console.ReadLine();

            switch (Command.ToLower())
            {
                case "new":
                    NewNote();
//                    Main(null);
                    break;
                case "exit":
                    Exit();
                    break;
                default:
                    CommandsAvailable();
                    //Main(null);
                    break;
                case "edit":
                    EditNote();
                  //  Main(null);
                    break;
            }
        }
        
        #region Command Response Methods
        private static void NewNote()
        {
            Console.WriteLine("in NewNote");
        }

        private static void CommandsAvailable()
        {
            Console.WriteLine("Invalid Option");
        }

        private static void Exit()
        {
            Environment.Exit(0);
        }

        private static void EditNote()
        {
            Console.WriteLine("CHANGING NOTE");
        }
        #endregion
    }
}
