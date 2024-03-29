﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This class is made to be able to create new coffebeans of different types
namespace MoccaMaster
{
    public class CoffeeBean : IBrewType // implementet in the IBrewType interface
    {
        #region Fields
        private string type;

        #endregion

        #region Properties
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        #endregion

        #region Constructors
        public CoffeeBean(string type)
        {
            this.type = type;
        }

        public CoffeeBean()
        {

        }

        #endregion
        //Method to select coffee type add coffee beans to the machine
        #region Methods
        public void Add()
        {
            bool run = true;
            while (run)
            {

                Console.WriteLine("Which kind of beans would you like? Please Chose: || 1: Arabika coffee || 2: Robusta coffe || 3: Liberica coffe ||");
                char input = Console.ReadKey(false).KeyChar;//Receiving the input
                Console.WriteLine();
                try
                {
                    switch (input)//Switch to decide what to return to console, and adding the type to the attribute
                    {
                        case '1':
                            Type = "Arabika coffee";
                            Console.WriteLine("You have choosen " + Type);
                            run = false;
                            break;
                        case '2':
                            Type = "Robusta coffee";
                            Console.WriteLine("You have choosen " + Type);
                            run = false;
                            break;
                        case '3':
                            Type = "Liberica coffee";
                            Console.WriteLine("You have choosen " + Type);
                            run = false;
                            break;

                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("The selected input is not valid!");
                }
            }

        }
        #endregion
    }
}
