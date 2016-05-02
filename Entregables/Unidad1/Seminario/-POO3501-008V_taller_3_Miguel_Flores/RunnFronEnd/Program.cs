using DataManagert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RunnFronEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            var validation = new Validation();
            var menu = new Menu();
            do
            {
                menu.OutMenu();
                menu.OptionSelect(menu.option);

            } while (menu.option!=6);




        }

       
	
    }
}
