using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class UC_1VendingMachine
    {
        public void Currencycount()
        {
            Console.WriteLine("Enter the amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] notes = new int[] {1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] Notescounter = new int[10];

            for (int i = 0; i <7 ; i++)
            {
                if (amount >= notes[i])
                {
                    Notescounter[i] = amount / notes[i];
                    amount = amount - Notescounter[i] * notes[i];
                }
            }

            Console.WriteLine("currency count by vending machine ");
            int NumOfNotes = 0;
            for (int i = 0; i < 7; i++)
            {
                if (Notescounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + Notescounter[i]);
                    NumOfNotes  += Notescounter[i];
                }
            }
            Console.WriteLine("Minimum number of notes : " + NumOfNotes);
        }
    }
}

