//Blaine Smith
//11-30-2019
//Bellevue University
//Assignment 6.2
//This program show the use of an interface and how they might be implemented.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignment6._2
{
    class RecoveringDemo
    {
        static void Main(string[] args)
        {
            Patient firstPatient = new Patient();
            Upholsterer couchMender = new Upholsterer();
            FootballPlayer player = new FootballPlayer();

            Write("The patient might say: ");
            firstPatient.Recover();
            Write("The upholsterer might say: ");
            couchMender.Recover();
            Write("The football player could say: ");
            player.Recover();
        }
    }

    public interface IRecoverable
    {
        void Recover();
    }

    class Patient : IRecoverable
    {
        public void Recover()
        {
            WriteLine("I am getting better");
        }
    }

    class Upholsterer : IRecoverable
    {
        public void Recover()
        {
            WriteLine("I have material for the couch");
        }
    }

    class FootballPlayer : IRecoverable
    {
        public void Recover()
        {
            WriteLine("I picked up the ball after a fumble");
        }
    }
}
