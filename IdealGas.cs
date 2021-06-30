//Programmer: Erica Slotkin
//Email: eslotkin@cnm.edu
//Program 2: Ideal Gas Calculator using a class 

//File: IdealGas.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace Slotkin_P2
{
    class IdealGas
    {
        private double mass;
        private double volume;
        private double temperature;
        private double molecularWeight;
        private double pascals;

        public IdealGas()
        {
        }

        public double GetMass()
        {
            return this.mass;
        }
        public void SetMass(double value)
        {
            this.mass = value;
            Calc();
        }
        public double GetVolume()
        {
            return this.volume;
        }
        public void SetVolume(double value)
        {
            this.volume = value;
            Calc();
        }
        public double GetTemp()
        {
            return this.temperature;
        }
        public void SetTemp(double value)
        {
            this.temperature = value;
            Calc();
        }
        public double GetMolecularWeight()
        {
            return this.molecularWeight;
        }
        public void SetMolecularWeight(double value)
        {
            this.molecularWeight = value;
            Calc();
        }
        public double GetPressure()
        {
            return this.pascals; 
        }
       
        private void Calc()  //calculates pressure in pascals
        {
            const double R = 8.3145; //measured in m3
            //calculate and return pressure in pascals using (P = nRT/V):
            double moles = NumberOfMoles(mass, molecularWeight);
            double kelvin = CelsiusToKelvin(temperature);
            this.pascals = (moles * R * kelvin) / volume;
        }

        private double NumberOfMoles(double mass, double molecularWeight)
        {
            //calculate and return moles using mass/molecularWeight)
            double moles = mass / molecularWeight;
            return moles;
        }

        private double CelsiusToKelvin(double temperature)  
        {
            double kelvin = temperature + 273.15;
            return kelvin;
        }
    }
}
