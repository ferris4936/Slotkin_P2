﻿//Programmer: Erica Slotkin
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
        private double moles;
        private double kelvin;

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
            this.pascals = (moles * R * kelvin) / volume;
        }

        private double NumberOfMoles()
        {
            moles = mass / molecularWeight;
            return this.moles;
        }

        private double CelsiusToKelvin()
        {
            kelvin = temperature + 273.15;
            return this.kelvin;
        }
    }
}
