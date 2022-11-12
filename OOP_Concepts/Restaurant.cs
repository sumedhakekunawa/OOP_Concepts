using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    public partial class Restaurant : Component
    {
        public Restaurant()
        {
            InitializeComponent();
        }

        public Restaurant(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private String name;
        private String address;
        private double gratuityRate;

        public String Name
        {
            get { return name; }
            set { name = value; }

        }
        public String Address
        {
           get { return address; }
           set { address = value; }
        }
        public double GratuityRate
        {
            get { return gratuityRate;}
            set 
            { 
                if(value > 0)
                {
                    gratuityRate = value;
                }
            }
        }

        public Restaurant(String name, String address, double gratuityRate)
        {
            this.Name = name;
            this.Address = address;
            this.GratuityRate = gratuityRate; 
        }

        public void GenerateReceipt()
        {
            double price = 0;
            double subtotal = 0;
            int people = 0;
            double gratuityAmount = 0;
            double grandTotal = 0;

            while(price != -1)
            {
                subtotal = subtotal + price;
                Console.Write("Enter price of food item [-1 to quite] : ");
                price = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("How many people in party : ");
            people = Convert.ToInt32(Console.ReadLine());

            if(people >= 6)
            {
                gratuityAmount = subtotal * gratuityRate; 
            }

            grandTotal = subtotal + gratuityAmount;

            Console.WriteLine("Subtotal : {0:C}", subtotal);
            Console.WriteLine("{0:P} Gratuity : {1:C}", gratuityRate, gratuityAmount);
            Console.WriteLine("Grand Total : {0:C}", grandTotal);

        }
    }
}
