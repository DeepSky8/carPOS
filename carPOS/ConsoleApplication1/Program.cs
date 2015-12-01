using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public enum Color { Red, Green, Blue, Black, Tan, Gold, Silver, White };
        public enum BodyStyle { Coupe, Sedan, Pickup, Van };
        public enum TransmissionType { Automatic, Manual };
        public enum CarMaker { Ford, Chrysler, Chevrolet, Honda, Saturn, Dodge }

        //This program needs to make available the car characteristics, the price for which it was purchased, and the date it was purchased
        public class Car {

            private Color color;
            private BodyStyle bodyStyle;
            private TransmissionType transmissionType;
            private CarMaker carMaker;
            private DateTime yearMade;

            public Car(Color bodyColor, BodyStyle bodyType, TransmissionType transmissionKind, CarMaker carCompany, DateTime yearCreated)
            {
                color = bodyColor;
                bodyStyle = bodyType;
                transmissionType = transmissionKind;
                carMaker = carCompany;
                yearMade = yearCreated;

            }


            public void printCar()
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", color, bodyStyle, transmissionType, carMaker, yearMade);
            }


        }





    }
}
