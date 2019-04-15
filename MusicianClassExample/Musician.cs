using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MusicianClassExample
{
    internal class Musician
    {
        public enum Instrument
        {
            guitar,
            piano,
            bass,
            drums
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {

                if (value.Length < 3)
                {
                    throw new Exception("FirstName must be greater than 2 characters");
                }
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("LastName must be greater than 2 characters");
                }
                _lastName = value;
            }
        }
        public Instrument MusicalIntrument
        {
            get
            {
                return _instrument;
            }
            set
            {
                _instrument = value;
            }
        }

        private static int _id = 0;
        private string _firstName = String.Empty;
        private string _lastName = string.Empty;
        private Instrument _instrument = Instrument.guitar;

        public event EventHandler Finished;

        public Musician(string firstName, string lastName, Instrument instrument)
        {
            _id++;
            FirstName = firstName;
            LastName = lastName;
            MusicalIntrument = instrument;
        }

        public void Play()
        {
            Console.WriteLine($"{this} is playing the {MusicalIntrument}");
            Thread.Sleep(7000);

            Finished?.Invoke(this, null);

        }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName}";
        }

    }
}
