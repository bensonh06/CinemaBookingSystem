using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] bookedTickets = { 0, 0, 0, 0, 0 };

            int[] seatArray1 = {  0, 0, 0, 0, 0, 0, 0, 0, 0  };
            int[] seatArray2 = {  0, 0, 0, 0, 0, 0, 0, 0, 0  };
            int[] seatArray3 = {  0, 0, 0, 0, 0, 0, 0, 0, 0  };
            int[] seatArray4 = {  0, 0, 0, 0, 0, 0, 0, 0, 0  };
            int[] seatArray5 = {  0, 0, 0, 0, 0, 0, 0, 0, 0  };

            while (true)
            {
                Console.Clear();

                
                bool pickedValidSeat = false;
                int seatRow=0;
                int seatColumn=0;
                int filmNumber = 1;
                int filmAgeRating = 0;
                string filmName = "";

                Console.WriteLine("Welcome to Aquinas Multiplex\nWe are presently showing:");
                Console.WriteLine("1. Rush (15) Tickets Booked: " + bookedTickets[0]);
                Console.WriteLine("2. How I Live Now (15) Tickets Booked: " + bookedTickets[1]);
                Console.WriteLine("3. Thor: The Dark World (12) Tickets Booked: " + bookedTickets[2]);
                Console.WriteLine("4. Filth (18) Tickets Booked: " + bookedTickets[3]);
                Console.WriteLine("5. Planes (U) Tickets Booked: " + bookedTickets[4]);

                while (true)
                {
                    Console.WriteLine("\n\nEnter the number of the film you want to see: ");


                    int film = int.Parse(Console.ReadLine());



                    if (film > 0 && film < 6)
                    {
                        switch (film)
                        {
                            case 1:
                                filmNumber = 1;
                                filmAgeRating = 15;
                                break;
                            case 2:
                                filmNumber = 2;
                                filmAgeRating = 15;
                                break;
                            case 3:
                                filmNumber = 3;
                                filmAgeRating = 12;
                                break;
                            case 4:
                                filmNumber = 4;
                                filmAgeRating = 18;
                                break;
                            case 5:
                                filmNumber = 5;
                                filmAgeRating = 4;
                                break;
                            default:

                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Access Denied - That film doesn't exist");
                    }
                }

                switch (filmNumber)
                {
                    case 1:
                        filmName = "Rush";
                        break;
                    case 2:
                        filmName = "How I Live Now";
                        break;
                    case 3:
                        filmName = "Thor: The Dark World";
                        break;
                    case 4:
                        filmName = "Filth";
                        break;
                    case 5:
                        filmName = "Planes";
                        break;
                    default:
                        break;
                }

                while (true)
                {
                    Console.WriteLine("\nEnter your age: ");


                    int userAge = int.Parse(Console.ReadLine());

                    if (userAge > 0 && userAge >= filmAgeRating)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Access Denied - You are too young to see that film");
                    }
                }

                while (pickedValidSeat == false)
                {

                    Console.Clear();


                    Console.WriteLine("\n  123456789");



                    for (int e = 1; e < 6; e++)
                    {
                        Console.Write(e + " ");
                        for (int i = 0; i < 9; i++)
                        {
                            switch (e)
                            {
                                case 1:
                                    if (seatArray1[i] == 1)
                                    {
                                        Console.Write("X");
                                    }
                                    else
                                    {
                                        Console.Write("O");
                                    }
                                    break;
                                case 2:
                                    if (seatArray2[i] == 1)
                                    {
                                        Console.Write("X");
                                    }
                                    else
                                    {
                                        Console.Write("O");
                                    }
                                    break;
                                case 3:
                                    if (seatArray3[i] == 1)
                                    {
                                        Console.Write("X");
                                    }
                                    else
                                    {
                                        Console.Write("O");
                                    }
                                    break;
                                case 4:
                                    if (seatArray4[i] == 1)
                                    {
                                        Console.Write("X");
                                    }
                                    else
                                    {
                                        Console.Write("O");
                                    }
                                    break;
                                case 5:
                                    if (seatArray5[i] == 1)
                                    {
                                        Console.Write("X");
                                    }
                                    else
                                    {
                                        Console.Write("O");
                                    }
                                    break;
                            }


                        }

                        Console.Write("\n");
                    }

                    Console.WriteLine("\nPick a row and column you would like to sit at (X is occupied, O is unoccupied): \n");

                    Console.Write("Pick a row: ");

                    seatRow = int.Parse(Console.ReadLine());

                    Console.Write("Pick a column: ");

                    seatColumn = int.Parse(Console.ReadLine());

                    if ((seatRow < 6 && seatRow > 0) && (seatColumn < 10 && seatColumn > 0))
                    {
                        
                    }
                    else
                    {
                        continue;
                    }


                    switch (seatRow)
                    {
                        default:
                            Console.WriteLine("Sorry, that seat doesn't exist. Please pick another.");
                            break;
                        case 1:
                            if (seatArray1[(seatColumn - 1)] == 0)
                            {
                                pickedValidSeat = true;
                                seatArray1[(seatColumn - 1)] = 1;
                            }
                            break;
                        case 2:
                            if (seatArray2[(seatColumn - 1)] == 0)
                            {
                                pickedValidSeat = true;
                                seatArray2[(seatColumn - 1)] = 1;
                            }
                            break;
                        case 3:
                            if (seatArray3[(seatColumn - 1)] == 0)
                            {
                                pickedValidSeat = true;
                                seatArray3[(seatColumn - 1)] = 1;
                            }
                            break;
                        case 4:
                            if (seatArray4[(seatColumn - 1)] == 0)
                            {
                                pickedValidSeat = true;
                                seatArray4[(seatColumn - 1)] = 1;
                            }
                            break;
                        case 5:
                            if (seatArray5[(seatColumn - 1)] == 0)
                            {
                                pickedValidSeat = true;
                                seatArray5[(seatColumn - 1)] = 1;
                            }
                            break;
                    }


                }

                while (true)
                {
                    Console.WriteLine("\nEnter a date: ");

                    DateTime movieDate = DateTime.Parse(Console.ReadLine());

                    if ((DateTime.Today.CompareTo(movieDate) == -1) && ((movieDate - DateTime.Today).Days < 8))
                    {
                        bookedTickets[(filmNumber - 1)]++;

                        Console.Clear();
                        Console.WriteLine("\n--------------------");
                        Console.WriteLine("Aquinas Multiplex\nFilm: " + filmName + "\nDate: " + movieDate.ToShortDateString() + "\nSeat: Row " + seatRow + ", Column " + seatColumn + "\n\nEnjoy the film");
                        Console.WriteLine("--------------------");



                        break;
                    }
                    else
                    {
                        Console.WriteLine("Access Denied - Invalid Date");
                    }
                }

                Console.WriteLine("\nBook another ticket? (y/n): ");
                string restart = Console.ReadLine();

                if (restart == "n")
                {
                    break;
                }
            }
        }
    }
}
