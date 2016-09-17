using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
//-------------------------------------------------------------
//-----------------Project Name: Link's Nightmare--------------
//|N|A|M|E|: Jordan James Turner
//|S|T|U|D|E|N|T N|U|M|B|E|R: 046518999
//|D|A|T|E: April, 7th, 2014
//C|O|U|R|S|E: PRG655 Seneca College
//--------------------------------------------------------------
//--------------------------------------------------------------

namespace Project_Game
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            String path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);//Path to program folder on the phone
            String FullPath = Path.Combine(path,"Game Files");//Game Files holds all of the game resources such as Items, Enemies, Weapons,etc...

            Application.Run(new Form1(FullPath));//Opens the first form which is passed the full file path that hold all the game resources
        }
    }
}