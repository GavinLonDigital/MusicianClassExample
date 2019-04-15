using System;

namespace MusicianClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Musician musician1 = new Musician("Kevin", "Jones", Musician.Instrument.guitar);
                musician1.Finished += Musician_Finished;
                musician1.Play();

                Musician musician2 = new Musician("Bob", "Harris", Musician.Instrument.piano);
                musician2.Finished += Musician_Finished;
                musician2.Play();

                Musician musician3 = new Musician("Sarah", "Harris", Musician.Instrument.drums);
                musician3.Finished += Musician_Finished;
                musician3.Play();

                Musician musician4 = new Musician("Stephan", "Brown", Musician.Instrument.bass);
                musician4.Finished += Musician_Finished;
                musician4.Play();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("-End-");
            }


            Console.ReadKey();
        }

        private static void Musician_Finished(object sender, EventArgs e)
        {
            Console.WriteLine($"{sender} has finished playing");
        }

    }
}
