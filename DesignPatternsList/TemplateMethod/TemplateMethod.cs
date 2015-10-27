using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    abstract class Console
    {
        public abstract String getRoot();
        public void printStatus() {
            System.Console.WriteLine(getRoot() + ">");
        }
    }

    class Cmd : Console{

        public override String getRoot() {
               return "C:\\";
        }

    }

    class Terminal : Console
    {

        public override String getRoot()
        {
            return "\\";
        }

    }

    class Client
    {

        public static void Main(String[] arg)
        {
            Commands.Console c = new Cmd();
            System.Console.WriteLine(c.getRoot());
            System.Console.ReadLine();
        }

    }

}
