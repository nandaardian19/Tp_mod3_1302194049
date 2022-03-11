using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod3no3_1302194049
{
    internal class Program
    {
        public class Doormachine
        {
            public void pintu (String command)
            {
                command = command.ToLowerCase();
                switch (command)
                {
                    case "bukapintu":
                        this.state = "Terbuka";
                        break;
                    case "kuncipintu":
                        this.state = "Terkunci";
                        break
                            


                }

            }
            public String getState ()
            {
                return this.state
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
